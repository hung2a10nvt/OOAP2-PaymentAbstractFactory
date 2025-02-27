namespace PaymentAbstractFactory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRussia = new System.Windows.Forms.Button();
            this.btnEurope = new System.Windows.Forms.Button();
            this.picMethod = new System.Windows.Forms.PictureBox();
            this.rtbSpec = new System.Windows.Forms.RichTextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMethod);
            this.panel1.Controls.Add(this.btnEurope);
            this.panel1.Controls.Add(this.btnRussia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region";
            // 
            // btnRussia
            // 
            this.btnRussia.Location = new System.Drawing.Point(73, 46);
            this.btnRussia.Name = "btnRussia";
            this.btnRussia.Size = new System.Drawing.Size(75, 23);
            this.btnRussia.TabIndex = 1;
            this.btnRussia.Text = "Russia";
            this.btnRussia.UseVisualStyleBackColor = true;
            this.btnRussia.Click += new System.EventHandler(this.btnRussia_Click);
            // 
            // btnEurope
            // 
            this.btnEurope.Location = new System.Drawing.Point(165, 46);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(75, 23);
            this.btnEurope.TabIndex = 2;
            this.btnEurope.Text = "Europe";
            this.btnEurope.UseVisualStyleBackColor = true;
            this.btnEurope.Click += new System.EventHandler(this.btnEurope_Click_1);
            // 
            // picMethod
            // 
            this.picMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMethod.Location = new System.Drawing.Point(0, 100);
            this.picMethod.Name = "picMethod";
            this.picMethod.Size = new System.Drawing.Size(1205, 513);
            this.picMethod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMethod.TabIndex = 3;
            this.picMethod.TabStop = false;
            // 
            // rtbSpec
            // 
            this.rtbSpec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbSpec.Location = new System.Drawing.Point(0, 517);
            this.rtbSpec.Name = "rtbSpec";
            this.rtbSpec.Size = new System.Drawing.Size(1205, 96);
            this.rtbSpec.TabIndex = 4;
            this.rtbSpec.Text = "";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(12, 84);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(0, 13);
            this.lblMethod.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 613);
            this.Controls.Add(this.rtbSpec);
            this.Controls.Add(this.picMethod);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMethod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.Button btnRussia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.RichTextBox rtbSpec;
    }
}

