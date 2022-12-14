namespace SJCZZ8_FormsApp
{
    partial class AddOktato
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
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxTitulus = new System.Windows.Forms.TextBox();
            this.comboBoxBeosztas = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(24, 35);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(177, 23);
            this.textBoxNev.TabIndex = 0;
            this.textBoxNev.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNev_Validating);
            this.textBoxNev.Validated += new System.EventHandler(this.textBoxNev_Validated);
            // 
            // textBoxTitulus
            // 
            this.textBoxTitulus.Location = new System.Drawing.Point(24, 101);
            this.textBoxTitulus.Name = "textBoxTitulus";
            this.textBoxTitulus.Size = new System.Drawing.Size(177, 23);
            this.textBoxTitulus.TabIndex = 1;
            this.textBoxTitulus.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTitulus_Validating);
            this.textBoxTitulus.Validated += new System.EventHandler(this.textBoxTitulus_Validated);
            // 
            // comboBoxBeosztas
            // 
            this.comboBoxBeosztas.FormattingEnabled = true;
            this.comboBoxBeosztas.Location = new System.Drawing.Point(24, 171);
            this.comboBoxBeosztas.Name = "comboBoxBeosztas";
            this.comboBoxBeosztas.Size = new System.Drawing.Size(177, 23);
            this.comboBoxBeosztas.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(24, 244);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(177, 23);
            this.comboBoxStatus.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(143, 399);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(231, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddOktato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 434);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxBeosztas);
            this.Controls.Add(this.textBoxTitulus);
            this.Controls.Add(this.textBoxNev);
            this.Name = "AddOktato";
            this.Text = "AddOktato";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonOK;
        private Button buttonCancel;
        public TextBox textBoxNev;
        public TextBox textBoxTitulus;
        public ComboBox comboBoxBeosztas;
        public ComboBox comboBoxStatus;
        private ErrorProvider errorProvider1;
    }
}