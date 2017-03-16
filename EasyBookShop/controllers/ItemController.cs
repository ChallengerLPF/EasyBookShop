using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBookShop.models;
using EasyBookShop.utilities;

namespace EasyBookShop.controllers
{
    public class ItemController
    {

        public item find(int id)
        {

            using (var db = new dbCon())
            {

                item item = db.items.Find(id);

                return item;

            }

        }

        public item create(item newItem)
        {                                   

            using (var db = new dbCon())
            {

                //before adding new item need to check whether barcode is already available
                MessageBox.Show(newItem.barcode);
                var itm= db.items.SingleOrDefault(i => i.barcode == newItem.barcode);
                if (itm!=null)
                {
                    MessageBox.Show(itm.GetType().ToString());
                    throw new NotificationException("barcode already found", NotificationException.AlertType.UNSUCCESS); 
                }

                newItem = db.items.Add(newItem);
                db.SaveChanges();

                return newItem;
            }
        }

        public item update(item updatedItem)
        {
            using (var db = new dbCon())
            {
                try
                {
                    var book = db.items.Single(b => b.barcode == updatedItem.barcode);
                    updatedItem.id = book.id;
                    db.Entry(book).CurrentValues.SetValues(updatedItem);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //barcode not found = item not found
                    throw;
                }
                
               
            }

            return null;
        }
    }
}
