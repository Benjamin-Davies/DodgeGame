using DodgeGame.Properties;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    public partial class SettingsScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;

        public SettingsScene(MainWindow _form, Navigator _navigator)
        {
            InitializeComponent();

            form = _form;
            navigator = _navigator;
        }

        public void Pause()
        {
            // Save the fields
            Settings.Default.Username = Username.Text;
            Settings.Default.LifeCount = (int)LifeCount.Value;
        }

        public void Resume()
        {
            // Update the fields
            Username.Text = Settings.Default.Username;
            LifeCount.Value = Settings.Default.LifeCount;
        }

        public void UpdateScene() { }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Validate the username
            // It must start with a letter, and then only consist of letters, numbers, underscores and spaces.
            // It must also be at least 3 letters long and not end with a space
            var rx = new Regex(@"^[a-zA-Z][\w ]+\w$",
              RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Check the input against the regex
            bool matches = rx.IsMatch(Username.Text);

            // Stop the form from closing if it doesn't match
            if (!matches)
            {
                MessageBox.Show(this,
                    "It must start with a letter, and then only consist of letters, numbers, underscores and spaces.\n" +
                    "It must also be at least 3 letters long and not end with a space",
                    "Invalid Username");
                return;
            }
            // Go back
            navigator.Pop();
        }
    }
}
