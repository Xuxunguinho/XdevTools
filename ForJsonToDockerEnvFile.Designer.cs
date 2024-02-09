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
            panel1 = new Panel();
            label1 = new Label();
            txtResult = new RichTextBox();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResult);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(943, 612);
            splitContainer1.SplitterDistance = 452;
            splitContainer1.TabIndex = 1;
            // 
            // txtSource
            // 
            txtSource.BorderStyle = BorderStyle.FixedSingle;
            txtSource.Dock = DockStyle.Fill;
            txtSource.Location = new Point(0, 39);
            txtSource.Name = "txtSource";
            txtSource.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            txtSource.Size = new Size(452, 573);
            txtSource.TabIndex = 1;
            txtSource.Text = "";
            txtSource.TextChanged += richTextBox1_TextChanged_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 39);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 13);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Source";
            // 
            // txtResult
            // 
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Dock = DockStyle.Fill;
            txtResult.Location = new Point(0, 39);
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            txtResult.Size = new Size(487, 573);
            txtResult.TabIndex = 1;
            txtResult.Text = "";
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 39);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 13);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Result";
            // 
            // JsonToDockerEnvFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 612);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "JsonToDockerEnvFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JSON TO DOCKER ENV STRING";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox txtSource;
        private RichTextBox txtResult;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
    }
}