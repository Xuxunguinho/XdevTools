using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XdevTools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid().ToString();
            Clipboard.SetText(guid);
            MessageBox.Show("O Guid gerado com sucesso,basta usar  Ctrl + V  para colar em qualquer lugar", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new JsonToDockerEnvFile();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://github.com/Xuxunguinho") { UseShellExecute = true });
        }
    }
}
