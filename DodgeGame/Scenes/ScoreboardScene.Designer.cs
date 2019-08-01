namespace DodgeGame.Scenes
{
    partial class ScoreboardScene
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
            this.titleLable = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.scoreTable = new System.Windows.Forms.TableLayoutPanel();
            this.usernameTitleLabel = new System.Windows.Forms.Label();
            this.livesTitleLabel = new System.Windows.Forms.Label();
            this.scoreTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.scoreTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.titleLable, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.BackButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.scoreTable, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(678, 480);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(149, 0);
            this.titleLable.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(378, 144);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Scoreboard";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Location = new System.Drawing.Point(138, 315);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(400, 66);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.ScoreboardScene_Click);
            // 
            // scoreTable
            // 
            this.scoreTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.scoreTable.ColumnCount = 3;
            this.scoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.scoreTable.Controls.Add(this.usernameTitleLabel, 0, 0);
            this.scoreTable.Controls.Add(this.livesTitleLabel, 1, 0);
            this.scoreTable.Controls.Add(this.scoreTitleLabel, 2, 0);
            this.scoreTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTable.Location = new System.Drawing.Point(138, 147);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.RowCount = 2;
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scoreTable.Size = new System.Drawing.Size(400, 162);
            this.scoreTable.TabIndex = 5;
            // 
            // usernameTitleLabel
            // 
            this.usernameTitleLabel.AutoSize = true;
            this.usernameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTitleLabel.Location = new System.Drawing.Point(4, 1);
            this.usernameTitleLabel.Name = "usernameTitleLabel";
            this.usernameTitleLabel.Size = new System.Drawing.Size(132, 29);
            this.usernameTitleLabel.TabIndex = 0;
            this.usernameTitleLabel.Text = "Username";
            // 
            // livesTitleLabel
            // 
            this.livesTitleLabel.AutoSize = true;
            this.livesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesTitleLabel.Location = new System.Drawing.Point(203, 1);
            this.livesTitleLabel.Name = "livesTitleLabel";
            this.livesTitleLabel.Size = new System.Drawing.Size(61, 30);
            this.livesTitleLabel.TabIndex = 1;
            this.livesTitleLabel.Text = "Lives";
            // 
            // scoreTitleLabel
            // 
            this.scoreTitleLabel.AutoSize = true;
            this.scoreTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitleLabel.Location = new System.Drawing.Point(283, 1);
            this.scoreTitleLabel.Name = "scoreTitleLabel";
            this.scoreTitleLabel.Size = new System.Drawing.Size(82, 29);
            this.scoreTitleLabel.TabIndex = 2;
            this.scoreTitleLabel.Text = "Score";
            // 
            // ScoreboardScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ScoreboardScene";
            this.Size = new System.Drawing.Size(678, 480);
            this.Load += new System.EventHandler(this.ScoreboardScene_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.scoreTable.ResumeLayout(false);
            this.scoreTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TableLayoutPanel scoreTable;
        private System.Windows.Forms.Label usernameTitleLabel;
        private System.Windows.Forms.Label livesTitleLabel;
        private System.Windows.Forms.Label scoreTitleLabel;
    }
}
