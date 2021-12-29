using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Category
    {
        int id;
        string category;

        public Category(string category)
        {
            this.category = category;

            Tickets_7_483DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter = new Tickets_7_483DataSetTableAdapters.CategoriesTableAdapter();
            categoriesTableAdapter.Insert(category);
        }

        public int GetID()
        {
            return this.id;
        }

        public string GetCategory()
        {
            return category;
        }
    }
}
