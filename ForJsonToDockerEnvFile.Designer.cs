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
            btnDockerToJson = new Button();
            btnJsonToDocker = new Button();
            panTop = new Panel();
            panCenterTop = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            txtSource = new RichTextBox();
            button1 = new Button();
            panTop.SuspendLayout();
            panCenterTop.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDockerToJson
            // 
            btnDockerToJson.BackColor = Color.White;
            btnDockerToJson.Enabled = false;
            btnDockerToJson.FlatStyle = FlatStyle.Flat;
            btnDockerToJson.ForeColor = Color.Black;
            btnDockerToJson.Location = new Point(178, 3);
            btnDockerToJson.Name = "btnDockerToJson";
            btnDockerToJson.Size = new Size(187, 31);
            btnDockerToJson.TabIndex = 1;
            btnDockerToJson.Text = "Convert To Json";
            btnDockerToJson.UseVisualStyleBackColor = false;
            btnDockerToJson.Click += button1_Click;
            // 
            // btnJsonToDocker
            // 
            btnJsonToDocker.BackColor = Color.White;
            btnJsonToDocker.Enabled = false;
            btnJsonToDocker.FlatStyle = FlatStyle.Flat;
            btnJsonToDocker.ForeColor = Color.Black;
            btnJsonToDocker.Location = new Point(3, 3);
            btnJsonToDocker.Name = "btnJsonToDocker";
            btnJsonToDocker.Size = new Size(169, 31);
            btnJsonToDocker.TabIndex = 1;
            btnJsonToDocker.Text = "Convert To Docker Env";
            btnJsonToDocker.UseVisualStyleBackColor = false;
            btnJsonToDocker.Click += button2_Click;
            // 
            // panTop
            // 
            panTop.BackColor = Color.White;
            panTop.BorderStyle = BorderStyle.FixedSingle;
            panTop.Controls.Add(panCenterTop);
            panTop.Dock = DockStyle.Top;
            panTop.Location = new Point(0, 0);
            panTop.Name = "panTop";
            panTop.Padding = new Padding(0, 0, 0, 2);
            panTop.Size = new Size(836, 45);
            panTop.TabIndex = 4;
            // 
            // panCenterTop
            // 
            panCenterTop.Controls.Add(button1);
            panCenterTop.Controls.Add(btnJsonToDocker);
            panCenterTop.Controls.Add(btnDockerToJson);
            panCenterTop.Location = new Point(175, 3);
            panCenterTop.Name = "panCenterTop";
            panCenterTop.Size = new Size(476, 37);
            panCenterTop.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(836, 558);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtSource);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 538);
            panel2.TabIndex = 0;
            // 
            // txtSource
            // 
            txtSource.BackColor = SystemColors.ControlLightLight;
            txtSource.BorderStyle = BorderStyle.None;
            txtSource.Dock = DockStyle.Fill;
            txtSource.Location = new Point(0, 0);
            txtSource.Name = "txtSource";
            txtSource.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            txtSource.Size = new Size(814, 536);
            txtSource.TabIndex = 5;
            txtSource.Text = "";
            txtSource.TextChanged += txtSource_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(371, 3);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 2;
            button1.Text = "Copy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // JsonToDockerEnvFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 603);
            Controls.Add(panel1);
            Controls.Add(panTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "JsonToDockerEnvFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JSON TO DOCKER ENV STRING";
            Resize += JsonToDockerEnvFile_Resize;
            panTop.ResumeLayout(false);
            panCenterTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDockerToJson;
        private Button btnJsonToDocker;
        private Panel panTop;
        private Panel panCenterTop;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox txtSource;
        private Button button1;
    }
}