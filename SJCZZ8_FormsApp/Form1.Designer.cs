namespace SJCZZ8_FormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOrak = new System.Windows.Forms.Button();
            this.buttonTanarok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonOrak
            // 
            this.buttonOrak.Location = new System.Drawing.Point(21, 29);
            this.buttonOrak.Name = "buttonOrak";
            this.buttonOrak.Size = new System.Drawing.Size(75, 23);
            this.buttonOrak.TabIndex = 0;
            this.buttonOrak.Text = "Órák";
            this.buttonOrak.UseVisualStyleBackColor = true;
            this.buttonOrak.Click += new System.EventHandler(this.buttonOrak_Click);
            // 
            // buttonTanarok
            // 
            this.buttonTanarok.Location = new System.Drawing.Point(21, 78);
            this.buttonTanarok.Name = "buttonTanarok";
            this.buttonTanarok.Size = new System.Drawing.Size(75, 23);
            this.buttonTanarok.TabIndex = 1;
            this.buttonTanarok.Text = "Tanárok";
            this.buttonTanarok.UseVisualStyleBackColor = true;
            this.buttonTanarok.Click += new System.EventHandler(this.buttonTanarok_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(116, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 409);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTanarok);
            this.Controls.Add(this.buttonOrak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOrak;
        private Button buttonTanarok;
        private Panel panel1;
    }
}