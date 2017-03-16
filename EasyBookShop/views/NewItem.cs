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

namespace EasyBookShop.views
{
    public partial class NewItem : MetroFramework.Forms.MetroForm
    {
        public NewItem()
        {
            InitializeComponent();
            loadCategories();
            loadSubCategories();
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string addItemProblem1 = "Do you want to update the existing item ?"; //when barcode is already available in the items table

            ItemController itemCtrl = new ItemController();

            category c = (category)listCategory.SelectedItem;
            sub_categories sc = (sub_categories)listSubCategory.SelectedItem;
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
                pack_price = Convert.ToInt32(txtPackPrice.Text)


            };

            //Console.WriteLine(newItem.barcode);

            try {
               
                itemCtrl.create(newItem);
            }
            catch(NotificationException ne) {
            
                if(ne.alertType==NotificationException.AlertType.UNSUCCESS)
                {
                    DialogResult answer =  MessageBox.Show(ne.message+"."+addItemProblem1, "data error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(answer == DialogResult.Yes)
                    {
                        
                    }
                }
            }
            



        }
    }
}
