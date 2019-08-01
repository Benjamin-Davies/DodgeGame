using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DodgeGame.Properties;

namespace DodgeGame.Scenes
{
    public partial class ScoreboardScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;
        private CancellationTokenSource loading;

        public ScoreboardScene(MainWindow _form, Navigator _navigator)
        {
            InitializeComponent();

            BackButton.BackColor = Resources.AltBackColor;

            form = _form;
            navigator = _navigator;
        }

        public void Resume()
        {
            // Create an object so that loading the scores can be cancelled if we leave the scene
            loading = new CancellationTokenSource();

            // Load the scores asynchronously so that the UI can still be responsive
            Task.Run(async () =>
            {
                // Load the scores list
                var scores = await Scoreboard.GetScores();

                // Make sure that we update the UI on the UI thread
                Invoke((Action)(() =>
                {
                    // Suspend the layout cycle for the table
                    // so that it doesn't update while we are changing it
                    scoreTable.SuspendLayout();

                    // Delete all of the rows, except for the first one
                    for (int i = scoreTable.RowCount - 1; i >= 1; i--)
                    {
                        scoreTable.RowStyles.RemoveAt(i);
                    }
                    // Delete all of the labels, except for the first row (3)
                    for (int i = scoreTable.Controls.Count - 1; i >= 3; i--)
                    {
                        scoreTable.Controls.RemoveAt(i);
                    }

                    // Set the correct number of rows
                    scoreTable.RowCount = scores.Length + 2;
                    // Create a counter so that we can set the correct row
                    int j = 1;
                    // Loop through the scores
                    foreach (var score in scores)
                    {
                        // Create a row for each one
                        scoreTable.RowStyles.Add(
                            new RowStyle(SizeType.Absolute, 30));

                        // Create the labels and add them to the table
                        var usernameLabel = new Label
                        {
                            AutoSize = true,
                            Text = score.Username
                        };
                        scoreTable.Controls.Add(usernameLabel, 0, j);

                        var lifeCountLabel = new Label
                        {
                            AutoSize = true,
                            Text = score.LifeCount.ToString()
                        };
                        scoreTable.Controls.Add(lifeCountLabel, 1, j);

                        var scoreLabel = new Label
                        {
                            AutoSize = true,
                            Text = score.Score.ToString()
                        };
                        scoreTable.Controls.Add(scoreLabel, 2, j);

                        // Increment our row counter
                        j++;
                    }

                    // Add an extra row so that it works properly
                    scoreTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 0));

                    // Start the layout again
                    scoreTable.ResumeLayout();
                }));

                // Get rid of the cancelation token because we don't need it anymore
                loading = null;
            }, loading.Token);
        }

        public void Pause()
        {
            // Cancel loading, if it exists
            loading?.Cancel();
        }

        // Unused interface methods
        public void UpdateScene() { }

        private void ScoreboardScene_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void ScoreboardScene_Click(object sender, EventArgs e)
        {
            navigator.Pop();
        }
    }
}
