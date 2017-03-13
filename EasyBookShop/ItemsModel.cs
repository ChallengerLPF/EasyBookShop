using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop
{
    class ItemsModel
    {
        int id { get; set; }
        string barcode { get; set; }
        string description { get; set; }
        string category { get; set; }
        string sub_category { get; set; }
        decimal retail_price { get; set; }
        decimal wholesale_price { get; set; }
        decimal special_price { get; set; }
        decimal last_price { get; set; }
        int quantity { get; set; }
        decimal discount { get; set; }
        int pack_size { get; set; }
        decimal pack_price { get; set; }
        DateTime last_updated { get; set; }
        bool deleted { get; set; }

    }
}
