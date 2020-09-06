using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;

namespace NetworkAPI
{
    public class User
    {
        private static string _url = @"/User";

        public string _name { get; protected set; }
        public string _password { get; protected set; }

        public JsonMirrors.WorkOut.WorkOutGoal _currentWorkOutGoal { get; protected set; }

        private User(string name, string password)
        {
            _name = name;
            _password = password;
        }

        public static async Task<User> LogIn(string url, string name, string password)
        {
            User user = new User(name, password);


            HttpClient httpClient = new HttpClient();
            string uri = url + _url + @"/LogIn";


            HttpContent httpContent = new StringContent(user.SerializeJson(), Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, httpContent);

            switch (responseMessage.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return user;
                case System.Net.HttpStatusCode.Unauthorized:
                    throw new UnauthorizedAccessException("Server Failed to validate credentials. Check UserName and Password");
                default:
                    throw new Exception("Unknown error occured during log in attempt");
            }
        }

        public static async Task<User> Create(string url, string name, string password)
        {
            User user = new User(name, password);


            HttpClient httpClient = new HttpClient();
            string uri = url + _url + @"/Create";


            HttpContent httpContent = new StringContent(user.SerializeJson(), Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, httpContent);

            switch (responseMessage.StatusCode)
            {
                case System.Net.HttpStatusCode.Created:
                    return user;
                case System.Net.HttpStatusCode.Unauthorized:
                    throw new UnauthorizedAccessException("Server Failed to validate credentials. Check UserName and Password");
                default:
                    throw new Exception("Unknown error occured during log in attempt");
            }
        }

        public static async Task<bool> CheckConnection(string url)
        {
            HttpClient httpClient = new HttpClient();
            string uri = url + _url + @"/CheckConnection";

            HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);

            switch (responseMessage.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return true;
                default:
                    return false;
            }
        }

        public async Task<bool> NextWorkOut(string url)
        {
            HttpClient httpClient = new HttpClient();
            string uri = url + _url + @"/GetNextWorkOut";


            HttpContent httpContent = new StringContent(SerializeJson(), Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, httpContent);

            switch (responseMessage.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    _currentWorkOutGoal = WorkOut.DeSerializeJson(await responseMessage.Content.ReadAsStringAsync());
                    return true;
                default:
                    throw new Exception("Unknown error occured");
            }
        }

        /// <summary>
        /// Serializes User into Jason using the provided struct
        /// </summary>
        public string SerializeJson()
        {
            return JsonSerializer.Serialize(JsonMirrors.User.FormatNameAndPassword(this), typeof(JsonMirrors.User.NameAndPassword), null);
        }

        /// <summary>
        /// Deserialize Json back into the eqivalent C# datastructure using the provided struct
        /// </summary>
        public static JsonMirrors.User.NameAndPassword DeSerializeJson(string serializedUser)
        {
            return (JsonMirrors.User.NameAndPassword)JsonSerializer.Deserialize(serializedUser, typeof(JsonMirrors.User.NameAndPassword));
        }
    }
}
