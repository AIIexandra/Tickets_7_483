using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Ticket
    {
        int id;
        int idEvent;
        double price;
        DateTime datePurchase;
        TimeSpan timePurchase;
        int idCustomer;
        bool returned;

        Tickets_7_483DataSet.TicketsRow ticketsRow;
        Tickets_7_483DataSet.TicketsDataTable ticketsTable;
        Tickets_7_483DataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter = new Tickets_7_483DataSetTableAdapters.TicketsTableAdapter();

        public Ticket(int id)
        {
            GetRow(id);

            this.id = id;
            this.price = ticketsRow.Price;
            this.datePurchase = ticketsRow.DatePurchase;
            this.timePurchase = ticketsRow.TimePurchase;
            this.idCustomer = ticketsRow.IDCustomer;
            this.returned = ticketsRow.Returned;
        }

        public Ticket(int idEvent, double price, DateTime datePurchase, TimeSpan timePurchase, int idCustomer, bool returned)
        {
            this.idEvent = idEvent;
            this.price = price;
            this.datePurchase = datePurchase;
            this.timePurchase = timePurchase;
            this.idCustomer = idCustomer;
            this.returned = returned;

            this.id = (int)ticketsTableAdapter.InsertQuery(idEvent, price, datePurchase.ToString(), timePurchase.ToString(), idCustomer, returned);
        }

        public int GetID() { return this.id; }

        public int GetIDEvent() { return this.idEvent; }

        public double GetPrice() { return this.price; }

        public DateTime GetDatePurchase() { return this.datePurchase; }

        public TimeSpan GetTimePurchase() { return this.timePurchase; }

        public int GetIDCustomer() { return this.idCustomer; }

        public bool GetReturned() { return this.returned; }


        private void GetRow(int id)
        {
            ticketsTable = ticketsTableAdapter.GetData();
            ticketsRow = ticketsTable.Where(x => x.ID == id).First();
        }
    }
}
