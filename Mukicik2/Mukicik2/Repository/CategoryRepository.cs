using Mukicik2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik2.Repository
{
    public class CategoryRepository
    {
        Database1Entities db = SingletonDB.GetInstance();
        public List<Category> GetAllCategories()
        {
            return (from c in db.Categories select c).ToList();
        }
    }
}