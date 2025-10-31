using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class CategoryDao
    {
        private readonly RestaurantManagementDBContext db;

        public CategoryDao()
        {
            db = new RestaurantManagementDBContext();
        }

        public List<CATEGORIES> getAllCategory()
        {
            return db.CATEGORIES.Include("MENUITEMS").ToList();
        }
    }
}
