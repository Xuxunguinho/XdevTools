using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
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

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var stringData = txtSource.Text.Trim().StartsWith("{") ? txtSource.Text : "{" + txtSource.Text + "}";

                txtResult.Text = string.Empty;

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

                txtResult.Text = strBuilder.ToString();

                if (string.IsNullOrEmpty(txtResult.Text)) return;
                AddToClipboard();

            }
            catch (Exception ex)
            {

                txtResult.Text = ex.Message;
            }
        }
        private void AddToClipboard()
        {
            Clipboard.SetText(txtResult.Text);
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

    }
}