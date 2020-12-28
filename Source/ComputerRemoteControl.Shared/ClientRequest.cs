using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComputerRemoteControl.Shared
{
    public class ClientRequest
    {
        public Command Command { get; set; }
        public Dictionary<string, string> RequestValues { get; set; }

        public static ClientRequest GetRequestObject(string jsonData)
        {
            if (string.IsNullOrEmpty(jsonData))
                return new ClientRequest { Command = Command.NoCommand };

            return JsonConvert.DeserializeObject<ClientRequest>(jsonData);
        }

        public static string GetRequestJson(ClientRequest request)
        {
            return JsonConvert.SerializeObject(request);
        }
    }
}
