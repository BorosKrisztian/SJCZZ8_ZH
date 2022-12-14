namespace SJCZZ8_FormsApp
{
    partial class RemoveOktato
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
            this.listBoxOktato = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOktato
            // 
            this.listBoxOktato.FormattingEnabled = true;
            this.listBoxOktato.ItemHeight = 15;
            this.listBoxOktato.Location = new System.Drawing.Point(30, 28);
            this.listBoxOktato.Name = "listBoxOktato";
            this.listBoxOktato.Size = new System.Drawing.Size(198, 289);
            this.listBoxOktato.TabIndex = 0;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(30, 352);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 57);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Eltávolítás";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // RemoveOktato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxOktato);
            this.Name = "RemoveOktato";
            this.Text = "RemoveOktato";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxOktato;
        private Button buttonRemove;
    }
}