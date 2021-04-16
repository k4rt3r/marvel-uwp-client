using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Dtos
{
    public class ComicDataWrapper
    {
        //The HTTP status code of the returned result
        //---------------------------
        public int Code { get; set; }


        //A string description of the call status
        //---------------------------
        public string Status { get; set; }


        //The copyright notice for the returned result
        //---------------------------
        public string Copyright { get; set; }


        //The attribution notice for this result. Please display either this notice or the
        //contents of the attributionHTML field on all screens which contain data from the Marvel Comics API
        //---------------------------
        public string attributionText { get; set; }


        //An HTML representation of the attribution notice for this result. Please display either this notice
        //or the contents of the attributionText field on all screens which contain data from the Marvel Comics API.
        //---------------------------
        public string attributionHTML { get; set; }


        // The results returned by the call.
        //---------------------------
        public CharacterDataContainer Data { get; set; }


        //A digest value of the content returned by the call
        //---------------------------
        public string etag { get; set; }
    }

    public class ComicDataContainer
    {
        //The requested offset (number of skipped results) of the call.
        //---------------------------
        public int offset { get; set; }

        //The requested result limit
        //---------------------------
        public int limit { get; set; }

        //The total number of resources available given the current filter set
        //---------------------------
        public int total { get; set; }

        //The total number of results returned by this call
        //---------------------------
        public int count { get; set; }

        //The list of characters returned by the call
        //---------------------------
        public List<Character> Results { get; set; }
    }

    public class Comic
    {
        public int id { get; set; }
        public int digitalId { get; set; }
        public string title { get; set; }
        public string issueNumber { get; set; }
        public string variantDescription { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public string isbn { get; set; }
        public string upc { get; set; }
        public string diamondCode { get; set; }
        public string ean { get; set; }
        public string issn { get; set; }
        public string format { get; set; }
        public int pageCount { get; set; }
        public List<TextObject> textObjects { get; set; }
        public string resourceURI { get; set; }
        public List<URL> urls { get; set; }
        public List<SeriesSummary> series { get; set; }
        public List<ComicSummary> variants { get; set; }
        public List<ComicSummary> collections { get; set; }
        public List<ComicSummary> collectedIssues { get; set; }
        public List<ComicDate> dates { get; set; }
        public List<ComicPrice> prices { get; set; }
        public Image thumbnail { get; set; }
        public List<Image> images { get; set; }
        public List<CreatorList> creators { get; set; }
        public List<CharacterList> characters { get; set; }
        public List<StoryList> stories { get; set; }
        public List<EventList> events { get; set; }
    }

    public class ComicDate
    {
        public string type { get; set; }
        public string date { get; set; }
    }

    public class ComicPrice
    {
        public string type { get; set; }
        public float price { get; set; }
    }

    public class ComicList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public List<ComicSummary> items { get; set; }
    }

    public class ComicSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }
}
