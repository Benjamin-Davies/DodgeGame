using DodgeGame.Properties;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    /// <summary>
    /// Scene for inputing your name and desired life count
    /// </summary>
    public partial class SettingsScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;

        public SettingsScene(MainWindow _form, Navigator _navigator)
        {
            InitializeComponent();

            BackButton.BackColor = Resources.AltBackColor;

            form = _form;
            navigator = _navigator;
        }

        /// <summary>
        /// Save the inputs
        /// </summary>
        public void Pause()
        {
            // Delay the navigation until we have validated
            navigator.DelayNavigation(async () =>
            {
                // Validate the input, and exit if it's invalid
                if (!await ValidateInput()) return false;

                // Save the fields
                Settings.Default.Username = Username.Text;
                Settings.Default.LifeCount = (int)LifeCount.Value;
                Settings.Default.ScoreboardOptOut = OptOutCheckBox.Checked;
                return true;
            });
        }

        /// <summary>
        /// Update the inputs
        /// </summary>
        public void Resume()
        {
            // Update the fields
            Username.Text = Settings.Default.Username;
            LifeCount.Value = Settings.Default.LifeCount;
            OptOutCheckBox.Checked = Settings.Default.ScoreboardOptOut;
        }

        // Unused
        public void UpdateScene() { }

        /// <summary>
        /// Is called when the scene is created
        /// </summary>
        private void SettingsScene_Load(object sender, EventArgs e)
        {
            // Fill the window
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Validate the user's input and exit the scene
        /// </summary>
        private async Task<bool> ValidateInput()
        {
            // Validate the username
            // It must only contain letters
            // It must also be at least 3 letters long and not end with a space
            var rx = new Regex(@"^[a-zA-Z]{3,}$",
              RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Check the input against the regex
            string username = Username.Text;
            bool matches = rx.IsMatch(username);

            // Stop the form from closing if it doesn't match
            if (!matches)
            {
                // Use more specific regexes to find out what went wrong
                var onlyLetters = new Regex(@"^[a-zA-Z]+$");

                string error = "Unknown error";

                // Display an error message
                if (username.Length < 3)
                {
                    error = "Must be 3+ characters long";
                }
                else if (!onlyLetters.IsMatch(username))
                {
                    error = "Must only contain letters";
                }

                // Set the error on the main thread
                form.Invoke((MethodInvoker)delegate
                {
                    usernameErrorLabel.Text = error;
                });

                // Stop the scene from exiting
                return false;
            }

            // Check if it is offensive
            //if (await RapidApi.BadWordFilter(username))
            //{
            //    usernameErrorLabel.Text = "May be offensive";
            //    return false;
            //}

            // The scene can exit
            return true;
        }
        
        /// <summary>
        /// Called when the back button is pressed
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Go back
            navigator.Pop();
        }
    }
}
