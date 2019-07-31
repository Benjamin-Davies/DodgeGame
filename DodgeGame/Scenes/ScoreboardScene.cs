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
            loading = new CancellationTokenSource();
            Task.Run(async () =>
            {
                var scores = await Scoreboard.GetScores();

                Invoke((Action)(() =>
                {
                    scoreTable.SuspendLayout();

                    for (int i = scoreTable.RowCount - 1; i >= 1; i--)
                    {
                        scoreTable.RowStyles.RemoveAt(i);
                    }

                    scoreTable.RowCount = scores.Count + 2;
                    int j = 1;
                    foreach (var score in scores)
                    {
                        scoreTable.RowStyles.Add(
                            new RowStyle(SizeType.Absolute, 20));

                        var usernameLabel = new Label
                        {
                            AutoSize = true,
                            Text = score.Username
                        };
                        scoreTable.Controls.Add(usernameLabel, 0, j);

                        j++;
                    }
                    scoreTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 0));

                    scoreTable.ResumeLayout();
                }));

                loading = null;
            }, loading.Token);
        }

        public void Pause()
        {
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
