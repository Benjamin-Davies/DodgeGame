namespace DodgeGame
{
    partial class DodgeScene
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlanetTimer = new System.Windows.Forms.Timer(this.components);
            this.StarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PlanetTimer
            // 
            this.PlanetTimer.Interval = 200;
            this.PlanetTimer.Tick += new System.EventHandler(PlanetTimer_Tick);
            //
            // StarTimer
            //
            this.StarTimer.Tick += new System.EventHandler(StarTimer_Tick);
            // 
            // DodgeScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "DodgeScene";
            this.Load += new System.EventHandler(this.DodgeScene_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DodgeScene_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DodgeScene_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer PlanetTimer;
        private System.Windows.Forms.Timer StarTimer;
    }
}
