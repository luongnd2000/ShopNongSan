using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HocWeb2.Models
{
    public class CategoryModel
    {
        public QuanLyShop_Context context = null;
        public CategoryModel()
        {
            context = new QuanLyShop_Context();
        }
        public List<Category> ListAll()
        {
            List<Category> list =context.Categories.ToList();
            return list;
        }
    }
}