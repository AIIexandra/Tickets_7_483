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

        Tickets_7_483DataSet.UsersRow usersRow;
        Tickets_7_483DataSet.UsersDataTable usersTable;
        Tickets_7_483DataSetTableAdapters.UsersTableAdapter usersTableAdapter = new Tickets_7_483DataSetTableAdapters.UsersTableAdapter();

        public User(int id)
        {
            GetRow(id);

            this.id = id;
            this.login = usersRow.Login;
            this.password = usersRow.Password;
            this.idRole = usersRow.IDRole;
        }

        public User(string login, string password, int idRole)
        {
            this.login = login;
            this.password = password;
            this.idRole = idRole;

            this.id = (int)usersTableAdapter.InsertQuery(login, password, idRole);
            GetRow(this.id);
        }

        public int GetID() { return this.id; }

        public string GetLogin() { return this.login; }

        public string GetPassword() { return this.password; }

        public int GetIDRole() { return idRole; }


        public void SetLogin(string login) { this.login = login; Update(); }

        public void SetPassword(string password) { this.password = password; Update(); }


        private void Update()
        {
            usersRow.Login = this.login;
            usersRow.Password = this.password;
            usersTableAdapter.Update(usersRow);
        }

        private void GetRow(int id)
        {
            usersTable = usersTableAdapter.GetData();
            usersRow = usersTable.Where(x => x.ID == id).First();
        }
    }
}
