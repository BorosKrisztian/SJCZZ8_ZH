namespace SJCZZ8_FormsApp
{
    partial class UCOrak
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTantargy = new System.Windows.Forms.TextBox();
            this.listBoxTantargy = new System.Windows.Forms.ListBox();
            this.listBoxOra = new System.Windows.Forms.ListBox();
            this.listBoxOktato = new System.Windows.Forms.ListBox();
            this.textBoxOktato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTantargy
            // 
            this.textBoxTantargy.Location = new System.Drawing.Point(31, 51);
            this.textBoxTantargy.Name = "textBoxTantargy";
            this.textBoxTantargy.Size = new System.Drawing.Size(175, 23);
            this.textBoxTantargy.TabIndex = 0;
            this.textBoxTantargy.TextChanged += new System.EventHandler(this.textBoxTantargy_TextChanged);
            // 
            // listBoxTantargy
            // 
            this.listBoxTantargy.FormattingEnabled = true;
            this.listBoxTantargy.ItemHeight = 15;
            this.listBoxTantargy.Location = new System.Drawing.Point(31, 98);
            this.listBoxTantargy.Name = "listBoxTantargy";
            this.listBoxTantargy.Size = new System.Drawing.Size(175, 259);
            this.listBoxTantargy.TabIndex = 1;
            this.listBoxTantargy.SelectedIndexChanged += new System.EventHandler(this.listBoxTantargy_SelectedIndexChanged);
            // 
            // listBoxOra
            // 
            this.listBoxOra.FormattingEnabled = true;
            this.listBoxOra.ItemHeight = 15;
            this.listBoxOra.Location = new System.Drawing.Point(244, 98);
            this.listBoxOra.Name = "listBoxOra";
            this.listBoxOra.Size = new System.Drawing.Size(175, 259);
            this.listBoxOra.TabIndex = 2;
            // 
            // listBoxOktato
            // 
            this.listBoxOktato.FormattingEnabled = true;
            this.listBoxOktato.ItemHeight = 15;
            this.listBoxOktato.Location = new System.Drawing.Point(461, 98);
            this.listBoxOktato.Name = "listBoxOktato";
            this.listBoxOktato.Size = new System.Drawing.Size(175, 259);
            this.listBoxOktato.TabIndex = 3;
            this.listBoxOktato.SelectedIndexChanged += new System.EventHandler(this.listBoxOktato_SelectedIndexChanged);
            // 
            // textBoxOktato
            // 
            this.textBoxOktato.Location = new System.Drawing.Point(461, 51);
            this.textBoxOktato.Name = "textBoxOktato";
            this.textBoxOktato.Size = new System.Drawing.Size(175, 23);
            this.textBoxOktato.TabIndex = 4;
            this.textBoxOktato.TextChanged += new System.EventHandler(this.textBoxOktato_TextChanged);
            // 
            // UCOrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.textBoxOktato);
            this.Controls.Add(this.listBoxOktato);
            this.Controls.Add(this.listBoxOra);
            this.Controls.Add(this.listBoxTantargy);
            this.Controls.Add(this.textBoxTantargy);
            this.Name = "UCOrak";
            this.Size = new System.Drawing.Size(676, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxTantargy;
        private ListBox listBoxTantargy;
        private ListBox listBoxOra;
        private ListBox listBoxOktato;
        private TextBox textBoxOktato;
    }
}
