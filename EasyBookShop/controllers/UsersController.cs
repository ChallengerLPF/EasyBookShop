using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBookShop.models;

namespace EasyBookShop.controllers
{
    class UsersController
    {

        public user find()
        {

            using (var db = new dbCon())
            {
                user u1 = db.users.First();

                return u1;

            }

        }

    }
}
