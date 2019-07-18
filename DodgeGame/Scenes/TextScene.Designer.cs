namespace DodgeGame.Scenes
{
    partial class TextScene
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
            this.exitLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel.Controls.Add(this.exitLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.titleLabel, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tableLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextScene_MouseUp);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1060, 710);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.exitLabel, 2);
            this.exitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(226, 0);
            this.exitLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextScene_MouseUp);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "Click anywhere to continue";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.titleLabel, 2);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextScene_MouseUp);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Text here";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "TextScene";
            this.Size = new System.Drawing.Size(1060, 710);
            this.Load += new System.EventHandler(this.TextScene_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextScene_MouseUp);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}
