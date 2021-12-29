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
        int price;
        DateTime datePurchase;
        TimeSpan timePurchase;
        int idCustomer;
        bool returned;

        public Ticket(int id)
        {
            //получение
        }

        public Ticket(int idEvent, int price, DateTime datePurchase, TimeSpan timePurchase, int idCustomer, bool returned)
        {
            this.idEvent = idEvent;
            this.price = price;
            this.datePurchase = datePurchase;
            this.timePurchase = timePurchase;
            this.idCustomer = idCustomer;
            this.returned = returned;

            Tickets_7_483DataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter = new Tickets_7_483DataSetTableAdapters.TicketsTableAdapter();
            ticketsTableAdapter.Insert(idEvent, price, datePurchase, timePurchase, idCustomer, returned);
        }

        public int GetID() { return this.id; }

        public int GetIDEvent() { return this.idEvent; }

        public int GetPrice() { return this.price; }

        public DateTime GetDatePurchase() { return this.datePurchase; }

        public TimeSpan GetTimePurchase() { return this.timePurchase; }

        public int GetIDCustomer() { return this.idCustomer; }

        public bool GetReturned() { return this.returned; }

    }
}
