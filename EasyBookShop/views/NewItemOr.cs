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
    public partial class NewItemOr : MetroFramework.Forms.MetroForm
    {
        private UpdateItem updateItemUi;
        private Color errorColor;

        public NewItemOr()
        {
            InitializeComponent();            
            errorColor = Color.FromArgb(255, 205, 205);
            btnAddItem.Enabled = false;
            loadCategoriesNew();
            loadSubCategoriesNew();
        }

        private void loadCategoriesNew()
        {
            CategoryController catCtrl = new CategoryController();
            this.categoryBindingSource.DataSource = catCtrl.findAll();
            
        }

        private void loadSubCategoriesNew()
        {
            SubCategoryController subcatCtrl = new SubCategoryController();
            this.sub_categoriesBindingSource.DataSource = subcatCtrl.findAll();
        }

        private void loadCategories()
        {

            
            CategoryController catCtrl = new CategoryController();
            //listCategory.Items.Insert = catCtrl.findAll();
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = catCtrl.findAll();

            this.categoryBindingSource.DataSource = catCtrl.findAll();

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

        private void btnAddItem_Click(object sender,EventArgs e)
        {
        
            string addItemProblem1 = "Do you want to update the existing item ?"; //when barcode is already available in the items table

            ItemController itemCtrl = new ItemController();

            category c = (category)categoryListBox.SelectedItem;
            sub_categories sc = (sub_categories)sub_categoriesListBox.SelectedItem;
            item newItem = new item()
            {
                barcode = txtBarcode.Text,
                description = txtDescription.Text,
                category = c.id,
                sub_category = (int)sc.id,
                retail_price = Convert.ToDecimal(txtRetailPrice.Text),
                wholesale_price = Convert.ToDecimal(txtWholesalePrice.Text),
                special_price = Convert.ToDecimal(txtSpecialPrice.Text),
                last_price = Convert.ToDecimal(txtLastPrice.Text),
                quantity = Convert.ToInt32(txtQuantity.Text),
                discount = Convert.ToDecimal(txtDiscount.Text),
                pack_size = Convert.ToInt32(txtPackSize.Text),
                pack_price = Convert.ToDecimal(txtPackPrice.Text)

            };

            try {               
                itemCtrl.create(newItem);
                MessageBox.Show("item added");
            }
            catch(NotificationException ne) {
                //barcode already found
                if(ne.alertType==NotificationException.AlertType.UNSUCCESS)
                {
                    DialogResult answer =  MessageBox.Show(ne.message+"."+addItemProblem1, "data error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    
                    if(answer == DialogResult.Yes)
                    {
                        //MessageBox.Show(newItem.barcode);
                        if(updateItemUi==null ||  updateItemUi.GetType() != typeof(UpdateItem) || updateItemUi.IsDisposed) {
                            //MessageBox.Show("sas");
                            updateItemUi = new UpdateItem();
                            updateItemUi.item = newItem;
                            updateItemUi.Show();
                            
                        }else {
                            //MessageBox.Show("Type"+updateItemUi.IsDisposed.ToString());
                            updateItemUi.item = newItem;
                            updateItemUi.Show();
                        }
                            
                    }
                    else 
                    {
                        
                        txtBarcode.Focus();
                        txtBarcode.BackColor = errorColor;
                    }
                }
            }           
            
        }

        private void allValidated()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(MetroTextBox) )
                {
                    var a = (MetroTextBox)item;
                    if( a.BackColor == errorColor || (DataTypeValidator.isEmpty(a.Text) && a.Name!= "txtDescription")  )
                    {
                        btnAddItem.Enabled = false;
                        return;
                    }
                }
            }
            btnAddItem.Enabled = true;
        }


        private void reset()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(MetroTextBox))
                {
                    var a = (MetroTextBox)item;
                    a.Text = "";
                }
            }
            btnAddItem.Enabled = true;
        }


        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (DataTypeValidator.isEmpty(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();

            }
            
        }

        private void txtRetailPrice_KeyUp(object sender, KeyEventArgs e)
        {

            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();

            }

        }

        private void txtWholesalePrice_KeyUp(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtSpecialPrice_KeyUp(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtLastPrice_KeyUp(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();

            }
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.intTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                
                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                
                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtPackSize_KeyUp(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.intTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                
                uiComp.BackColor = Color.Empty;
                allValidated();
            }
        }

        private void txtPackPrice_KeyUp(object sender, KeyEventArgs e)
        {
            var uiComp = (MetroTextBox)sender;
            if (!DataTypeValidator.decimalTypeValidated(uiComp.Text))
            {

                uiComp.BackColor = errorColor;
                btnAddItem.Enabled = false;
                //MessageBox.Show("Last Price Not Valid");
            }
            else
            {
                uiComp.BackColor = Color.Empty;
                allValidated();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
            btnAddItem.Enabled = false;
        }
    }
}
