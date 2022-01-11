using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Vendor
    {
        int id;
        string nameOrg;

        Tickets_7_483DataSet.VendorsRow vendorsRow;
        Tickets_7_483DataSet.VendorsDataTable vendorsTable;
        Tickets_7_483DataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter = new Tickets_7_483DataSetTableAdapters.VendorsTableAdapter();

        public Vendor(int id)
        {
            GetRow(id);

            this.id = id;
            this.nameOrg = vendorsRow.NameOrg;
        }

        public Vendor(int id, string nameOrg)
        {
            this.id = id;
            this.nameOrg = nameOrg;

            vendorsTableAdapter.Insert(id, nameOrg);
            GetRow(id);
        }

        public int GeiID() { return this.id; }

        public string GetNameOrg() { return this.nameOrg; }

        public void SetNameOrg(string nameOrg) { this.nameOrg = nameOrg; Update(); }


        private void Update()
        {
            vendorsRow.NameOrg = this.nameOrg;
            vendorsTableAdapter.Update(vendorsRow);
        }

        private void GetRow(int id)
        {
            vendorsTable = vendorsTableAdapter.GetData();
            vendorsRow = vendorsTable.Where(x => x.ID == id).First();
        }
    }
}
