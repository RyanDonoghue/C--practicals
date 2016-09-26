namespace P1_CurrencyConvertor
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
            this.btn_todollar = new System.Windows.Forms.Button();
            this.btn_toeuro = new System.Windows.Forms.Button();
            this.btn_topound = new System.Windows.Forms.Button();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.currentCurr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_todollar
            // 
            this.btn_todollar.Location = new System.Drawing.Point(13, 64);
            this.btn_todollar.Name = "btn_todollar";
            this.btn_todollar.Size = new System.Drawing.Size(50, 50);
            this.btn_todollar.TabIndex = 0;
            this.btn_todollar.Text = "to $";
            this.btn_todollar.UseVisualStyleBackColor = true;
            this.btn_todollar.Click += new System.EventHandler(this.btn_todollar_Click);
            // 
            // btn_toeuro
            // 
            this.btn_toeuro.Location = new System.Drawing.Point(68, 64);
            this.btn_toeuro.Name = "btn_toeuro";
            this.btn_toeuro.Size = new System.Drawing.Size(50, 50);
            this.btn_toeuro.TabIndex = 1;
            this.btn_toeuro.Text = "to €";
            this.btn_toeuro.UseVisualStyleBackColor = true;
            this.btn_toeuro.Click += new System.EventHandler(this.btn_toeuro_Click);
            // 
            // btn_topound
            // 
            this.btn_topound.Location = new System.Drawing.Point(125, 64);
            this.btn_topound.Name = "btn_topound";
            this.btn_topound.Size = new System.Drawing.Size(50, 50);
            this.btn_topound.TabIndex = 2;
            this.btn_topound.Text = "to £";
            this.btn_topound.UseVisualStyleBackColor = true;
            this.btn_topound.Click += new System.EventHandler(this.btn_topound_Click);
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(13, 38);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(162, 20);
            this.numberbox.TabIndex = 3;
            this.numberbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentCurr
            // 
            this.currentCurr.Location = new System.Drawing.Point(68, 12);
            this.currentCurr.Name = "currentCurr";
            this.currentCurr.Size = new System.Drawing.Size(50, 20);
            this.currentCurr.TabIndex = 6;
            this.currentCurr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentCurr);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.btn_topound);
            this.Controls.Add(this.btn_toeuro);
            this.Controls.Add(this.btn_todollar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_todollar;
        private System.Windows.Forms.Button btn_toeuro;
        private System.Windows.Forms.Button btn_topound;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.TextBox currentCurr;
        private System.Windows.Forms.Button button1;
    }
}

