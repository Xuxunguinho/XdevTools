namespace XdevTools
{
    partial class JsonFormatter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonFormatter));
            txtSource = new RichTextBox();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.BorderStyle = BorderStyle.FixedSingle;
            txtSource.Dock = DockStyle.Fill;
            txtSource.Location = new Point(0, 0);
            txtSource.Name = "txtSource";
            txtSource.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            txtSource.Size = new Size(943, 612);
            txtSource.TabIndex = 2;
            txtSource.Text = "";
            txtSource.TextChanged += richTextBox1_TextChanged_1;
            // 
            // JsonFormatter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 612);
            Controls.Add(txtSource);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "JsonFormatter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JSON FORMATTER";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtSource;
    }
}