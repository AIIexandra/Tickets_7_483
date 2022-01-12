using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        int idUser;
        int idRole;

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            string log = textBoxLog.Text;
            string pas = textBoxPas.Text;

            Tickets_7_483DataSetTableAdapters.UsersTableAdapter usersTableAdapter = new Tickets_7_483DataSetTableAdapters.UsersTableAdapter();
            Tickets_7_483DataSet.UsersDataTable usersTable = usersTableAdapter.GetData();
            var filter = usersTable.Where(x => x.Login == log && x.Password == pas);
            if (filter.Count() == 0)
            {
                MessageBox.Show("Такой пользователь не зарегистрирован");
            }
            else
            {
                idUser = filter.ElementAt(0).ID;
                idRole = filter.ElementAt(0).IDRole;
            }

            switch (idRole)
            {
                case 1: MessageBox.Show("Администратор"); break;
                case 2: MessageBox.Show("Продавец"); break;
                case 3: MessageBox.Show("Покупатель"); break;
            }
        }
    }
}
