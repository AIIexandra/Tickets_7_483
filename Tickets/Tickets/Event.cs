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

        Tickets_7_483DataSet.EventsRow eventsRow;
        Tickets_7_483DataSet.EventsDataTable eventsTable;
        Tickets_7_483DataSetTableAdapters.EventsTableAdapter eventsTableAdapter = new Tickets_7_483DataSetTableAdapters.EventsTableAdapter();

        public Event(int id)  //получение мероприятия по id
        {
            GetRow(id);

            this.title = eventsRow.Title;
            this.idAddress = eventsRow.IDAddress;
            this.date = eventsRow.Date;
            this.time = eventsRow.Time;
            this.ageLimit = eventsRow.AgeLimit;
            this.idVendor = eventsRow.IDVendor;
            this.valueTickets = eventsRow.ValueTickets;
            this.cancel = eventsRow.Cancel;
            this.idCategory = eventsRow.IDCategory;
        }

        public Event(string title, int idAddress, DateTime date, TimeSpan time, int ageLimit, int idVendor, int valueTickets, bool cancel, int idCategory) //добавление в таблицу нового мероприятия
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

            this.id = (int)eventsTableAdapter.InsertQuery(title, idAddress, date.ToString(), time.ToString(), ageLimit, idVendor, valueTickets, cancel, idCategory);
            GetRow(id);
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



        public void SetTitle(string title) { this.title = title; Update(); }

        public void SetIDAddress(int idAddress) { this.idAddress = idAddress; Update(); }

        public void SetDate(DateTime date) { this.date = date; Update(); }

        public void SetTime(TimeSpan time) { this.time = time; Update(); }

        public void SetAgeLimit(int ageLimit) { this.ageLimit = ageLimit; Update(); }

        public void SetIDVendor(int idVendor) { this.idVendor = idVendor; Update(); }

        public void SettValueTickets(int valueTickets) { this.valueTickets = valueTickets; Update(); }

        public void SetCancel(bool cancel) { this.cancel = cancel; Update(); }

        public void SetIDCategory(int idCategory) { this.idCategory = idCategory; Update(); }


        private void Update()
        {
            eventsRow.Title = this.title;
            eventsRow.IDAddress = this.idAddress;
            eventsRow.Date = this.date;
            eventsRow.Time = this.time;
            eventsRow.AgeLimit = this.ageLimit;
            eventsRow.IDVendor = this.idVendor;
            eventsRow.ValueTickets = this.valueTickets;
            eventsRow.Cancel = this.cancel;
            eventsRow.IDCategory = this.idCategory;
            eventsTableAdapter.Update(eventsRow);
        }

        private void GetRow(int id)
        {
            eventsTable = eventsTableAdapter.GetData();
            eventsRow = eventsTable.Where(x => x.ID == id).First();
        }
    }
}
