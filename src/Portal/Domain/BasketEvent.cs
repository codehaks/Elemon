using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain
{
    public class BasketEvent
    {
        public int Id { get; set; }
        public DateTime TimeCreated { get; set; }

        public EventType EventType { get; set; }
        public Basket EventData { get; set; }


    }

    public enum EventType
    {
        BasketCreated=0,
        ItemAdded=1,
        ItemRemoved=2

    }
}
