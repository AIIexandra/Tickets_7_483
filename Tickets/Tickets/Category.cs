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

        Tickets_7_483DataSet.CategoriesRow categoriesRow;
        Tickets_7_483DataSet.CategoriesDataTable categoriesTable;
        Tickets_7_483DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter = new Tickets_7_483DataSetTableAdapters.CategoriesTableAdapter();

        public Category(int id)
        {
            GetRow(id);

            this.id = id;
            this.category = categoriesRow.Category;
        }

        public Category(string category)
        {
            this.category = category;

            this.id = (int)categoriesTableAdapter.InsertQuery(category);
        }

        public int GetID() { return this.id; }

        public string GetCategory() { return category; }

        private void GetRow(int id)
        {
            categoriesTable = categoriesTableAdapter.GetData();
            categoriesRow = categoriesTable.Where(x => x.ID == id).First();
        }
    }
}
