namespace XdevTools
{
    partial class JsonToDockerEnvFile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonToDockerEnvFile));
            splitContainer1 = new SplitContainer();
            txtSource = new RichTextBox();
            txtResult = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtSource);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResult);
            splitContainer1.Size = new Size(840, 564);
            splitContainer1.SplitterDistance = 397;
            splitContainer1.TabIndex = 1;
            // 
            // txtSource
            // 
            txtSource.BorderStyle = BorderStyle.FixedSingle;
            txtSource.Dock = DockStyle.Fill;
            txtSource.Location = new Point(0, 0);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(397, 564);
            txtSource.TabIndex = 1;
            txtSource.Text = "";
            txtSource.TextChanged += richTextBox1_TextChanged_1;
            // 
            // txtResult
            // 
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Dock = DockStyle.Fill;
            txtResult.Location = new Point(0, 0);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(439, 564);
            txtResult.TabIndex = 1;
            txtResult.Text = "";
            // 
            // JsonToDockerEnvFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 564);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "JsonToDockerEnvFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Api Json Setting section to Docker string Env";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox txtSource;
        private RichTextBox txtResult;
    }
}