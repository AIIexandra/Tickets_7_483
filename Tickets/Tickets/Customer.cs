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

        public Customer(int id)
        {
            //получение
        }

        public Customer(int id, string email, string name, string surname)
        {
            this.id = id;
            this.email = email;
            this.name = name;
            this.surname = surname;

            Tickets_7_483DataSetTableAdapters.CustomersTableAdapter customersTableAdapter = new Tickets_7_483DataSetTableAdapters.CustomersTableAdapter();
            customersTableAdapter.Insert(id, email, name, surname);
        }

        public int GetID()
        {
            return this.id;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
    }
}
