using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBookShop.controllers;
using EasyBookShop.models;
using EasyBookShop.utilities;
using MetroFramework.Controls;

namespace EasyBookShop.views
{
    public partial class UpdateItem : MetroFramework.Forms.MetroForm
    {
        private Color errorColor;
        private item _item;
        public item item 
        { 
        get { return _item; } 
        set {
                var itemCtrl = new ItemController();
                _item = itemCtrl.findByBarcode(value.barcode);                

                fillTheFields(); 
        }
        }
        public UpdateItem()
        {
            InitializeComponent();
            errorColor = Color.FromArgb(255, 205, 205);
            btnUpdateItem.Enabled = false;

            loadCategories();
            loadSubCategories();
        }

       
        private void fillTheFields()
        {
            txtBarcode.Text = item.barcode;

            txtRetailPrice.Text = item.retail_price.ToString();
            txtWholesalePrice.Text = item.wholesale_price.ToString();
            txtSpecialPrice.Text = item.special_price.ToString();
            txtLastPrice.Text = item.last_price.ToString();
            txtPackPrice.Text = item.pack_price.ToString();

            txtQuantity.Text = item.quantity.ToString();
            txtDiscount.Text = item.discount.ToString();
            txtPackSize.Text = item.pack_size.ToString();
            txtDescription.Text = item.description;

            CategoryController catCtrl = new CategoryController();
            category itemCat =  catCtrl.find(item.category.GetValueOrDefault());

            //MessageBox.Show(itemCat.name);
            listCategory.SelectedItem = itemCat;
            //MessageBox.Show(listCategory.SelectedItem);
            SubCategoryController subCatCtrl = new SubCategoryController();
            sub_categories itemSubCat = subCatCtrl.find(item.sub_category.GetValueOrDefault());
            listSubCategory.SelectedItem = itemSubCat.name;

        }

        private void loadCategories()
        {
            CategoryController catCtrl = new CategoryController();
            //listCategory.Items.Insert = catCtrl.findAll();
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = catCtrl.findAll();

            listCategory.DataSource = bindingSource1.DataSource;

            listCategory.DisplayMember = "Name";
            listCategory.ValueMember = "Name";
        }

        private void loadSubCategories()
        {
            SubCategoryController subcatCtrl = new SubCategoryController();
            //listCategory.Items.Insert = catCtrl.findAll();
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = subcatCtrl.findAll();

            listSubCategory.DataSource = bindingSource1.DataSource;

            listSubCategory.DisplayMember = "Name";
            listSubCategory.ValueMember = "id";
        }

        //-------------
        private void allValidated()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(MetroTextBox))
                {
                    var a = (MetroTextBox)item;
                    if (a.BackColor == errorColor)
                    {
                        btnUpdateItem.Enabled = false;
                        return;
                    }
                }
            }
            btnUpdateItem.Enabled = true;
        }


        private void txtBarcode_Leave(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (DataTypeValidator.isEmpty(uiComp.Text))
            {

                uiComp.BackColor = errorColor;

                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();
            }

        }

        private void txtRetailPrice_Leave(object sender, KeyEventArgs e)
        {

            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;

                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();

            }

        }

        private void txtWholesalePrice_Leave(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;

                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtSpecialPrice_Leave(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtLastPrice_Leave(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();

            }
        }

        private void txtQuantity_Leave(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.intTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;

                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {

                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtDiscount_Leave(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;

                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {

                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtPackSize_Leave(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.intTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;

                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {

                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtPackPrice_Leave(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;

                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();

            }
        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
