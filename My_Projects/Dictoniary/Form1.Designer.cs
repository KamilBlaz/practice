namespace Dictoniary
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.playerYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer";
            // 
            // playerNumber
            // 
            this.playerNumber.FormattingEnabled = true;
            this.playerNumber.Location = new System.Drawing.Point(77, 29);
            this.playerNumber.Name = "playerNumber";
            this.playerNumber.Size = new System.Drawing.Size(45, 21);
            this.playerNumber.TabIndex = 3;
            this.playerNumber.SelectedIndexChanged += new System.EventHandler(this.playerNumber_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ", który zakończył kariere w";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "roku";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(173, 33);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(63, 13);
            this.playerName.TabIndex = 7;
            this.playerName.Text = "playerName";
            // 
            // playerYear
            // 
            this.playerYear.AutoSize = true;
            this.playerYear.Location = new System.Drawing.Point(441, 33);
            this.playerYear.Name = "playerYear";
            this.playerYear.Size = new System.Drawing.Size(57, 13);
            this.playerYear.TabIndex = 8;
            this.playerYear.Text = "playerYear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 81);
            this.Controls.Add(this.playerYear);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "T-shirt numbers of famous guides";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox playerNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label playerYear;
    }
}

