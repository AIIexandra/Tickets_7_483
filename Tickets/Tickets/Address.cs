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

        public Address(int id)
        {
            //получение
        }

        public Address(string town, string street, int house, string description)
        {
            this.town = town;
            this.street = street;
            this.house = house;
            this.description = description;

            Tickets_7_483DataSetTableAdapters.AddressesTableAdapter addressesTableAdapter = new Tickets_7_483DataSetTableAdapters.AddressesTableAdapter();
            addressesTableAdapter.Insert(town, street, house, description);
        }

        public Address(string town, string street, int house)
        {
            this.town = town;
            this.street = street;
            this.house = house;

            Tickets_7_483DataSetTableAdapters.AddressesTableAdapter addressesTableAdapter = new Tickets_7_483DataSetTableAdapters.AddressesTableAdapter();
            addressesTableAdapter.Insert(town, street, house, "");
        }

        public int GetID()
        {
            return this.id;
        }

        public string GetTown()
        {
            return this.town;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public int GetHouse()
        {
            return this.house;
        }

        public string GetDescription()
        {
            return this.description;
        }
    }
}
