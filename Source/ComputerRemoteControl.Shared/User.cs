using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ComputerRemoteControl.Shared
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public static IEnumerable<User> GetUsers(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string jsonData = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<IEnumerable<User>>(jsonData);
            }
        }
    }
}
