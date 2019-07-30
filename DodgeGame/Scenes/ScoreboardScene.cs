using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    public partial class ScoreboardScene : UserControl, IScene
    {
        public ScoreboardScene()
        {
            InitializeComponent();
        }

        public void Resume()
        {
            // TODO: load scores
        }

        // Unused interface methods
        public void Pause() { }
        public void UpdateScene() { }

        private void ScoreboardScene_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
