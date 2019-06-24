using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeGame
{
    /// <summary>
    /// The config prompt that asks the user for
    /// their name and number of lives
    /// </summary>
    public partial class ConfigPrompt : Form
    {
        public ConfigPrompt()
        {
            InitializeComponent();
        }

        private void ConfigPrompt_FormClosing(object sender, FormClosingEventArgs e)
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
                e.Cancel = true;
            }
        }
    }
}
