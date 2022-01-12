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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (radioButtonCustomer.Checked)
            {
                string log = textBoxLog.Text;
                string pas = textBoxPas.Text;
                string name = textBoxName.Text;
                string surname = textBoxSurname.Text;
                string email = textBoxEmail.Text;

                User user = new User(log, pas, 3);
                Customer customer = new Customer(user.GetID(), email, name, surname);
            }

            else
            {
                string log = textBoxLog.Text;
                string pas = textBoxPas.Text;
                string nameOrg = textBoxName.Text;

                User user = new User(log, pas, 2);
                Vendor vendor = new Vendor(user.GetID(), nameOrg);
            }
        }

        private void radioButtonCustomer_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = "Имя";
            textBoxSurname.Visible = true;
            labelSurname.Visible = true;
            textBoxEmail.Visible = true;
            labelEmail.Visible = true;
        }

        private void radioButtonVendor_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = "Название организации";
            textBoxSurname.Visible = false;
            labelSurname.Visible = false;
            textBoxEmail.Visible = false;
            labelEmail.Visible = false;
        }
    }
}
