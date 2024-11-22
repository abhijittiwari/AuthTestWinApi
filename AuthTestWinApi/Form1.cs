using System.DirectoryServices.AccountManagement;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading.Tasks;
namespace AuthTestWinApi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string domain = textBoxDomain.Text.Trim();
            string username = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string url = textBoxURL.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please provide all the required inputs.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool isAuthenticated = await PerformNTLMAuth(domain, username, password, url);

                if (isAuthenticated)
                    MessageBox.Show("Authentication successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Authentication failed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task<bool> PerformNTLMAuth(string domain, string username, string password, string url)
        {
            // Create NetworkCredential
            var credentials = new NetworkCredential(username, password, domain);

            // Configure HttpClientHandler with NTLM credentials
            var handler = new HttpClientHandler
            {
                Credentials = credentials
            };

            using (var client = new HttpClient(handler))
            {
                var response = await client.GetAsync(url);
                return response.IsSuccessStatusCode;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string domain = textBoxDomain.Text.Trim();
            string username = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            try
            {
                // Authenticate the user using Kerberos
                bool isAuthenticated = AuthenticateUserWithKerberos(domain, username, password);

                if (isAuthenticated)
                {
                    // Retrieve the current user's authentication type
                    string authType = GetCurrentAuthenticationType();

                    if (authType == "NTLM")
                    {
                        // If NTLM is used as fallback, throw an error
                        throw new InvalidOperationException("Authentication failed. NTLM was used as fallback, Kerberos is required.");
                    }

                    MessageBox.Show($"Authentication successful! \nUser: {username}\nAuth Type: {authType}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Authentication failed. Please check your credentials.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private bool AuthenticateUserWithKerberos(string domain, string username, string password)
            { 
            try
            {
                // Create a PrincipalContext for the domain
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, domain))
                {
                    // Validate credentials using Kerberos only (Negotiate)
                    return context.ValidateCredentials(username, password, ContextOptions.Negotiate);
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs (e.g., unable to contact domain), return false
                MessageBox.Show($"Error during authentication: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string GetCurrentAuthenticationType()
        {
            try
            {
                var identity = WindowsIdentity.GetCurrent();
                return identity.AuthenticationType; // Returns "Kerberos" or "NTLM"
            }
            catch (Exception ex)
            {
                // In case of an error retrieving the authentication type, return "Unknown"
                return "Unknown";
            }
        }
    

    }
    
}
