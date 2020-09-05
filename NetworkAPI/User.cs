using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;

namespace NetworkAPI
{
    public class User
    {
        private static string _url = @"/user";

        private string _name;
        private string _password;

        private User(string name, string password)
        {
            _name = name;
            _password = password;
        }

        public static async Task<User> LogOn(string url, string name, string password)
        {
            User user = new User(name, password);


            HttpClient httpClient = new HttpClient();
            string uri = url + _url + @"/LogOn";
            HttpContent httpContent = new StringContent(user.ToString() , Encoding.UTF8, "application/json");

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

        public override string ToString()
        {
            return "var user = { name: \""+_name+"\", password: \""+_password+"\" }";
        }
    }
}
