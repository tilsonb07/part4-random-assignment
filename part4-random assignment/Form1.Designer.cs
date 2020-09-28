namespace part4_random_assignment
{
    partial class frm1
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
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.txtboxmax = new System.Windows.Forms.TextBox();
            this.txtboxmin = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(11, 28);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(51, 13);
            this.lblMaximum.TabIndex = 0;
            this.lblMaximum.Text = "Maximum";
            this.lblMaximum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(11, 54);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(48, 13);
            this.lblMinimum.TabIndex = 1;
            this.lblMinimum.Text = "Minimum";
            this.lblMinimum.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtboxmax
            // 
            this.txtboxmax.Location = new System.Drawing.Point(68, 25);
            this.txtboxmax.Name = "txtboxmax";
            this.txtboxmax.Size = new System.Drawing.Size(100, 20);
            this.txtboxmax.TabIndex = 2;
            this.txtboxmax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxmin
            // 
            this.txtboxmin.Location = new System.Drawing.Point(68, 54);
            this.txtboxmin.Name = "txtboxmin";
            this.txtboxmin.Size = new System.Drawing.Size(100, 20);
            this.txtboxmin.TabIndex = 3;
            this.txtboxmin.TextChanged += new System.EventHandler(this.txtboxmin_TextChanged);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(12, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(220, 13);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Please Enter A Minimum And Maximum Value";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(168, 87);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 80);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 20);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(12, 106);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 20);
            this.btnDouble.TabIndex = 7;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 136);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtboxmin);
            this.Controls.Add(this.txtboxmax);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblMaximum);
            this.Name = "frm1";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox txtboxmax;
        private System.Windows.Forms.TextBox txtboxmin;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDouble;
    }
}

