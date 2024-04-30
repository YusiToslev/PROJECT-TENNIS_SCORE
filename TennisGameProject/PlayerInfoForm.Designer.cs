namespace TennisGameProject
{
    partial class PlayerInfoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.winsTable = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lossesTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drawsTable = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerNameLabel.Location = new System.Drawing.Point(299, 25);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(215, 86);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player";
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerNameLabel.Click += new System.EventHandler(this.playerNameLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(67, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Victories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(352, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Losses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F);
            this.label3.Location = new System.Drawing.Point(615, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Draws";
            // 
            // winsTable
            // 
            this.winsTable.BackColor = System.Drawing.Color.Green;
            this.winsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader8});
            this.winsTable.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsTable.HideSelection = false;
            this.winsTable.Location = new System.Drawing.Point(32, 206);
            this.winsTable.Name = "winsTable";
            this.winsTable.Size = new System.Drawing.Size(225, 193);
            this.winsTable.TabIndex = 7;
            this.winsTable.UseCompatibleStateImageBehavior = false;
            this.winsTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Competitor";
            this.columnHeader5.Width = 117;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Score";
            this.columnHeader8.Width = 102;
            // 
            // lossesTable
            // 
            this.lossesTable.BackColor = System.Drawing.Color.Green;
            this.lossesTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lossesTable.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesTable.HideSelection = false;
            this.lossesTable.Location = new System.Drawing.Point(289, 206);
            this.lossesTable.Name = "lossesTable";
            this.lossesTable.Size = new System.Drawing.Size(225, 193);
            this.lossesTable.TabIndex = 8;
            this.lossesTable.UseCompatibleStateImageBehavior = false;
            this.lossesTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Competitor";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 102;
            // 
            // drawsTable
            // 
            this.drawsTable.BackColor = System.Drawing.Color.Green;
            this.drawsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.drawsTable.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawsTable.HideSelection = false;
            this.drawsTable.Location = new System.Drawing.Point(551, 206);
            this.drawsTable.Name = "drawsTable";
            this.drawsTable.Size = new System.Drawing.Size(225, 193);
            this.drawsTable.TabIndex = 9;
            this.drawsTable.UseCompatibleStateImageBehavior = false;
            this.drawsTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Competitor";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Score";
            this.columnHeader4.Width = 102;
            // 
            // PlayerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawsTable);
            this.Controls.Add(this.lossesTable);
            this.Controls.Add(this.winsTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerNameLabel);
            this.Name = "PlayerInfoForm";
            this.Text = "PLAYERINFOFORM";
            this.Load += new System.EventHandler(this.PlayerInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView winsTable;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lossesTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView drawsTable;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}