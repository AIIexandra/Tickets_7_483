using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Customer
    {
        int id;
        string email;
        string name;
        string surname;

        Tickets_7_483DataSet.CustomersRow customersRow;
        Tickets_7_483DataSet.CustomersDataTable customersTable;
        Tickets_7_483DataSetTableAdapters.CustomersTableAdapter customersTableAdapter = new Tickets_7_483DataSetTableAdapters.CustomersTableAdapter();

        public Customer(int id)
        {
            GetRow(id);

            this.id = id;
            this.email = customersRow.Email;
            this.name = customersRow.Name;
            this.surname = customersRow.Surname;
        }

        public Customer(int id, string email, string name, string surname)
        {
            this.id = id;
            this.email = email;
            this.name = name;
            this.surname = surname;

            customersTableAdapter.Insert(id, email, name, surname);
            GetRow(id);
        }

        public int GetID() { return this.id; }

        public string GetEmail() { return this.email; }

        public string GetName() { return this.name; }

        public string GetSurname() { return this.surname; }


        public void SetEmail(string email) { this.email = email; Update();  }

        public void SetName(string name) { this.name = name; Update(); }

        public void SetSurname(string surname) { this.surname = surname; Update(); }


        private void Update()
        {
            customersRow.Email = this.email;
            customersRow.Name = this.name;
            customersRow.Surname = this.surname;
            customersTableAdapter.Update(customersRow);
        }

        private void GetRow(int id)
        {
            customersTable = customersTableAdapter.GetData();
            customersRow = customersTable.Where(x => x.ID == id).First();
        }
    }
}
