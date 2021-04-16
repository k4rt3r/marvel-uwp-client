using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Dtos
{
    public class StoryDataWrapper
    {
        public string code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public StoryDataContainer data { get; set; }
        public string etag { get; set; }
    }

    public class StoryDataContainer
    {
        public string offset { get; set; }
        public string limit { get; set; }
        public string total { get; set; }
        public string count { get; set; }
        public Story[] results { get; set; }
    }

    public class Story
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public string type { get; set; }
        public string modified { get; set; }
        public Image thumbnail { get; set; }
        public Comic comics { get; set; }
        public Series series { get; set; }
        public Event events { get; set; }
        public Character characters { get; set; }
        public Creator creators { get; set; }
        public ComicSummary originalissue { get; set; }
    }

    public class StoryList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public List<StorySummary> items { get; set; }
    }

    public class StorySummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }
}
