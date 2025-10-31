using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class TableDao
    {
        private readonly RestaurantManagementDBContext db;
        public TableDao()
        {
            db = new RestaurantManagementDBContext();
        }

        public List<TABLES> getListTable()
        {
            return db.TABLES.ToList();
        }
    }
}
