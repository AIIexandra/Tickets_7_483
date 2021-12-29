using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class User
    {
        int id;
        string login;
        string password;
        int idRole;

        public User(int id)
        {
            //получение
        }

        public User(string login, string password, int idRole)
        {
            this.login = login;
            this.password = password;
            this.idRole = idRole;

            Tickets_7_483DataSetTableAdapters.UsersTableAdapter usersTableAdapter = new Tickets_7_483DataSetTableAdapters.UsersTableAdapter();
            usersTableAdapter.Insert(login, password, idRole);
        }

        public int GetID()
        {
            return this.id;
        }

        public string GetLogin()
        {
            return this.login;
        }

        public void SetLogin(string login)
        {
            this.login = login;

            //Tickets_7_483DataSetTableAdapters.UsersTableAdapter usersTableAdapter = new Tickets_7_483DataSetTableAdapters.UsersTableAdapter();
            //usersTableAdapter.Update()
        }

        public string GetPassword()
        {
            return this.password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public int GetIDRole()
        {
            return idRole;
        }

        //public string GetRole()
        //{
        //    return "";
        //}
    }
}
