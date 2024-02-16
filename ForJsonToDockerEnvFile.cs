using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace XdevTools
{
    public partial class JsonToDockerEnvFile : Form
    {
        public JsonToDockerEnvFile()
        {
            InitializeComponent();
        }

        private string InitialValue { get; set; } = string.Empty;
        private string _initialDefaultValue = string.Empty;
        public bool Inverted = false;
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void AddToClipboard()
        {
            Clipboard.SetText(txtSource.Text);
            MessageBox.Show("The result was copied,use Ctrl + V to paste anywhere", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormatJsonText(string source)
        {
            using (var sr = new StringReader(source))
            using (var sw = new StringWriter())
            {
                var jr = new JsonTextReader(sr);
                var jw = new JsonTextWriter(sw) { Formatting = Formatting.Indented };
                jw.WriteToken(jr);
                txtSource.Text = sw.ToString();
            }
        }
        /// <summary>
        /// Recursive Method to read all properties and get data from an JsonItem
        /// </summary>
        /// <param name="jToken"></param>
        /// <param name="strFinalValue"></param>
        /// <param name="strBuilder"></param>
        private void GetValueFromProperty(JToken jToken, string strFinalValue, StringBuilder strBuilder)
        {
            try
            {

                if (jToken.Type == JTokenType.Array)
                {
                    strFinalValue += $"={jToken}";

                    strBuilder.AppendLine(strFinalValue);

                    strFinalValue = InitialValue;
                }
                else
                {

                    foreach (JProperty property in jToken)
                    {
                        if (property.Value.HasValues)
                        {

                            strFinalValue += "__" + property.Name;

                            if (property.Value.Count() > 1)
                                InitialValue += "__" + property.Name;

                            GetValueFromProperty(property.Value, strFinalValue, strBuilder);

                            strFinalValue = InitialValue;
                        }
                        else
                        {

                            strFinalValue += $"__{property.Name}={property.Value}";

                            strBuilder.AppendLine(strFinalValue);

                            strFinalValue = InitialValue;
                        }

                    }
                }



                InitialValue = _initialDefaultValue;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        (string, string) GetDockerEnvStringFieldData(string source)
        {
            if (source.Trim().StartsWith('-'))
                source = source.Trim().Remove(0, 1);

            var words = source.Split('=');
            return (words[0], source.Remove(0, words[0].Length).Remove(0, 1));
        }
        object Convert(string text)
        {

            if (int.TryParse(text, out var number)) return number;
            if (double.TryParse(text, out var snumber)) return snumber;
            if (float.TryParse(text, out var fnumber)) return fnumber;
            if (decimal.TryParse(text, out var dcnumber)) return dcnumber;
            if (DateTime.TryParse(text, out var date)) return date;
            if (Guid.TryParse(text, out var guid)) return guid;

            return text;
        }

        internal async Task<string> ParsedDockerEnvStringToJson(string data)
        {
            try
            {

                var dir = Path.Combine(Path.GetTempPath(), $"{Path.GetTempFileName}.txt");
                await File.WriteAllTextAsync(dir, data);
                var lines = File.ReadAllLines(dir);

                var dic = new Dictionary<string, ExpandoObject>();

                dynamic? root = null;

                foreach (var item in lines)
                {

                    if (string.IsNullOrEmpty(item.Trim())) continue;

                    var dados = GetDockerEnvStringFieldData(item.Trim());



                    var rootKey = dados.Item1.Trim();

                    var words = dados.Item1.Split("__");
                    var value = Convert(dados.Item2.Trim());

                    if (words.Length > 1)
                    {
                        rootKey = words[0].Trim();

                        dynamic temp = new ExpandoObject();

                        if (dic.ContainsKey(rootKey))
                            root = dic[rootKey];
                        else
                        {
                            root = new ExpandoObject();
                            ((IDictionary<string, object>)root).Add(rootKey, new ExpandoObject());
                            dic.Add(rootKey, root);
                        }

                        for (var i = 1; i < words.Length; i++)
                        {

                            var previousKey = words[i - 1].Trim();
                            var atualKey = words[i].Trim();

                            dynamic obj = new ExpandoObject();

                            if (i == words.Length - 1)
                            {
                                ((IDictionary<string, object>)obj).Add(atualKey, value);


                                if (previousKey.Equals(rootKey))
                                {
                                    if (((IDictionary<string, object>)root)[previousKey] is ExpandoObject)
                                        ((ExpandoObject)((IDictionary<string, object>)root)[previousKey]).TryAdd(atualKey, value);
                                    else
                                        ((IDictionary<string, object>)root)[previousKey] = obj;
                                }
                                else
                                {


                                    if (((IDictionary<string, object>)temp)[previousKey] is ExpandoObject)
                                        ((ExpandoObject)((IDictionary<string, object>)temp)[previousKey]).TryAdd(atualKey, value);

                                }

                            }
                            else
                            {
                                if (((IDictionary<string, object>)root).ContainsKey(previousKey) && !previousKey.Equals(rootKey))
                                {
                                    ((ExpandoObject)((IDictionary<string, object>)root)[previousKey]).TryAdd(atualKey, value);
                                }
                                else
                                {


                                    ((IDictionary<string, object>)obj).Add(atualKey, new ExpandoObject());

                                    if (previousKey.Equals(rootKey))
                                    {
                                        if (((IDictionary<string, object>)root)[previousKey] is ExpandoObject)

                                        {
                                            ((ExpandoObject)((IDictionary<string, object>)root)[previousKey]).TryAdd(atualKey, new ExpandoObject());
                                            temp = ((ExpandoObject)((IDictionary<string, object>)root)[previousKey]);
                                        }
                                        else
                                            temp = ((IDictionary<string, object>)root)[previousKey] = obj;
                                    }


                                }

                            }
                        }
                    }
                    else
                    {
                        root = new ExpandoObject();
                        if (dic.ContainsKey(rootKey))
                            (dic[rootKey] as IDictionary<string, object>).Add(rootKey, value);
                        else
                        {
                            ((IDictionary<string, object>)root).Add(rootKey, value);
                            dic.Add(rootKey, ((ExpandoObject)root));
                        }
                    }
                }

                root = new ExpandoObject();
                foreach (var key in dic.Keys)
                {
                    var value = (dic[key] as IDictionary<string, object>).Values.FirstOrDefault();
                    ((IDictionary<string, object>)root).Add(key, value);
                }

                File.Delete(dir);
                return System.Text.Json.JsonSerializer.Serialize(root); ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return string.Empty;
            }
        }

        private async void txtResult_TextChanged(object sender, EventArgs e)
        {


        }

        private async void button1_Click(object sender, EventArgs e)
        {                    
            txtSource.Text = await ParsedDockerEnvStringToJson(txtSource.Text);
            FormatJsonText(txtSource.Text);       
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {

                var stringData = txtSource.Text.Trim().StartsWith("{") ? txtSource.Text : "{" + txtSource.Text + "}";

                //txtResult.Text = string.Empty;

                if (string.IsNullOrEmpty(txtSource.Text.Trim())) return;

                FormatJsonText(stringData);

                var jsonItem = JObject.Parse(stringData);
                var strBuilder = new StringBuilder();

                foreach (JProperty property in jsonItem.Properties())
                {
                    InitialValue = $"- {property.Name}";

                    if (jsonItem.Properties().Count() == 1)
                        _initialDefaultValue = InitialValue;

                    if (property.Value.HasValues)
                        GetValueFromProperty(property.Value, InitialValue, strBuilder);
                    else
                        strBuilder.AppendLine(InitialValue + $"={property.Value}");
                }

                txtSource.Text = strBuilder.ToString();

                if (string.IsNullOrEmpty(txtSource.Text)) return;
            

            }
            catch (Exception ex)
            {
                txtSource.Text = ex.Message;
            }
        }

        private void JsonToDockerEnvFile_Resize(object sender, EventArgs e)
        {
            var center = (panTop.Size.Width / 2) - (panCenterTop.Width / 2);
            panCenterTop.Location = new Point(center, panCenterTop.Location.Y);
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtSource.Text))
                {

                    btnJsonToDocker.Enabled = false;
                    btnDockerToJson.Enabled = false;

                    return;
                }
                JsonDocument.Parse(txtSource.Text);
                btnJsonToDocker.Enabled = true;
                btnDockerToJson.Enabled = false;
            }
            catch (System.Text.Json.JsonException ex)
            {
                btnJsonToDocker.Enabled = false;
                btnDockerToJson.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddToClipboard() ;
        }
    }
}