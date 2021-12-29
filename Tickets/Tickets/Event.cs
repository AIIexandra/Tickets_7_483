using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Event
    {
        int id;
        string title;
        int idAddress;
        DateTime date;
        TimeSpan time;
        int ageLimit;
        int idVendor;
        int valueTickets;
        bool cancel;
        int idCategory;

        public Event(int id)
        {
            //получение
        }

        public Event(string title, int idAddress, DateTime date, TimeSpan time, int ageLimit, int idVendor, int valueTickets, bool cancel, int idCategory)
        {
            this.title = title;
            this.idAddress = idAddress;
            this.date = date;
            this.time = time;
            this.ageLimit = ageLimit;
            this.idVendor = idVendor;
            this.valueTickets = valueTickets;
            this.cancel = cancel;
            this.idCategory = idCategory;

            Tickets_7_483DataSetTableAdapters.EventsTableAdapter eventsTableAdapter = new Tickets_7_483DataSetTableAdapters.EventsTableAdapter();
            eventsTableAdapter.Insert(title, idAddress, date, time, ageLimit, idVendor, valueTickets, cancel, idCategory);
        }

        public int GetID() { return this.id; }

        public string GetTitle() { return this.title; }

        public int GetIDAddress() { return this.idAddress; }

        public DateTime GetDate() { return this.date; }

        public TimeSpan GetTime() { return this.time; }

        public int GetAgeLimit() { return this.ageLimit; }

        public int GetIDVendor() { return this.idVendor; }

        public int GetValueTickets() { return this.valueTickets; }

        public bool GetCancel() { return this.cancel; }

        public int GetIDCategory() { return this.idCategory; }



        public void SetTitle(string title) { this.title = title; }

        public void SetIDAddress(int idAddress) { this.idAddress = idAddress; }

        public void SetDate(DateTime date) { this.date = date; }

        public void SetTime(TimeSpan time) { this.time = time; }

        public void SetAgeLimit(int ageLimit) { this.ageLimit = ageLimit; }

        public void SetIDVendor(int idVendor) { this.idVendor = idVendor; }

        public void SettValueTickets(int valueTickets) { this.valueTickets = valueTickets; }

        public void SetCancel(bool cancel) { this.cancel = cancel; }

        public void SetIDCategory(int idCategory) { this.idCategory = idCategory; }
    }
}
