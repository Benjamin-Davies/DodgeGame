namespace DodgeGame.Scenes
{
    partial class PauseScene
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
            this.ResumeButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.ResumeButton, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.HelpButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.titleLable, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.QuitButton, 1, 3);
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(1124, 630);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // ResumeButton
            // 
            this.ResumeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ResumeButton.Location = new System.Drawing.Point(227, 192);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(668, 120);
            this.ResumeButton.TabIndex = 6;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.HelpButton.Location = new System.Drawing.Point(227, 318);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(668, 88);
            this.HelpButton.TabIndex = 5;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(238, 0);
            this.titleLable.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(646, 189);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Paused";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // QuitButton
            // 
            this.QuitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.QuitButton.Location = new System.Drawing.Point(227, 412);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(668, 88);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit to Title";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // PauseScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "PauseScene";
            this.Size = new System.Drawing.Size(1124, 630);
            this.Load += new System.EventHandler(this.PauseScene_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button ResumeButton;
    }
}
