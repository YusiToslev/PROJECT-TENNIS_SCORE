namespace TennisGameProject
{
    partial class NewGameForm
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
            this.newGameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstPlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.secondPlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsFirstPlayerNumeric = new System.Windows.Forms.NumericUpDown();
            this.pointsSecondPlayerNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointsFirstPlayerNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsSecondPlayerNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameLabel
            // 
            this.newGameLabel.AutoSize = true;
            this.newGameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameLabel.Location = new System.Drawing.Point(273, 102);
            this.newGameLabel.Name = "newGameLabel";
            this.newGameLabel.Size = new System.Drawing.Size(267, 65);
            this.newGameLabel.TabIndex = 0;
            this.newGameLabel.Text = "New Game";
            this.newGameLabel.Click += new System.EventHandler(this.BUGFIXINGTOO);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Player";
            // 
            // firstPlayerNameTextBox
            // 
            this.firstPlayerNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstPlayerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPlayerNameTextBox.Location = new System.Drawing.Point(70, 201);
            this.firstPlayerNameTextBox.Name = "firstPlayerNameTextBox";
            this.firstPlayerNameTextBox.Size = new System.Drawing.Size(228, 29);
            this.firstPlayerNameTextBox.TabIndex = 1;
            // 
            // secondPlayerNameTextBox
            // 
            this.secondPlayerNameTextBox.BackColor = System.Drawing.Color.White;
            this.secondPlayerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPlayerNameTextBox.Location = new System.Drawing.Point(497, 201);
            this.secondPlayerNameTextBox.Name = "secondPlayerNameTextBox";
            this.secondPlayerNameTextBox.Size = new System.Drawing.Size(228, 29);
            this.secondPlayerNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Points";
            // 
            // pointsFirstPlayerNumeric
            // 
            this.pointsFirstPlayerNumeric.BackColor = System.Drawing.Color.White;
            this.pointsFirstPlayerNumeric.Location = new System.Drawing.Point(162, 282);
            this.pointsFirstPlayerNumeric.Name = "pointsFirstPlayerNumeric";
            this.pointsFirstPlayerNumeric.Size = new System.Drawing.Size(32, 20);
            this.pointsFirstPlayerNumeric.TabIndex = 3;
            // 
            // pointsSecondPlayerNumeric
            // 
            this.pointsSecondPlayerNumeric.BackColor = System.Drawing.Color.White;
            this.pointsSecondPlayerNumeric.Location = new System.Drawing.Point(604, 279);
            this.pointsSecondPlayerNumeric.Name = "pointsSecondPlayerNumeric";
            this.pointsSecondPlayerNumeric.Size = new System.Drawing.Size(32, 20);
            this.pointsSecondPlayerNumeric.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(587, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Points";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 40F);
            this.label5.Location = new System.Drawing.Point(360, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 72);
            this.label5.TabIndex = 10;
            this.label5.Text = "VS";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(323, 295);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(158, 42);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pointsSecondPlayerNumeric);
            this.Controls.Add(this.pointsFirstPlayerNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondPlayerNameTextBox);
            this.Controls.Add(this.firstPlayerNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newGameLabel);
            this.Name = "NewGameForm";
            this.Text = "NEWGAMEFORM";
            ((System.ComponentModel.ISupportInitialize)(this.pointsFirstPlayerNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsSecondPlayerNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newGameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstPlayerNameTextBox;
        private System.Windows.Forms.TextBox secondPlayerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pointsFirstPlayerNumeric;
        private System.Windows.Forms.NumericUpDown pointsSecondPlayerNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
    }
}