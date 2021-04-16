using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Dtos
{
    public class EventDataWrapper
    {
        public string code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public EventDataContainer data { get; set; }
        public string etag { get; set; }
    }

    public class EventDataContainer
    {
        public string offset { get; set; }
        public string limit { get; set; }
        public string total { get; set; }
        public string count { get; set; }
        public Event[] results { get; set; }
    }

    public class Event
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public URL[] urls { get; set; }
        public string modified { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public Image thumbnail { get; set; }
        public Comic comics { get; set; }
        public Story stories { get; set; }
        public Series series { get; set; }
        public Character characters { get; set; }
        public Creator creators { get; set; }
        public EventSummary next { get; set; }
        public EventSummary previous { get; set; }
    }

    public class EventList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public List<EventSummary> items { get; set; }
    }

    public class EventSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }
}
