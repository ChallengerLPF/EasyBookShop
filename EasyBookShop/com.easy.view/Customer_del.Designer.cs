namespace EasyBookShop.com.easy.view
{
    partial class Customer_del
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_nic = new System.Windows.Forms.Label();
            this.cmb_method = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_expmt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_chvalue = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_chno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_balance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_payment = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_cash = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_billtotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_blno = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.datagrid_cusdel = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_pending = new MetroFramework.Controls.MetroTextBox();
            this.lbl_pending = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_cusdel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Minion Pro Cond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_name.Location = new System.Drawing.Point(109, 10);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(94, 44);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "label1";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nic
            // 
            this.lbl_nic.AutoSize = true;
            this.lbl_nic.Font = new System.Drawing.Font("Minion Pro Cond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_nic.Location = new System.Drawing.Point(109, 51);
            this.lbl_nic.Name = "lbl_nic";
            this.lbl_nic.Size = new System.Drawing.Size(94, 44);
            this.lbl_nic.TabIndex = 2;
            this.lbl_nic.Text = "label1";
            // 
            // cmb_method
            // 
            this.cmb_method.FormattingEnabled = true;
            this.cmb_method.ItemHeight = 23;
            this.cmb_method.Items.AddRange(new object[] {
            "All payments",
            "Cash payments",
            "Check payments",
            "Credit payments"});
            this.cmb_method.Location = new System.Drawing.Point(840, 25);
            this.cmb_method.Name = "cmb_method";
            this.cmb_method.Size = new System.Drawing.Size(182, 29);
            this.cmb_method.Sorted = true;
            this.cmb_method.TabIndex = 32;
            this.cmb_method.SelectedIndexChanged += new System.EventHandler(this.cmb_method_SelectedIndexChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.CustomBackground = true;
            this.metroLabel16.CustomForeColor = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel16.Location = new System.Drawing.Point(845, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(172, 25);
            this.metroLabel16.TabIndex = 33;
            this.metroLabel16.Text = "Payments  Method";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.metroLabel11);
            this.panel2.Controls.Add(this.txt_pending);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.txt_expmt);
            this.panel2.Controls.Add(this.metroLabel9);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txt_chvalue);
            this.panel2.Controls.Add(this.metroLabel8);
            this.panel2.Controls.Add(this.txt_chno);
            this.panel2.Controls.Add(this.metroLabel7);
            this.panel2.Controls.Add(this.txt_balance);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Controls.Add(this.txt_payment);
            this.panel2.Controls.Add(this.metroRadioButton2);
            this.panel2.Controls.Add(this.rbtn_cash);
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.metroLabel6);
            this.panel2.Controls.Add(this.txt_billtotal);
            this.panel2.Controls.Add(this.metroLabel4);
            this.panel2.Controls.Add(this.metroLabel10);
            this.panel2.Controls.Add(this.txt_blno);
            this.panel2.Location = new System.Drawing.Point(7, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 626);
            this.panel2.TabIndex = 34;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(15, 519);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 25);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Extra Payment Rs :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_expmt
            // 
            this.txt_expmt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_expmt.Location = new System.Drawing.Point(15, 547);
            this.txt_expmt.Name = "txt_expmt";
            this.txt_expmt.Size = new System.Drawing.Size(284, 30);
            this.txt_expmt.TabIndex = 43;
            this.txt_expmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(15, 458);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(162, 25);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "Check Amount Rs :";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 38);
            this.button2.TabIndex = 28;
            this.button2.Text = "C a n c l e";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(158, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "A d d";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_chvalue
            // 
            this.txt_chvalue.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_chvalue.Location = new System.Drawing.Point(15, 486);
            this.txt_chvalue.Name = "txt_chvalue";
            this.txt_chvalue.Size = new System.Drawing.Size(284, 30);
            this.txt_chvalue.TabIndex = 41;
            this.txt_chvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(15, 397);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 25);
            this.metroLabel8.TabIndex = 38;
            this.metroLabel8.Text = "Check No :";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_chno
            // 
            this.txt_chno.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_chno.Location = new System.Drawing.Point(15, 425);
            this.txt_chno.Name = "txt_chno";
            this.txt_chno.Size = new System.Drawing.Size(284, 30);
            this.txt_chno.TabIndex = 39;
            this.txt_chno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(15, 336);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(104, 25);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "Balance Rs :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // txt_balance
            // 
            this.txt_balance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_balance.Location = new System.Drawing.Point(15, 364);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(284, 30);
            this.txt_balance.TabIndex = 37;
            this.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_balance.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(15, 275);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(113, 25);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Payment Rs :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_payment
            // 
            this.txt_payment.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_payment.Location = new System.Drawing.Point(15, 303);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(284, 30);
            this.txt_payment.TabIndex = 35;
            this.txt_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.CustomForeColor = true;
            this.metroRadioButton2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroRadioButton2.Location = new System.Drawing.Point(158, 246);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(120, 25);
            this.metroRadioButton2.TabIndex = 33;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "Cheque Pay";
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            this.metroRadioButton2.Click += new System.EventHandler(this.metroRadioButton2_Click);
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.CustomForeColor = true;
            this.rbtn_cash.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.rbtn_cash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbtn_cash.Location = new System.Drawing.Point(42, 246);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(98, 25);
            this.rbtn_cash.TabIndex = 32;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "Cash Pay";
            this.rbtn_cash.UseVisualStyleBackColor = true;
            this.rbtn_cash.Click += new System.EventHandler(this.metroRadioButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(15, 214);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(157, 25);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Payment Method :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(15, 93);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 25);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Total Rs :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_billtotal
            // 
            this.txt_billtotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_billtotal.Location = new System.Drawing.Point(15, 121);
            this.txt_billtotal.Name = "txt_billtotal";
            this.txt_billtotal.Size = new System.Drawing.Size(284, 30);
            this.txt_billtotal.TabIndex = 30;
            this.txt_billtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel4.Location = new System.Drawing.Point(93, 5);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 25);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Bill Updates";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(15, 31);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(63, 25);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Bill No";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_blno
            // 
            this.txt_blno.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_blno.Location = new System.Drawing.Point(15, 59);
            this.txt_blno.Name = "txt_blno";
            this.txt_blno.Size = new System.Drawing.Size(284, 30);
            this.txt_blno.TabIndex = 18;
            this.txt_blno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.metroLabel2);
            this.panel3.Controls.Add(this.datagrid_cusdel);
            this.panel3.Controls.Add(this.metroLabel16);
            this.panel3.Controls.Add(this.cmb_method);
            this.panel3.Location = new System.Drawing.Point(328, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 626);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::EasyBookShop.Properties.Resources.rsz_billing;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 51);
            this.panel4.TabIndex = 36;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel2.Location = new System.Drawing.Point(62, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 25);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Bill Details";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datagrid_cusdel
            // 
            this.datagrid_cusdel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_cusdel.Location = new System.Drawing.Point(3, 59);
            this.datagrid_cusdel.Name = "datagrid_cusdel";
            this.datagrid_cusdel.Size = new System.Drawing.Size(1023, 562);
            this.datagrid_cusdel.TabIndex = 34;
            this.datagrid_cusdel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EasyBookShop.Properties.Resources.rsz_become_customer_icon_blue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 89);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(15, 154);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(109, 25);
            this.metroLabel11.TabIndex = 44;
            this.metroLabel11.Text = "Pending Rs :";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_pending
            // 
            this.txt_pending.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_pending.Location = new System.Drawing.Point(15, 182);
            this.txt_pending.Name = "txt_pending";
            this.txt_pending.Size = new System.Drawing.Size(284, 30);
            this.txt_pending.TabIndex = 45;
            this.txt_pending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_pending
            // 
            this.lbl_pending.AutoSize = true;
            this.lbl_pending.Font = new System.Drawing.Font("Minion Pro Cond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_pending.Location = new System.Drawing.Point(1044, 51);
            this.lbl_pending.Name = "lbl_pending";
            this.lbl_pending.Size = new System.Drawing.Size(94, 44);
            this.lbl_pending.TabIndex = 36;
            this.lbl_pending.Text = "label1";
            // 
            // Customer_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 735);
            this.Controls.Add(this.lbl_pending);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_nic);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Name = "Customer_del";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Customer_del";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_del_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_cusdel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_nic;
        private MetroFramework.Controls.MetroComboBox cmb_method;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_blno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagrid_cusdel;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton rbtn_cash;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_billtotal;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_chvalue;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_chno;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_balance;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_payment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_expmt;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_pending;
        private System.Windows.Forms.Label lbl_pending;
    }
}