using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebooklogin.Models
{
    public class facebook_login
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("friends")]
        public Friends Friends { get; set; }

        [JsonProperty("picture")]
        public Picture Picture { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public partial class Friends
    {
        [JsonProperty("data")]
        public object[] Data { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }
    }

    public partial class Summary
    {
        [JsonProperty("total_count")]
        public long TotalCount { get; set; }
    }

    public partial class Picture
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("is_silhouette")]
        public bool IsSilhouette { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }
}
