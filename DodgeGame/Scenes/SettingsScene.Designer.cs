namespace DodgeGame.Scenes
{
    partial class SettingsScene
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
            this.lifeCountLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.LifeCount = new System.Windows.Forms.NumericUpDown();
            this.OptOutCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.lifeCountLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.BackButton, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.titleLable, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.usernameLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.usernameErrorLabel, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.Username, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.LifeCount, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.OptOutCheckBox, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1060, 710);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lifeCountLabel
            // 
            this.lifeCountLabel.AutoSize = true;
            this.lifeCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lifeCountLabel.Location = new System.Drawing.Point(215, 284);
            this.lifeCountLabel.Name = "lifeCountLabel";
            this.lifeCountLabel.Size = new System.Drawing.Size(312, 71);
            this.lifeCountLabel.TabIndex = 6;
            this.lifeCountLabel.Text = "Life Count (1-5)";
            this.lifeCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BackButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.BackButton, 2);
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Location = new System.Drawing.Point(215, 464);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(630, 100);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.titleLable, 2);
            this.titleLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(226, 0);
            this.titleLable.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(608, 213);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Settings";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Location = new System.Drawing.Point(215, 213);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(312, 71);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLabel.ForeColor = System.Drawing.Color.HotPink;
            this.usernameErrorLabel.Location = new System.Drawing.Point(851, 213);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(206, 71);
            this.usernameErrorLabel.TabIndex = 5;
            // 
            // Username
            // 
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Location = new System.Drawing.Point(533, 216);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(312, 49);
            this.Username.TabIndex = 7;
            // 
            // LifeCount
            // 
            this.LifeCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifeCount.Location = new System.Drawing.Point(533, 287);
            this.LifeCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LifeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LifeCount.Name = "LifeCount";
            this.LifeCount.Size = new System.Drawing.Size(312, 49);
            this.LifeCount.TabIndex = 8;
            this.LifeCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // OptOutCheckBox
            // 
            this.OptOutCheckBox.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.OptOutCheckBox, 2);
            this.OptOutCheckBox.Location = new System.Drawing.Point(215, 358);
            this.OptOutCheckBox.Name = "OptOutCheckBox";
            this.OptOutCheckBox.Size = new System.Drawing.Size(412, 46);
            this.OptOutCheckBox.TabIndex = 10;
            this.OptOutCheckBox.Text = "Opt Out of Scoreboard";
            this.OptOutCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "SettingsScene";
            this.Size = new System.Drawing.Size(1060, 710);
            this.Load += new System.EventHandler(this.SettingsScene_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LifeCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label lifeCountLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.NumericUpDown LifeCount;
        private System.Windows.Forms.CheckBox OptOutCheckBox;
    }
}
