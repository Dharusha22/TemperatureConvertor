namespace TemperatureConvertor
{
    partial class Temperature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperature));
            pictureBox1 = new PictureBox();
            cbTemperature = new ComboBox();
            txtTemp1 = new TextBox();
            txtTemp2 = new TextBox();
            lblTemp1 = new Label();
            lblTemp2 = new Label();
            txtFormula = new TextBox();
            lblFormula = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cbTemperature
            // 
            cbTemperature.FormattingEnabled = true;
            cbTemperature.Items.AddRange(new object[] { "Celsius to Fahrenheit", "Celsius to Kelvin ", "Fahrenheit to Celsius", "Fahrenheit to Kelvin", "Kelvin to Celsius", "Kelvin to Fahrenheit " });
            cbTemperature.Location = new Point(147, 73);
            cbTemperature.Name = "cbTemperature";
            cbTemperature.Size = new Size(285, 23);
            cbTemperature.TabIndex = 1;
            cbTemperature.Text = "Select a conversion type";
            cbTemperature.SelectedIndexChanged += cbTemperature_SelectedIndexChanged;
            // 
            // txtTemp1
            // 
            txtTemp1.Location = new Point(158, 114);
            txtTemp1.Name = "txtTemp1";
            txtTemp1.Size = new Size(100, 23);
            txtTemp1.TabIndex = 2;
            txtTemp1.TextChanged += txtTemp1_TextChanged;
            txtTemp1.KeyPress += txtTemp1_KeyPress;
            // 
            // txtTemp2
            // 
            txtTemp2.Location = new Point(314, 114);
            txtTemp2.Name = "txtTemp2";
            txtTemp2.Size = new Size(100, 23);
            txtTemp2.TabIndex = 3;
            // 
            // lblTemp1
            // 
            lblTemp1.AutoSize = true;
            lblTemp1.Image = (Image)resources.GetObject("lblTemp1.Image");
            lblTemp1.Location = new Point(188, 140);
            lblTemp1.Name = "lblTemp1";
            lblTemp1.Size = new Size(0, 15);
            lblTemp1.TabIndex = 4;
            // 
            // lblTemp2
            // 
            lblTemp2.AutoSize = true;
            lblTemp2.Image = (Image)resources.GetObject("lblTemp2.Image");
            lblTemp2.Location = new Point(357, 140);
            lblTemp2.Name = "lblTemp2";
            lblTemp2.Size = new Size(0, 15);
            lblTemp2.TabIndex = 5;
            // 
            // txtFormula
            // 
            txtFormula.Location = new Point(158, 212);
            txtFormula.Name = "txtFormula";
            txtFormula.Size = new Size(274, 23);
            txtFormula.TabIndex = 6;
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Image = (Image)resources.GetObject("lblFormula.Image");
            lblFormula.Location = new Point(158, 194);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(54, 15);
            lblFormula.TabIndex = 7;
            lblFormula.Text = "Formula:";
            // 
            // Temperature
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(564, 305);
            Controls.Add(lblFormula);
            Controls.Add(txtFormula);
            Controls.Add(lblTemp2);
            Controls.Add(lblTemp1);
            Controls.Add(txtTemp2);
            Controls.Add(txtTemp1);
            Controls.Add(cbTemperature);
            Controls.Add(pictureBox1);
            Name = "Temperature";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Temperature";
            Load += Temperature_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cbTemperature;
        private TextBox txtTemp1;
        private TextBox txtTemp2;
        private Label lblTemp1;
        private Label lblTemp2;
        private TextBox txtFormula;
        private Label lblFormula;
    }
}