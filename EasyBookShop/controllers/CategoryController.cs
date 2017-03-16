﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBookShop.models;

namespace EasyBookShop.controllers
{
    class CategoryController
    {
        public List<category> findAll()
        {
            using (var db = new dbCon())
            {
                List<category> allcats =  db.categories.ToList();
                return allcats;
            }
        }
    }
}