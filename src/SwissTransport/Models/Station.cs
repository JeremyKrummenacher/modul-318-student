using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwissTransport.Models
{
    public class Station
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int? Score { get; set; }

        [JsonProperty("coordinate")]
        public Coordinate Coordinate { get; set; }

        [JsonProperty("distance")]
        public double? Distance { get; set; }
    }

    public class Stations
    {
        [JsonProperty("stations")]
        public List<Station> StationList { get; set; }
    }
}