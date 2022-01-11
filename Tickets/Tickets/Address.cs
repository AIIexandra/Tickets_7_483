using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Address
    {
        int id;
        string town;
        string street;
        int house;
        string description;

        Tickets_7_483DataSet.AddressesRow addressesRow;
        Tickets_7_483DataSet.AddressesDataTable addressesTable;
        Tickets_7_483DataSetTableAdapters.AddressesTableAdapter addressesTableAdapter = new Tickets_7_483DataSetTableAdapters.AddressesTableAdapter();

        public Address(int id)
        {
            GetRow(id);

            this.id = id;
            this.town = addressesRow.Town;
            this.street = addressesRow.Street;
            this.house = addressesRow.House;
            this.description = addressesRow.Description;
        }

        public Address(string town, string street, int house, string description)
        {
            this.town = town;
            this.street = street;
            this.house = house;
            this.description = description;

            this.id = (int)addressesTableAdapter.InsertQuery(town, street, house, description);
            //GetRow(id);
        }

        public Address(string town, string street, int house)
        {
            this.town = town;
            this.street = street;
            this.house = house;

            this.id = (int)addressesTableAdapter.InsertQuery(town, street, house, "");
            //GetRow(id);
        }

        public int GetID() {  return this.id; }

        public string GetTown() { return this.town; }

        public string GetStreet() { return this.street; }

        public int GetHouse() { return this.house; }

        public string GetDescription() { return this.description; }

        private void GetRow(int id)
        {
            addressesTable = addressesTableAdapter.GetData();
            addressesRow = addressesTable.Where(x => x.ID == id).First();
        }
    }
}
