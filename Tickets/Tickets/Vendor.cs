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

        public Vendor(int id)
        {
            //получение
        }

        public Vendor(int id, string nameOrg)
        {
            this.id = id;
            this.nameOrg = nameOrg;

            Tickets_7_483DataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter = new Tickets_7_483DataSetTableAdapters.VendorsTableAdapter();
            vendorsTableAdapter.Insert(id, nameOrg);
        }

        public int GeiID()
        {
            return this.id;
        }

        public string GetNameOrg()
        {
            return this.nameOrg;
        }

        public void SetNameOrg(string nameOrg)
        {
            this.nameOrg = nameOrg;
        }
    }
}
