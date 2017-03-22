﻿namespace EasyBookShop.views
{
    partial class NewItemOr
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtRetailPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtWholesalePrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtSpecialPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtLastPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtPackSize = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtPackPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btnAddItem = new MetroFramework.Controls.MetroButton();
            this.listCategory = new System.Windows.Forms.ListBox();
            this.listSubCategory = new System.Windows.Forms.ListBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.sub_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sub_categoriesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(166, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Barcode ";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = null;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtBarcode.CustomButton.Name = "";
            this.txtBarcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarcode.CustomButton.TabIndex = 1;
            this.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarcode.CustomButton.UseSelectable = true;
            this.txtBarcode.CustomButton.Visible = false;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(298, 104);
            this.txtBarcode.MaxLength = 32767;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(179, 23);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBarcode.UseCustomBackColor = true;
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyUp);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(457, 321);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(565, 321);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(129, 69);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescription.UseCustomBackColor = true;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(749, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Category";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(749, 282);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Sub category";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtRetailPrice.CustomButton.Image = null;
            this.txtRetailPrice.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtRetailPrice.CustomButton.Name = "";
            this.txtRetailPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRetailPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRetailPrice.CustomButton.TabIndex = 1;
            this.txtRetailPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRetailPrice.CustomButton.UseSelectable = true;
            this.txtRetailPrice.CustomButton.Visible = false;
            this.txtRetailPrice.Lines = new string[0];
            this.txtRetailPrice.Location = new System.Drawing.Point(298, 179);
            this.txtRetailPrice.MaxLength = 32767;
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.PasswordChar = '\0';
            this.txtRetailPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetailPrice.SelectedText = "";
            this.txtRetailPrice.SelectionLength = 0;
            this.txtRetailPrice.SelectionStart = 0;
            this.txtRetailPrice.ShortcutsEnabled = true;
            this.txtRetailPrice.Size = new System.Drawing.Size(118, 23);
            this.txtRetailPrice.TabIndex = 10;
            this.txtRetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetailPrice.UseCustomBackColor = true;
            this.txtRetailPrice.UseSelectable = true;
            this.txtRetailPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetailPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetailPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRetailPrice_KeyUp);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(166, 183);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Retail Price";
            // 
            // txtWholesalePrice
            // 
            this.txtWholesalePrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtWholesalePrice.CustomButton.Image = null;
            this.txtWholesalePrice.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtWholesalePrice.CustomButton.Name = "";
            this.txtWholesalePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWholesalePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWholesalePrice.CustomButton.TabIndex = 1;
            this.txtWholesalePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWholesalePrice.CustomButton.UseSelectable = true;
            this.txtWholesalePrice.CustomButton.Visible = false;
            this.txtWholesalePrice.Lines = new string[0];
            this.txtWholesalePrice.Location = new System.Drawing.Point(298, 228);
            this.txtWholesalePrice.MaxLength = 32767;
            this.txtWholesalePrice.Name = "txtWholesalePrice";
            this.txtWholesalePrice.PasswordChar = '\0';
            this.txtWholesalePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWholesalePrice.SelectedText = "";
            this.txtWholesalePrice.SelectionLength = 0;
            this.txtWholesalePrice.SelectionStart = 0;
            this.txtWholesalePrice.ShortcutsEnabled = true;
            this.txtWholesalePrice.Size = new System.Drawing.Size(118, 23);
            this.txtWholesalePrice.TabIndex = 12;
            this.txtWholesalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWholesalePrice.UseCustomBackColor = true;
            this.txtWholesalePrice.UseSelectable = true;
            this.txtWholesalePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWholesalePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtWholesalePrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWholesalePrice_KeyUp);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(166, 232);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(102, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Wholesale Price";
            // 
            // txtSpecialPrice
            // 
            this.txtSpecialPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSpecialPrice.CustomButton.Image = null;
            this.txtSpecialPrice.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtSpecialPrice.CustomButton.Name = "";
            this.txtSpecialPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSpecialPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSpecialPrice.CustomButton.TabIndex = 1;
            this.txtSpecialPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSpecialPrice.CustomButton.UseSelectable = true;
            this.txtSpecialPrice.CustomButton.Visible = false;
            this.txtSpecialPrice.Lines = new string[0];
            this.txtSpecialPrice.Location = new System.Drawing.Point(298, 269);
            this.txtSpecialPrice.MaxLength = 32767;
            this.txtSpecialPrice.Name = "txtSpecialPrice";
            this.txtSpecialPrice.PasswordChar = '\0';
            this.txtSpecialPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSpecialPrice.SelectedText = "";
            this.txtSpecialPrice.SelectionLength = 0;
            this.txtSpecialPrice.SelectionStart = 0;
            this.txtSpecialPrice.ShortcutsEnabled = true;
            this.txtSpecialPrice.Size = new System.Drawing.Size(118, 23);
            this.txtSpecialPrice.TabIndex = 14;
            this.txtSpecialPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSpecialPrice.UseCustomBackColor = true;
            this.txtSpecialPrice.UseSelectable = true;
            this.txtSpecialPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSpecialPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSpecialPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSpecialPrice_KeyUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(166, 273);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Special Price";
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtLastPrice.CustomButton.Image = null;
            this.txtLastPrice.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtLastPrice.CustomButton.Name = "";
            this.txtLastPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastPrice.CustomButton.TabIndex = 1;
            this.txtLastPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastPrice.CustomButton.UseSelectable = true;
            this.txtLastPrice.CustomButton.Visible = false;
            this.txtLastPrice.Lines = new string[0];
            this.txtLastPrice.Location = new System.Drawing.Point(298, 317);
            this.txtLastPrice.MaxLength = 32767;
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.PasswordChar = '\0';
            this.txtLastPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastPrice.SelectedText = "";
            this.txtLastPrice.SelectionLength = 0;
            this.txtLastPrice.SelectionStart = 0;
            this.txtLastPrice.ShortcutsEnabled = true;
            this.txtLastPrice.Size = new System.Drawing.Size(118, 23);
            this.txtLastPrice.TabIndex = 16;
            this.txtLastPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLastPrice.UseCustomBackColor = true;
            this.txtLastPrice.UseSelectable = true;
            this.txtLastPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLastPrice_KeyUp);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(166, 321);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(64, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Last Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(565, 179);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(129, 23);
            this.txtQuantity.TabIndex = 18;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.UseCustomBackColor = true;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel9.Location = new System.Drawing.Point(457, 179);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "Quantity";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDiscount.CustomButton.Image = null;
            this.txtDiscount.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtDiscount.CustomButton.Name = "";
            this.txtDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount.CustomButton.TabIndex = 1;
            this.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.CustomButton.UseSelectable = true;
            this.txtDiscount.CustomButton.Visible = false;
            this.txtDiscount.Lines = new string[0];
            this.txtDiscount.Location = new System.Drawing.Point(565, 226);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(129, 23);
            this.txtDiscount.TabIndex = 20;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.UseCustomBackColor = true;
            this.txtDiscount.UseSelectable = true;
            this.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(457, 226);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(58, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Discount";
            // 
            // txtPackSize
            // 
            this.txtPackSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtPackSize.CustomButton.Image = null;
            this.txtPackSize.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtPackSize.CustomButton.Name = "";
            this.txtPackSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPackSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPackSize.CustomButton.TabIndex = 1;
            this.txtPackSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPackSize.CustomButton.UseSelectable = true;
            this.txtPackSize.CustomButton.Visible = false;
            this.txtPackSize.Lines = new string[0];
            this.txtPackSize.Location = new System.Drawing.Point(565, 278);
            this.txtPackSize.MaxLength = 32767;
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.PasswordChar = '\0';
            this.txtPackSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPackSize.SelectedText = "";
            this.txtPackSize.SelectionLength = 0;
            this.txtPackSize.SelectionStart = 0;
            this.txtPackSize.ShortcutsEnabled = true;
            this.txtPackSize.Size = new System.Drawing.Size(129, 23);
            this.txtPackSize.TabIndex = 22;
            this.txtPackSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPackSize.UseCustomBackColor = true;
            this.txtPackSize.UseSelectable = true;
            this.txtPackSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPackSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPackSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPackSize_KeyUp);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(457, 278);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(62, 19);
            this.metroLabel11.TabIndex = 21;
            this.metroLabel11.Text = "Pack Size";
            // 
            // txtPackPrice
            // 
            this.txtPackPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtPackPrice.CustomButton.Image = null;
            this.txtPackPrice.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtPackPrice.CustomButton.Name = "";
            this.txtPackPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPackPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPackPrice.CustomButton.TabIndex = 1;
            this.txtPackPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPackPrice.CustomButton.UseSelectable = true;
            this.txtPackPrice.CustomButton.Visible = false;
            this.txtPackPrice.Lines = new string[0];
            this.txtPackPrice.Location = new System.Drawing.Point(298, 367);
            this.txtPackPrice.MaxLength = 32767;
            this.txtPackPrice.Name = "txtPackPrice";
            this.txtPackPrice.PasswordChar = '\0';
            this.txtPackPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPackPrice.SelectedText = "";
            this.txtPackPrice.SelectionLength = 0;
            this.txtPackPrice.SelectionStart = 0;
            this.txtPackPrice.ShortcutsEnabled = true;
            this.txtPackPrice.Size = new System.Drawing.Size(118, 23);
            this.txtPackPrice.TabIndex = 24;
            this.txtPackPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPackPrice.UseCustomBackColor = true;
            this.txtPackPrice.UseSelectable = true;
            this.txtPackPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPackPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPackPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPackPrice_KeyUp);
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(166, 371);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(68, 19);
            this.metroLabel12.TabIndex = 23;
            this.metroLabel12.Text = "Pack Price";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(771, 466);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 23);
            this.btnAddItem.TabIndex = 25;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseSelectable = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // listCategory
            // 
            this.listCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listCategory.FormattingEnabled = true;
            this.listCategory.Location = new System.Drawing.Point(953, 33);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(120, 121);
            this.listCategory.TabIndex = 26;
            // 
            // listSubCategory
            // 
            this.listSubCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listSubCategory.FormattingEnabled = true;
            this.listSubCategory.Location = new System.Drawing.Point(802, 46);
            this.listSubCategory.Name = "listSubCategory";
            this.listSubCategory.Size = new System.Drawing.Size(120, 108);
            this.listSubCategory.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(80, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "clear all";
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(EasyBookShop.models.category);
            // 
            // categoryListBox
            // 
            this.categoryListBox.DataSource = this.categoryBindingSource;
            this.categoryListBox.DisplayMember = "name";
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.Location = new System.Drawing.Point(842, 179);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(135, 82);
            this.categoryListBox.TabIndex = 28;
            this.categoryListBox.ValueMember = "categories_sub_categories";
            // 
            // sub_categoriesBindingSource
            // 
            this.sub_categoriesBindingSource.DataSource = typeof(EasyBookShop.models.sub_categories);
            // 
            // sub_categoriesListBox
            // 
            this.sub_categoriesListBox.DataSource = this.sub_categoriesBindingSource;
            this.sub_categoriesListBox.DisplayMember = "name";
            this.sub_categoriesListBox.FormattingEnabled = true;
            this.sub_categoriesListBox.Location = new System.Drawing.Point(842, 295);
            this.sub_categoriesListBox.Name = "sub_categoriesListBox";
            this.sub_categoriesListBox.Size = new System.Drawing.Size(135, 95);
            this.sub_categoriesListBox.TabIndex = 28;
            this.sub_categoriesListBox.ValueMember = "categories_sub_categories";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 587);
            this.Controls.Add(this.sub_categoriesListBox);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listSubCategory);
            this.Controls.Add(this.listCategory);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtPackPrice);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txtPackSize);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtLastPrice);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtSpecialPrice);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtWholesalePrice);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.metroLabel1);
            this.Name = "NewItem";
            this.Text = "Add New Item";
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtRetailPrice;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtWholesalePrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtSpecialPrice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtLastPrice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtPackSize;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtPackPrice;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton btnAddItem;
        private System.Windows.Forms.ListBox listCategory;
        private System.Windows.Forms.ListBox listSubCategory;
        private MetroFramework.Controls.MetroButton btnClear;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.BindingSource sub_categoriesBindingSource;
        private System.Windows.Forms.ListBox sub_categoriesListBox;
    }
}