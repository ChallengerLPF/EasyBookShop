﻿using System;
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
using EasyBookShop.views;

namespace EasyBookShop
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new Retail_Invoice().Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new NewItemOr().Show();
        }

        dbCon _context;
        private void Form1_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            _context = new dbCon();

            // Call the Load method to get the data for the given DbSet 
            // from the database. 
            // The data is materialized as entities. The entities are managed by 
            // the DbContext instance. 
            //_context.sub_categories.;

            // Bind the categoryBindingSource.DataSource to 
            // all the Unchanged, Modified and Added Category objects that 
            // are currently tracked by the DbContext.
            // Note that we need to call ToBindingList() on the 
            // ObservableCollection<TEntity> returned by
            // the DbSet.Local property to get the BindingList<T>
            // in order to facilitate two-way binding in WinForms.
            //this.sub_categoriesBindingSource.DataSource =
            //    _context.categories.ToList();

            SubCategoryController subcatCtrl = new SubCategoryController();
            this.sub_categoriesBindingSource.DataSource = subcatCtrl.findAll();

            //MessageBox.Show(_context.categories.ToList().Count.ToString());
        }

        private void sub_categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            // Currently, the Entity Framework doesn’t mark the entities 
            // that are removed from a navigation property (in our example the Products)
            // as deleted in the context. 
            // The following code uses LINQ to Objects against the Local collection 
            // to find all products and marks any that do not have
            // a Category reference as deleted. 
            // The ToList call is required because otherwise 
            // the collection will be modified 
            // by the Remove call while it is being enumerated. 
            // In most other situations you can do LINQ to Objects directly 
            // against the Local property without using ToList first.
            foreach (var product in _context.sub_categories.Local.ToList())
            {
                if (product.categories_sub_categories == null)
                {
                    _context.sub_categories.Remove(product);
                }
            }

            // Save the changes to the database.
            this._context.SaveChanges();

            // Refresh the controls to show the values         
            // that were generated by the database.
            this.sub_categoriesDataGridView.Refresh();
            //this.productsDataGridView.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();

                // Currently, the Entity Framework doesn’t mark the entities 
                // that are removed from a navigation property (in our example the Products)
                // as deleted in the context. 
                // The following code uses LINQ to Objects against the Local collection 
                // to find all products and marks any that do not have
                // a Category reference as deleted. 
                // The ToList call is required because otherwise 
                // the collection will be modified 
                // by the Remove call while it is being enumerated. 
                // In most other situations you can do LINQ to Objects directly 
                // against the Local property without using ToList first.
                foreach (var product in _context.sub_categories.Local.ToList())
                {
                    if (product.categories_sub_categories == null)
                    {
                        _context.sub_categories.Remove(product);
                    }
                }

                // Save the changes to the database.
                this._context.SaveChanges();

                // Refresh the controls to show the values         
                // that were generated by the database.
                this.sub_categoriesDataGridView.Refresh();
                //this.productsDataGridView.Refresh();
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}