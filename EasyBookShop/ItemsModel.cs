using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop
{
    class ItemsModel
    {
        int id;
        string barcode;
        string description;
        string category;
        string sub_category;
        decimal retail_price;
        decimal wholesale_price;
        decimal special_price;
        decimal last_price;
        int quantity;
        decimal discount;
        int pack_size;
        decimal pack_price;
        DateTime last_updated;
        bool deleted;        

    }
}
