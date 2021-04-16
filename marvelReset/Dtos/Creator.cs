using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Dtos
{
    public class CreatorDataWrapper
    {
        public string code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public CreatorDataContainer data { get; set; }
        public string etag { get; set; }
    }

    public class CreatorDataContainer
    {
        public string offset { get; set; }
        public string limit { get; set; }
        public string total { get; set; }
        public string count { get; set; }
        public Creator[] results { get; set; }
    }

    public class Creator
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string suffix { get; set; }
        public string fullName { get; set; }
        public string modified { get; set; }
        public string resourceURI { get; set; }
        public URL[] urls { get; set; }
        public Image thumbnail { get; set; }
        public Series series { get; set; }
        public Story stories { get; set; }
        public Comic comics { get; set; }
        public Event events { get; set; }
    }

    public class CreatorList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public List<CreatorSummary> items { get; set; }
    }

    public class CreatorSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string role { get; set; }
    }
}
