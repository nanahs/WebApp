using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public int LocationId { get; set; }
        public int DescriptionId { get; set; }
        public int CategoryId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int EventTypeId { get; set; }
    }

    public class WebEvent
    {
        public string Name { get; set; }
        public DateTime Dt { get; set; }
        public string Loc { get; set; }
        public decimal Lati { get; set; }
        public decimal Longi { get; set; }
        public string Descr { get; set; }
        public int Cat { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int EventTypeId { get; set; }
    }
}
