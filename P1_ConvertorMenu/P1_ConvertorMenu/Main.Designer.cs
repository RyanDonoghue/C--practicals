namespace P1_ConvertorMenu
{
    partial class Main
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
            this.btn_length = new System.Windows.Forms.Button();
            this.btn_temperature = new System.Windows.Forms.Button();
            this.btn_currency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_length
            // 
            this.btn_length.Location = new System.Drawing.Point(12, 12);
            this.btn_length.Name = "btn_length";
            this.btn_length.Size = new System.Drawing.Size(132, 96);
            this.btn_length.TabIndex = 0;
            this.btn_length.Text = "Feet/Inches";
            this.btn_length.UseVisualStyleBackColor = true;
            this.btn_length.Click += new System.EventHandler(this.btn_length_Click);
            // 
            // btn_temperature
            // 
            this.btn_temperature.Location = new System.Drawing.Point(150, 12);
            this.btn_temperature.Name = "btn_temperature";
            this.btn_temperature.Size = new System.Drawing.Size(132, 96);
            this.btn_temperature.TabIndex = 1;
            this.btn_temperature.Text = "Celsius/Fahrenheit";
            this.btn_temperature.UseVisualStyleBackColor = true;
            this.btn_temperature.Click += new System.EventHandler(this.btn_temperature_Click);
            // 
            // btn_currency
            // 
            this.btn_currency.Location = new System.Drawing.Point(288, 12);
            this.btn_currency.Name = "btn_currency";
            this.btn_currency.Size = new System.Drawing.Size(132, 96);
            this.btn_currency.TabIndex = 2;
            this.btn_currency.Text = "GBP/EUR";
            this.btn_currency.UseVisualStyleBackColor = true;
            this.btn_currency.Click += new System.EventHandler(this.btn_currency_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 119);
            this.Controls.Add(this.btn_currency);
            this.Controls.Add(this.btn_temperature);
            this.Controls.Add(this.btn_length);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_length;
        private System.Windows.Forms.Button btn_temperature;
        private System.Windows.Forms.Button btn_currency;
    }
}

