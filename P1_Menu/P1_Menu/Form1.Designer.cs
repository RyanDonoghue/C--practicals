namespace P1_Menu
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
            this.btn_tocalc = new System.Windows.Forms.Button();
            this.btn_tocurr = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tocalc
            // 
            this.btn_tocalc.Location = new System.Drawing.Point(13, 13);
            this.btn_tocalc.Name = "btn_tocalc";
            this.btn_tocalc.Size = new System.Drawing.Size(259, 70);
            this.btn_tocalc.TabIndex = 0;
            this.btn_tocalc.Text = "Calculator";
            this.btn_tocalc.UseVisualStyleBackColor = true;
            this.btn_tocalc.Click += new System.EventHandler(this.btn_tocalc_Click);
            // 
            // btn_tocurr
            // 
            this.btn_tocurr.Location = new System.Drawing.Point(12, 89);
            this.btn_tocurr.Name = "btn_tocurr";
            this.btn_tocurr.Size = new System.Drawing.Size(259, 70);
            this.btn_tocurr.TabIndex = 1;
            this.btn_tocurr.Text = "Currency Convertor";
            this.btn_tocurr.UseVisualStyleBackColor = true;
            this.btn_tocurr.Click += new System.EventHandler(this.btn_tocurr_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(12, 165);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(259, 70);
            this.btn_multi.TabIndex = 2;
            this.btn_multi.Text = "Multi Convertor";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_tocurr);
            this.Controls.Add(this.btn_tocalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tocalc;
        private System.Windows.Forms.Button btn_tocurr;
        private System.Windows.Forms.Button btn_multi;
    }
}

