using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class UserDao
    {
        private readonly RestaurantManagementDBContext db = null;

        public UserDao()
        {
            db = new RestaurantManagementDBContext();
        }

        public int Login(string username, string password)
        {

        }
    }
}
