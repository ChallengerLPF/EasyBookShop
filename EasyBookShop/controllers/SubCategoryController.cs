using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBookShop.models;

namespace EasyBookShop.controllers
{
    class SubCategoryController
    {
        public List<sub_categories> findAll()
        {
            using (var db = new dbCon())
            {
                List<sub_categories> allsubcats =  db.sub_categories.ToList();
                return allsubcats;
            }
        }
    }
}
