using Newtonsoft.Json;        // NuGet: Newtonsoft.Json
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServewerLog_in
{
    public class Profile
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Bio { get; set; }
    }

    /// <summary>Thrown when the server answers with an error status. Message is the server's text.</summary>
    public class ApiException : Exception
    {
        public HttpStatusCode Status { get; }
        public ApiException(HttpStatusCode status, string message) : base(message) { Status = status; }
    }

    public static class ApiClient
    {
        private class LoginResult { public string Token { get; set; } public Profile User { get; set; } }
        private class UserResult { public Profile User { get; set; } }

        // The trailing slash matters: it keeps "/api/" when we call "auth/login".
        private static readonly HttpClient http = new HttpClient
        {
            BaseAddress = new Uri("https://api.54-36-162-208.sslip.io/api/"),   // <- adjust if the real base URL differs
            Timeout = TimeSpan.FromSeconds(15)
        };

        private static async Task<string> SendAsync(HttpMethod method, string path, object body = null)
        {
            var req = new HttpRequestMessage(method, path);
            if (body != null)
                req.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

            var resp = await http.SendAsync(req);
            var text = await resp.Content.ReadAsStringAsync();
            if (!resp.IsSuccessStatusCode)
                throw new ApiException(resp.StatusCode, ParseError(text));
            return text;
        }

        // Turns {"error": "...", "details": [{"field":..., "message":...}]} into one readable string
        private static string ParseError(string json)
        {
            try
            {
                var o = JObject.Parse(json);
                var msg = (string)o["error"] ?? "Błąd serwera.";
                var details = o["details"] as JArray;
                if (details != null)
                    foreach (var d in details) msg += "\n" + (string)d["message"];
                return msg;
            }
            catch { return "Błąd serwera."; }
        }

        public static async Task RegisterAsync(string email, string password, string displayName)
        {
            await SendAsync(HttpMethod.Post, "auth/register", new { email, password, displayName });
        }

        /// <summary>Returns the profile. Throws ApiException (401 = wrong email/password).</summary>
        public static async Task<Profile> LoginAsync(string email, string password)
        {
            var text = await SendAsync(HttpMethod.Post, "auth/login", new { email, password });
            var result = JsonConvert.DeserializeObject<LoginResult>(text);
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", result.Token);
            return result.User;
        }

        public static async Task<Profile> UpdateProfileAsync(string displayName, string bio)
        {
            var text = await SendAsync(new HttpMethod("PATCH"), "auth/me", new { displayName, bio });
            return JsonConvert.DeserializeObject<UserResult>(text).User;
        }

        public static async Task LogoutAsync()
        {
            try { await SendAsync(HttpMethod.Post, "auth/logout"); }
            catch { /* even if the server can't be reached, forget the token locally */ }
            finally { http.DefaultRequestHeaders.Authorization = null; }
        }
    }
}