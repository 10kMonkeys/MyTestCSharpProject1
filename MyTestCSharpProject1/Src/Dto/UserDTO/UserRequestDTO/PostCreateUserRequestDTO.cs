using System;
using Newtonsoft.Json;

namespace MyTestCSharpProject1.Src.Dto.UserDTO.UserRequestDTO
{
    public class PostCreateUserRequestDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }
    }
}
