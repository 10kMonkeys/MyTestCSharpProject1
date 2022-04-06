using System;
using Newtonsoft.Json;

namespace MyTestCSharpProject1.Src.Dto
{
    public class PostCreateUserResponseDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
