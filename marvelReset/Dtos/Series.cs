using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Dtos
{
    public class SeriesDataWrapper
    {
        public string code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public SeriesDataContainer data { get; set; }
        public string etag { get; set; }
    }

    public class SeriesDataContainer
    {
        public string offset { get; set; }
        public string limit { get; set; }
        public string total { get; set; }
        public string count { get; set; }
        public Series[] results { get; set; }
    }

    public class Series
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public URL[] urls { get; set; }
        public string startYear { get; set; }
        public string endYear { get; set; }
        public string rating { get; set; }
        public string modified { get; set; }
        public Image thumbnail { get; set; }
        public ComicList comics { get; set; }
        public Story stories { get; set; }
        public Event events { get; set; }
        public Character characters { get; set; }
        public Creator creators { get; set; }
        public SeriesSummary next { get; set; }
        public SeriesSummary previous { get; set; }
    }

    public class SeriesList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public List<SeriesSummary> items { get; set; }
    }

    public class SeriesSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }
}
