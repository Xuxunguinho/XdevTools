using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows.Forms;

namespace XdevTools
{
    public partial class JsonFormatter : Form
    {
        public JsonFormatter()
        {
            InitializeComponent();
        }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var stringData = txtSource.Text.Trim().StartsWith("{") ? txtSource.Text : "{" + txtSource.Text + "}";

                if (string.IsNullOrEmpty(txtSource.Text.Trim())) return;

                FormatJsonText(stringData);

            }
            catch (Exception ex)
            {
                txtSource.Text = ex.Message;
            }
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


    }
}