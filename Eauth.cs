using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.Diagnostics;
using System.Windows.Forms;

namespace Eauth
{
    class EauthPrimaryClass
    {
        /* Required configuration */
        private string accountKey = ""; //  account key goes here
        private string applicationKey = ""; // Your application key goes here
        private string applicationID = ""; // Your application ID goes here
        private string applicationVersion = "1.0"; // Your application version goes here

        /* Advanced configuration */
        private string invalidAccountKeyMessage = "Invalid account key!";
        private string invalidApplicationKeyMessage = "Invalid application key!";
        private string invalidRequestMessage = "Invalid request!";
        private string outdatedVersionMessage = "Outdated version, please upgrade!";
        private string busySessionsMessage = "Please try again later!";
        private string unavaiableSessionMessage = "Invalid session. Please re-launch the app!";
        private string usedSessionMessage = "Why did the computer go to therapy? Because it had a case of 'Request Repeatitis' and couldn't stop asking for the same thing over and over again!";
        private string overcrowdedSessionMessage = "Session limit exceeded. Please re-launch the app!";
        private string expiredSessionMessage = "Your session has timed out. please re-launch the app!";
        private string invalidUserMessage = "Incorrect login credentials!";
        private string bannedUserMessage = "Access denied!";
        private string incorrectHwidMessage = "Hardware ID mismatch. Please try again with the correct device!";
        private string expiredUserMessage = "Your subscription has ended. Please renew to continue using our service!";
        private string usedNameMessage = "Username already taken. Please choose a different username!";
        private string invalidKeyMessage = "Invalid key. Please enter a valid key!";
        private string upgradeYourEauthMessage = "Upgrade your Eauth plan to exceed the limits!";
        private string unauthorizedSessionMessage = "Unauthorized session.";
        private string invalidFileMessage = "Incorrect file credentials!";
        private string invalidEmailMessage = "The email you entered is either already in use or unavailable or invalid!";

        /* Dynamic configuration (this refers to configuration settings that can be changed during runtime) */
        private static bool init;
        private static string sessionID;
        private static string appStatus;
        public static string appName;
        public static string loggedMessage;
        public static string registeredMessage;

        private static bool login;
        public static string userRank;
        public static string registerDate;
        public static string expireDate;
        public static string userHwid;

        private static bool register;

        private static bool reset;

        public static string errorMessage;

        private static readonly HttpClient _client = new HttpClient();

        public static string ComputeSHA512(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private string GenerateAuthToken(string message, string appID)
        {
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            string authToken = timestamp.ToString().Substring(0, 4) + message + appID;
            return ComputeSHA512(authToken);
        }

        // Send post requests to Eauth
        private async Task<string> EauthRequest(Dictionary<string, string> data)
        {
            var url = "https://eauth.us.to/api/1.1/";
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("User-Agent", "e_a_u_t_h");
            var content = new FormUrlEncodedContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            request.Content = content;

            var response = await _client.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            JsonDocument document = JsonDocument.Parse(responseContent);
            string message = document.RootElement.GetProperty("message").GetString();
            if (message == "init_success" || message == "login_success" || message == "register_success" || message == "var_grab_success")
            {
                string authorizationKey = response.Headers.GetValues("Key").FirstOrDefault();
                if (authorizationKey != GenerateAuthToken(responseContent, applicationID))
                {
                    Environment.Exit(0);
                }
            }
            return responseContent;
        }

        // Log Eauth errors
        private void LogEauthError(string message)
        {
            errorMessage = message;
        }

        public string GetHardwareID()
        {
            string hardwareID = string.Empty;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                hardwareID = WindowsIdentity.GetCurrent().User.Value;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                string machineIDFile = "/etc/machine-id";
                if (File.Exists(machineIDFile))
                {
                    hardwareID = File.ReadAllText(machineIDFile).Trim();
                }
            }
            else
            {
                // Unsupported operating system
                throw new PlatformNotSupportedException();
            }

            return hardwareID;
        }

        // Initialization request (https://eauth.gitbook.io/eauth-api-1.1-latest/step-by-step/initialization)
        public async Task<bool> InitRequest()
        {
            if (init)
            {
                return init;
            }
            var data = new Dictionary<string, string>
            {
                { "sort", "init" },
                { "appkey", applicationKey },
                { "acckey", accountKey },
                { "version", applicationVersion.ToString() },
                { "hwid", GetHardwareID() }
            };
            var response = await EauthRequest(data);
            JsonDocument document = JsonDocument.Parse(response);
            string message = document.RootElement.GetProperty("message").GetString();

            if (message == "init_success")
            {
                // Init success
                init = true;
                sessionID = document.RootElement.GetProperty("session_id").GetString();
                appStatus = document.RootElement.GetProperty("app_status").GetString();
                appName = document.RootElement.GetProperty("app_name").GetString();
                loggedMessage = document.RootElement.GetProperty("logged_message").GetString();
                registeredMessage = document.RootElement.GetProperty("registered_message").GetString();
            }
            else if (message == "invalid_account_key")
            {
                LogEauthError(invalidAccountKeyMessage);
            }
            else if (message == "invalid_application_key")
            {
                LogEauthError(invalidApplicationKeyMessage);
            }
            else if (message == "invalid_request")
            {
                LogEauthError(invalidRequestMessage); // This is usually not the case
            }
            else if (message == "version_outdated")
            {
                string download_link = document.RootElement.GetProperty("download_link").GetString();
                if (download_link != "")
                {
                    Process.Start(download_link);
                }
                LogEauthError(outdatedVersionMessage);
            }
            else if (message == "maximum_sessions_reached")
            {
                LogEauthError(busySessionsMessage);
            }
            else if (message == "init_paused")
            {
                LogEauthError(document.RootElement.GetProperty("paused_message").GetString());
            }
            else if (message == "user_is_banned")
            {
                LogEauthError(bannedUserMessage);
            }

            return init;
        }

        // Register request (https://eauth.gitbook.io/eauth-api-1.1-latest/step-by-step/register)
        public async Task<bool> RegisterRequest(string username, string email, string password, string key)
        {
            var data = new Dictionary<string, string>
            {
                { "sort", "register" },
                { "sessionid", sessionID },
                { "username", username },
                { "email", email },
                { "password", password },
                { "key", key },
                { "hwid", GetHardwareID() }
            };
            var response = await EauthRequest(data);
            JsonDocument document = JsonDocument.Parse(response);
            string message = document.RootElement.GetProperty("message").GetString();

            if (message == "register_success")
            {
                // Register success
                register = true;
            }
            else if (message == "session_unavailable")
            {
                LogEauthError(unavaiableSessionMessage);
            }
            else if (message == "invalid_email")
            {
                LogEauthError(invalidEmailMessage);
            }
            else if (message == "session_already_used")
            {
                LogEauthError(usedSessionMessage);
            }
            else if (message == "invalid_request")
            {
                LogEauthError(invalidRequestMessage); // This is usually not the case
            }
            else if (message == "invalid_account_key")
            {
                LogEauthError(invalidAccountKeyMessage);
            }
            else if (message == "session_overcrowded")
            {
                LogEauthError(overcrowdedSessionMessage);
            }
            else if (message == "session_expired")
            {
                LogEauthError(expiredSessionMessage);
            }
            else if (message == "name_already_used")
            {
                LogEauthError(usedNameMessage);
            }
            else if (message == "key_unavailable")
            {
                LogEauthError(invalidKeyMessage);
            }
            else if (message == "maximum_users_reached")
            {
                LogEauthError(upgradeYourEauthMessage);
            }
            else if (message == "user_is_banned")
            {
                LogEauthError(bannedUserMessage);
            }

            return register;
        }

        // Login request (https://eauth.gitbook.io/eauth-api-1.1-latest/step-by-step/login)
        public async Task<bool> LoginRequest(string username, string password, string key)
        {
            if (login)
            {
                return login;
            }
            if (key.Length > 0)
            {
                username = password = key;
                var register_data = new Dictionary<string, string>
                {
                    { "sort", "register" },
                    { "sessionid", sessionID },
                    { "username", username },
                    { "password", password },
                    { "key", key },
                    { "hwid", GetHardwareID() }
                };
                var register_response = await EauthRequest(register_data);
                JsonDocument register_document = JsonDocument.Parse(register_response);
                string register_message = register_document.RootElement.GetProperty("message").GetString();

                if (register_message != "register_success" && register_message != "name_already_used")
                {
                    LogEauthError(invalidKeyMessage);
                }
            }

            var data = new Dictionary<string, string>
            {
                { "sort", "login" },
                { "sessionid", sessionID },
                { "username", username },
                { "password", password },
                { "hwid", GetHardwareID() }
            };
            var response = await EauthRequest(data);
            JsonDocument document = JsonDocument.Parse(response);
            string message = document.RootElement.GetProperty("message").GetString();

            if (message == "login_success")
            {
                // Login success
                login = true;
                userRank = document.RootElement.GetProperty("rank").GetString();
                registerDate = document.RootElement.GetProperty("register_date").GetString();
                expireDate = document.RootElement.GetProperty("expire_date").GetString();
                userHwid = document.RootElement.GetProperty("hwid").GetString();
            }
            else if (message == "invalid_account_key")
            {
                LogEauthError(invalidAccountKeyMessage);
            }
            else if (message == "session_unavailable")
            {
                LogEauthError(unavaiableSessionMessage);
            }
            else if (message == "invalid_request")
            {
                LogEauthError(invalidRequestMessage); // This is usually not the case
            }
            else if (message == "session_already_used")
            {
                LogEauthError(usedSessionMessage);
            }
            else if (message == "session_overcrowded")
            {
                LogEauthError(overcrowdedSessionMessage);
            }
            else if (message == "session_expired")
            {
                LogEauthError(expiredSessionMessage);
            }
            else if (message == "account_unavailable")
            {
                LogEauthError(invalidUserMessage);
            }
            else if (message == "user_is_banned")
            {
                LogEauthError(bannedUserMessage);
            }
            else if (message == "hwid_incorrect")
            {
                LogEauthError(incorrectHwidMessage + "\n" + "HWID reset is available " + document.RootElement.GetProperty("estimated_reset_time").GetString());
            }
            else if (message == "subscription_expired")
            {
                LogEauthError(expiredUserMessage);
            }

            return login;
        }

        // Reset password request (https://eauth.gitbook.io/eauth-api-1.1-latest/step-by-step/password-reset)
        public async Task<bool> ResetPasswordRequest(string email)
        {
            if (login || reset)
            {
                LogEauthError(usedSessionMessage);
                return false;
            }
            var data = new Dictionary<string, string>
            {
                { "sort", "reset_password" },
                { "sessionid", sessionID },
                { "email", email }
            };
            var response = await EauthRequest(data);
            JsonDocument document = JsonDocument.Parse(response);
            string message = document.RootElement.GetProperty("message").GetString();
            if (message == "sent_email")
            {
                // Reset success
                reset = true;
            }
            else if (message == "session_unavailable")
            {
                LogEauthError(unavaiableSessionMessage);
            }
            else if (message == "invalid_email")
            {
                LogEauthError(invalidEmailMessage);
            }
            else if (message == "session_unauthorized")
            {
                LogEauthError(unauthorizedSessionMessage);
            }
            else if (message == "invalid_request")
            {
                LogEauthError(invalidRequestMessage); // This is usually not the case
            }
            else if (message == "invalid_application_key")
            {
                LogEauthError(invalidApplicationKeyMessage);
            }
            else if (message == "session_expired")
            {
                LogEauthError(expiredSessionMessage);
            }
                return reset;
            }

        // Download request (https://eauth.gitbook.io/eauth-api-1.1-latest/step-by-step/download-file)
        public async Task<bool>DownloadRequest(string fileID, string outputPath, string fileName)
        {
            if (!init)
            {
                LogEauthError(unavaiableSessionMessage);
            }
            var data = new Dictionary<string, string>
            {
                { "sort", "download" },
                { "sessionid", sessionID },
                { "fileid", fileID }
            };
            var response = await EauthRequest(data);
            JsonDocument document = JsonDocument.Parse(response);
            string message = document.RootElement.GetProperty("message").GetString();

            bool downloadStatus = false;

            if (message == "download_success")
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage fResponse = await client.GetAsync(document.RootElement.GetProperty("link").GetString());

                    if (fResponse.IsSuccessStatusCode)
                    {
                        byte[] fileBytes = await fResponse.Content.ReadAsByteArrayAsync();

                        // Ensure the output directory exists
                        Directory.CreateDirectory(outputPath);

                        // Construct the full file path
                        string filePath = Path.Combine(outputPath, fileName);

                        // Write the file with the provided bytes
                        File.WriteAllBytes(filePath, fileBytes);

                        // Set return to true;
                        downloadStatus = true;
                    }
                    else
                    {
                        LogEauthError(invalidFileMessage);
                    }
                }
            }
            else if (message == "session_unavailable")
            {
                LogEauthError(unavaiableSessionMessage);
            }
            else if (message == "session_unauthorized")
            {
                LogEauthError(unauthorizedSessionMessage);
            }
            else if (message == "invalid_request")
            {
                LogEauthError(invalidRequestMessage); // This is usually not the case
            }
            else if (message == "invalid_account_key")
            {
                LogEauthError(invalidAccountKeyMessage);
            }
            else if (message == "session_expired")
            {
                LogEauthError(expiredSessionMessage);
            }
            else if (message == "invalid_file")
            {
                LogEauthError(invalidFileMessage);
            }

            return downloadStatus;
        }

        // Upgrade request (https://eauth.gitbook.io/eauth-api-1.1-latest/step-by-step/upgrade)
        public async Task<bool> UpgradeRequest(string username, string key)
        {
            bool upgrade = false;
            var data = new Dictionary<string, string>
            {
                { "sort", "upgrade" },
                { "sessionid", sessionID },
                { "username", username },
                { "key", key }
            };
            var response = await EauthRequest(data);
            JsonDocument document = JsonDocument.Parse(response);
            string message = document.RootElement.GetProperty("message").GetString();
            if (message == "upgrade_success")
            {
                // Upgrade success
                upgrade = true;
            }
            else if (message == "session_unavailable")
            {
                LogEauthError(unavaiableSessionMessage);
            }
            else if (message == "account_unavailable")
            {
                LogEauthError(invalidUserMessage);
            }
            else if (message == "key_unavailable")
            {
                LogEauthError(invalidKeyMessage);
            }
            else if (message == "invalid_email")
            {
                LogEauthError(invalidEmailMessage);
            }
            else if (message == "session_unauthorized")
            {
                LogEauthError(unauthorizedSessionMessage);
            }
            else if (message == "invalid_request")
            {
                LogEauthError(invalidRequestMessage); // This is usually not the case
            }
            else if (message == "invalid_account_key")
            {
                LogEauthError(invalidAccountKeyMessage);
            }
            else if (message == "session_expired")
            {
                LogEauthError(expiredSessionMessage);
            }
            return upgrade;
        }
    }
}
