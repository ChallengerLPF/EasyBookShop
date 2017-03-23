using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.com.easy.model
{
    class Customer
    {
        private int id;
        private String nic;
        private String phone_no;
        private String fname;
        private String gender;
        private String level;
        private decimal pendings;

        public decimal Pendings
        {
            get { return pendings; }
            set { pendings = value; }
        }

        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        

        public String Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public String Phone_no
        {
            get { return phone_no; }
            set { phone_no = value; }
        }
        
        public String Nic
        {
            get { return nic; }
            set { nic = value; }
        }

        public String Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
