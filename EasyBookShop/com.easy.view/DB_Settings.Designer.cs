namespace EasyBookShop.com.easy.view
{
    partial class DB_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_Settings));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_host = new MetroFramework.Controls.MetroTextBox();
            this.txt_port = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_uname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_pw = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Server/Host :";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(107, 71);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(164, 23);
            this.txt_host.TabIndex = 1;
            this.txt_host.Text = "localhost";
            this.txt_host.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(107, 102);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(164, 23);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "3306";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(60, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Port :";
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(107, 133);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(164, 23);
            this.txt_uname.TabIndex = 5;
            this.txt_uname.Text = "root";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Username :";
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(107, 166);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '.';
            this.txt_pw.Size = new System.Drawing.Size(164, 23);
            this.txt_pw.TabIndex = 7;
            this.txt_pw.Text = "123,";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 167);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Password :";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 235);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(248, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Cancle";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 206);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 23);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Reset Default";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(154, 206);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(117, 23);
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Save Changes";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(64, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 56);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.Teal;
            this.metroLabel11.Location = new System.Drawing.Point(135, 23);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(81, 25);
            this.metroLabel11.TabIndex = 17;
            this.metroLabel11.Text = "Settings";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DB_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 295);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.metroLabel1);
            this.DisplayHeader = false;
            this.Name = "DB_Settings";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "DB_Settings";
            this.Load += new System.EventHandler(this.DB_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_host;
        private MetroFramework.Controls.MetroTextBox txt_port;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_uname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_pw;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}