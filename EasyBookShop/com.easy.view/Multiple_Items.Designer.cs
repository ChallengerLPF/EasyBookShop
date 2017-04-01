namespace EasyBookShop.com.easy.view
{
    partial class Multiple_Items
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Show_hide = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_orprice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_dis = new MetroFramework.Controls.MetroTextBox();
            this.txt_selprice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_rqty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_icode = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Show_hide
            // 
            this.Show_hide.AutoSize = true;
            this.Show_hide.CustomForeColor = true;
            this.Show_hide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Show_hide.Location = new System.Drawing.Point(693, 294);
            this.Show_hide.Name = "Show_hide";
            this.Show_hide.Size = new System.Drawing.Size(52, 15);
            this.Show_hide.TabIndex = 44;
            this.Show_hide.Text = "Show";
            this.Show_hide.UseVisualStyleBackColor = true;
            this.Show_hide.CheckedChanged += new System.EventHandler(this.Show_hide_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(339, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 25);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Quantity";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(485, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 34);
            this.button2.TabIndex = 42;
            this.button2.Text = "C l e a r";
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
            this.button1.Location = new System.Drawing.Point(624, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 36;
            this.button1.Text = "A d d";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_orprice
            // 
            this.txt_orprice.CustomBackground = true;
            this.txt_orprice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_orprice.Location = new System.Drawing.Point(485, 315);
            this.txt_orprice.Multiline = true;
            this.txt_orprice.Name = "txt_orprice";
            this.txt_orprice.PasswordChar = '$';
            this.txt_orprice.Size = new System.Drawing.Size(260, 30);
            this.txt_orprice.TabIndex = 41;
            this.txt_orprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(339, 287);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(128, 25);
            this.metroLabel8.TabIndex = 38;
            this.metroLabel8.Text = "Stock Quantity";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(485, 287);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(149, 25);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "Original Price Rs :";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_qty
            // 
            this.txt_qty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_qty.Location = new System.Drawing.Point(339, 315);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(128, 30);
            this.txt_qty.TabIndex = 39;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(10, 287);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(138, 25);
            this.metroLabel10.TabIndex = 35;
            this.metroLabel10.Text = "Item Discription";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_dis
            // 
            this.txt_dis.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_dis.Location = new System.Drawing.Point(10, 315);
            this.txt_dis.Name = "txt_dis";
            this.txt_dis.Size = new System.Drawing.Size(305, 30);
            this.txt_dis.TabIndex = 37;
            this.txt_dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_selprice
            // 
            this.txt_selprice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_selprice.Location = new System.Drawing.Point(485, 239);
            this.txt_selprice.Name = "txt_selprice";
            this.txt_selprice.ReadOnly = true;
            this.txt_selprice.Size = new System.Drawing.Size(260, 30);
            this.txt_selprice.TabIndex = 34;
            this.txt_selprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(485, 211);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(139, 25);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Salling Price Rs :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_rqty
            // 
            this.txt_rqty.CustomBackground = true;
            this.txt_rqty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_rqty.Location = new System.Drawing.Point(339, 239);
            this.txt_rqty.Name = "txt_rqty";
            this.txt_rqty.Size = new System.Drawing.Size(128, 30);
            this.txt_rqty.TabIndex = 32;
            this.txt_rqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_rqty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_rqty_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(10, 211);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 25);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Item Code";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_icode
            // 
            this.txt_icode.BackColor = System.Drawing.SystemColors.Control;
            this.txt_icode.CustomBackground = true;
            this.txt_icode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_icode.Location = new System.Drawing.Point(10, 239);
            this.txt_icode.Name = "txt_icode";
            this.txt_icode.Size = new System.Drawing.Size(305, 30);
            this.txt_icode.TabIndex = 31;
            this.txt_icode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_icode.Click += new System.EventHandler(this.txt_icode_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(10, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(735, 150);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel7.Location = new System.Drawing.Point(10, 11);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(241, 25);
            this.metroLabel7.TabIndex = 46;
            this.metroLabel7.Text = "M a k e   Y o u r   C h o i c e";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::EasyBookShop.Properties.Resources.rsz_fa6e16ae904eb5c381b10051e06775bc;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(720, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 25);
            this.button3.TabIndex = 47;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(293, 372);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(35, 13);
            this.lbl_id.TabIndex = 48;
            this.lbl_id.Text = "label1";
            this.lbl_id.Visible = false;
            // 
            // Multiple_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Show_hide);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_orprice);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txt_dis);
            this.Controls.Add(this.txt_selprice);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_rqty);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_icode);
            this.Name = "Multiple_Items";
            this.Size = new System.Drawing.Size(753, 397);
            this.Load += new System.EventHandler(this.Multiple_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox Show_hide;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox txt_orprice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_dis;
        private MetroFramework.Controls.MetroTextBox txt_selprice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_rqty;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_icode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_id;
    }
}
