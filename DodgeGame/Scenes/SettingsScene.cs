using DodgeGame.Properties;
using System;
using System.Text.RegularExpressions;
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
            // Save the fields
            Settings.Default.Username = Username.Text;
            Settings.Default.LifeCount = (int)LifeCount.Value;
        }

        /// <summary>
        /// Update the inputs
        /// </summary>
        public void Resume()
        {
            // Update the fields
            Username.Text = Settings.Default.Username;
            LifeCount.Value = Settings.Default.LifeCount;
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
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Validate the username
            // It must start with a letter, and then only consist of letters, numbers, underscores and spaces.
            // It must also be at least 3 letters long and not end with a space
            var rx = new Regex(@"^[a-zA-Z][\w ]+\w$",
              RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Check the input against the regex
            string username = Username.Text;
            bool matches = rx.IsMatch(username);

            // Stop the form from closing if it doesn't match
            if (!matches)
            {
                // Use more specific regexes to find out what went wrong
                var startWithLetterRegex = new Regex(@"^[a-zA-Z]");
                var validCharactersRegex = new Regex(@"^[\w ]*$");
                var endWithWordCharRegex = new Regex(@"\w$");

                // Display an error message
                if (username.Length < 3)
                {
                    usernameErrorLabel.Text = "Must be 3+ characters long";
                }
                else if (!startWithLetterRegex.IsMatch(username))
                {
                    usernameErrorLabel.Text = "Must start with a letter";
                }
                else if (!validCharactersRegex.IsMatch(username))
                {
                    usernameErrorLabel.Text = "Invalid character/symbol";
                }
                else if (!endWithWordCharRegex.IsMatch(username))
                {
                    usernameErrorLabel.Text = "Must not end with a space";
                }

                // Stop the scene from exiting
                return;
            }
            // Go back
            navigator.Pop();
        }
    }
}
