namespace DodgeGame.Scenes
{
    partial class WelcomeScene
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ScoreboardButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.ScoreboardButton, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.QuitButton, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.HelpButton, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.SettingsButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.titleLable, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.PlayButton, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1080, 720);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // QuitButton
            // 
            this.QuitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuitButton.Location = new System.Drawing.Point(543, 471);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(318, 102);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit Game";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpButton.Location = new System.Drawing.Point(543, 363);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(318, 102);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Location = new System.Drawing.Point(219, 363);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(318, 102);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.titleLable, 2);
            this.titleLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(230, 0);
            this.titleLable.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(620, 216);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "DodgeGame";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PlayButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.PlayButton, 2);
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayButton.Location = new System.Drawing.Point(219, 219);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(642, 138);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ScoreboardButton
            // 
            this.ScoreboardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreboardButton.Location = new System.Drawing.Point(219, 471);
            this.ScoreboardButton.Name = "ScoreboardButton";
            this.ScoreboardButton.Size = new System.Drawing.Size(318, 102);
            this.ScoreboardButton.TabIndex = 5;
            this.ScoreboardButton.Text = "Scoreboard";
            this.ScoreboardButton.UseVisualStyleBackColor = true;
            this.ScoreboardButton.Click += new System.EventHandler(this.ScoreboardButton_Click);
            // 
            // WelcomeScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Name = "WelcomeScene";
            this.Size = new System.Drawing.Size(1080, 720);
            this.Load += new System.EventHandler(this.WelcomeScene_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ScoreboardButton;
    }
}
