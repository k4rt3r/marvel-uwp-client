using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Dtos
{
    public class CharacterDataWrapper
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
    public class CharacterDataContainer
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
    public class Character
    {
        //The unique ID of the character resource
        //---------------------------
        public string id { get; set; }

        //The name of the character
        //---------------------------
        public string name { get; set; }

        //A short bio or description of the character
        //---------------------------
        public string description { get; set; }

        //The date the resource was most recently modified
        //---------------------------
        public string modified { get; set; }

        //The canonical URL identifier for this resource
        //---------------------------
        public string resourceURI { get; set; }

        //A set of public web site URLs for the resource
        //---------------------------
        public List<URL> Urls { get; set; }

        //The representative image for this character
        //---------------------------
        public Image thumbnail { get; set; }

        //A resource list containing comics which feature this character
        //---------------------------
        public ComicList Comics { get; set; }

        //A resource list of stories in which this character appears
        //---------------------------
        public StoryList Stories { get; set; }

        //A resource list of events in which this character appears
        //---------------------------
        public EventList Events { get; set; }

        //A resource list of series in which this character appears
        //---------------------------
        public SeriesList Series { get; set; }
    }
    public class CharacterSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string role { get; set; }
    }
    public class CharacterList
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public List<CharacterSummary> items { get; set; }
    }
}
