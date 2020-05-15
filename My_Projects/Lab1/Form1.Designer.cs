namespace Lab1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pawelRadioButton = new System.Windows.Forms.RadioButton();
            this.kamilRadioButton = new System.Windows.Forms.RadioButton();
            this.szymonRadioButton = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.greyHoundFirst = new System.Windows.Forms.PictureBox();
            this.greyHoundSecond = new System.Windows.Forms.PictureBox();
            this.greyHoundThird = new System.Windows.Forms.PictureBox();
            this.greyHoundFour = new System.Windows.Forms.PictureBox();
            this.labelname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pawelBetLabel = new System.Windows.Forms.Label();
            this.kamilBetLabel = new System.Windows.Forms.Label();
            this.szymonBetLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyHoundFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyHoundSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyHoundThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyHoundFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pawelRadioButton
            // 
            this.pawelRadioButton.AutoSize = true;
            this.pawelRadioButton.Location = new System.Drawing.Point(45, 311);
            this.pawelRadioButton.Name = "pawelRadioButton";
            this.pawelRadioButton.Size = new System.Drawing.Size(112, 17);
            this.pawelRadioButton.TabIndex = 6;
            this.pawelRadioButton.TabStop = true;
            this.pawelRadioButton.Text = "pawelRadioButton";
            this.pawelRadioButton.UseVisualStyleBackColor = true;
            this.pawelRadioButton.CheckedChanged += new System.EventHandler(this.pawelRadioButton_CheckedChanged);
            // 
            // kamilRadioButton
            // 
            this.kamilRadioButton.AutoSize = true;
            this.kamilRadioButton.Location = new System.Drawing.Point(45, 334);
            this.kamilRadioButton.Name = "kamilRadioButton";
            this.kamilRadioButton.Size = new System.Drawing.Size(108, 17);
            this.kamilRadioButton.TabIndex = 7;
            this.kamilRadioButton.TabStop = true;
            this.kamilRadioButton.Text = "kamilRadioButton";
            this.kamilRadioButton.UseVisualStyleBackColor = true;
            this.kamilRadioButton.CheckedChanged += new System.EventHandler(this.kamilRadioButton_CheckedChanged);
            // 
            // szymonRadioButton
            // 
            this.szymonRadioButton.AutoSize = true;
            this.szymonRadioButton.Location = new System.Drawing.Point(45, 357);
            this.szymonRadioButton.Name = "szymonRadioButton";
            this.szymonRadioButton.Size = new System.Drawing.Size(119, 17);
            this.szymonRadioButton.TabIndex = 8;
            this.szymonRadioButton.TabStop = true;
            this.szymonRadioButton.Text = "szymonRadioButton";
            this.szymonRadioButton.UseVisualStyleBackColor = true;
            this.szymonRadioButton.CheckedChanged += new System.EventHandler(this.szymonRadioButton_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(392, 407);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.betButton.FlatAppearance.BorderSize = 2;
            this.betButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.betButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.betButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betButton.Location = new System.Drawing.Point(98, 404);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(55, 23);
            this.betButton.TabIndex = 15;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // greyHoundFirst
            // 
            this.greyHoundFirst.Image = ((System.Drawing.Image)(resources.GetObject("greyHoundFirst.Image")));
            this.greyHoundFirst.Location = new System.Drawing.Point(25, 21);
            this.greyHoundFirst.Name = "greyHoundFirst";
            this.greyHoundFirst.Size = new System.Drawing.Size(75, 20);
            this.greyHoundFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greyHoundFirst.TabIndex = 16;
            this.greyHoundFirst.TabStop = false;
            this.greyHoundFirst.Click += new System.EventHandler(this.chart1_Click);
            // 
            // greyHoundSecond
            // 
            this.greyHoundSecond.Image = ((System.Drawing.Image)(resources.GetObject("greyHoundSecond.Image")));
            this.greyHoundSecond.Location = new System.Drawing.Point(25, 69);
            this.greyHoundSecond.Name = "greyHoundSecond";
            this.greyHoundSecond.Size = new System.Drawing.Size(75, 20);
            this.greyHoundSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greyHoundSecond.TabIndex = 17;
            this.greyHoundSecond.TabStop = false;
            // 
            // greyHoundThird
            // 
            this.greyHoundThird.Image = ((System.Drawing.Image)(resources.GetObject("greyHoundThird.Image")));
            this.greyHoundThird.Location = new System.Drawing.Point(25, 116);
            this.greyHoundThird.Name = "greyHoundThird";
            this.greyHoundThird.Size = new System.Drawing.Size(75, 20);
            this.greyHoundThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greyHoundThird.TabIndex = 18;
            this.greyHoundThird.TabStop = false;
            // 
            // greyHoundFour
            // 
            this.greyHoundFour.Image = ((System.Drawing.Image)(resources.GetObject("greyHoundFour.Image")));
            this.greyHoundFour.Location = new System.Drawing.Point(25, 164);
            this.greyHoundFour.Name = "greyHoundFour";
            this.greyHoundFour.Size = new System.Drawing.Size(75, 20);
            this.greyHoundFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greyHoundFour.TabIndex = 19;
            this.greyHoundFour.TabStop = false;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(22, 409);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(33, 13);
            this.labelname.TabIndex = 22;
            this.labelname.Text = "name";
            this.labelname.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "zl on greyhound number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(292, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Betting";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(45, 274);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(134, 17);
            this.minimumBetLabel.TabIndex = 25;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(186, 407);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pawelBetLabel
            // 
            this.pawelBetLabel.AutoSize = true;
            this.pawelBetLabel.Location = new System.Drawing.Point(308, 311);
            this.pawelBetLabel.Name = "pawelBetLabel";
            this.pawelBetLabel.Size = new System.Drawing.Size(77, 13);
            this.pawelBetLabel.TabIndex = 27;
            this.pawelBetLabel.Text = "pawelBetLabel";
            // 
            // kamilBetLabel
            // 
            this.kamilBetLabel.AutoSize = true;
            this.kamilBetLabel.Location = new System.Drawing.Point(308, 334);
            this.kamilBetLabel.Name = "kamilBetLabel";
            this.kamilBetLabel.Size = new System.Drawing.Size(73, 13);
            this.kamilBetLabel.TabIndex = 28;
            this.kamilBetLabel.Text = "kamilBetLabel";
            // 
            // szymonBetLabel
            // 
            this.szymonBetLabel.AutoSize = true;
            this.szymonBetLabel.Location = new System.Drawing.Point(308, 359);
            this.szymonBetLabel.Name = "szymonBetLabel";
            this.szymonBetLabel.Size = new System.Drawing.Size(84, 13);
            this.szymonBetLabel.TabIndex = 29;
            this.szymonBetLabel.Text = "szymonBetLabel";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(524, 54);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(134, 106);
            this.startButton.TabIndex = 30;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 220);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bookmaker House";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.Image")));
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(776, 185);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 32;
            this.racetrackPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.szymonBetLabel);
            this.Controls.Add(this.kamilBetLabel);
            this.Controls.Add(this.pawelBetLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.greyHoundFour);
            this.Controls.Add(this.greyHoundThird);
            this.Controls.Add(this.greyHoundSecond);
            this.Controls.Add(this.greyHoundFirst);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.szymonRadioButton);
            this.Controls.Add(this.kamilRadioButton);
            this.Controls.Add(this.pawelRadioButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyHoundFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyHoundSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyHoundThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyHoundFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton pawelRadioButton;
        private System.Windows.Forms.RadioButton kamilRadioButton;
        private System.Windows.Forms.RadioButton szymonRadioButton;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.PictureBox greyHoundFirst;
        private System.Windows.Forms.PictureBox greyHoundSecond;
        private System.Windows.Forms.PictureBox greyHoundThird;
        private System.Windows.Forms.PictureBox greyHoundFour;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label pawelBetLabel;
        private System.Windows.Forms.Label kamilBetLabel;
        private System.Windows.Forms.Label szymonBetLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
    }
}

