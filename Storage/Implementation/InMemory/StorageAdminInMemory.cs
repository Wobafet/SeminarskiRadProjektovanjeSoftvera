using Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.InMemory
{
   public  class StorageAdminInMemory
    {
        public List<Admin> Administrators{ get; set; }

       
        public StorageAdminInMemory()
        {
            Administrators = new List<Admin>
            {
                new Admin
                {
                    Email="admin1",
                    Password="123"
                },
                new Admin
                {
                    Email="admin2",
                    Password="123"
                },new Admin
                {
                    Email="admin3",
                    Password="123"
                }

            };
        }
    }
}
