using Newtonsoft.Json;
using System.Collections.Generic;

namespace ComputerRemoteControl.Shared
{
    public class ServerResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Dictionary<string,IEnumerable<object>> ResponseValues { get; set; }
        public IEnumerable<CustomProcess> Processes { get; set; }

        public static string GetResponseJson(ServerResponse obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static ServerResponse GetResponseObject(string responseJson)
        {
            return JsonConvert.DeserializeObject<ServerResponse>(responseJson);
        }
    }
}
