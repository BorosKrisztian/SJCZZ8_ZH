namespace SJCZZ8_FormsApp
{
    partial class UCTanarok
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
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oktatoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beosztásDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beosztásNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oktatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oktatokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(32, 44);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 73);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(32, 137);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 73);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oktatoIdDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.titulusDataGridViewTextBoxColumn,
            this.beosztásDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.beosztásNavigationDataGridViewTextBoxColumn,
            this.orakDataGridViewTextBoxColumn,
            this.statusNavigationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oktatokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(458, 348);
            this.dataGridView1.TabIndex = 2;
            // 
            // oktatoIdDataGridViewTextBoxColumn
            // 
            this.oktatoIdDataGridViewTextBoxColumn.DataPropertyName = "OktatoId";
            this.oktatoIdDataGridViewTextBoxColumn.HeaderText = "OktatoId";
            this.oktatoIdDataGridViewTextBoxColumn.Name = "oktatoIdDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // titulusDataGridViewTextBoxColumn
            // 
            this.titulusDataGridViewTextBoxColumn.DataPropertyName = "Titulus";
            this.titulusDataGridViewTextBoxColumn.HeaderText = "Titulus";
            this.titulusDataGridViewTextBoxColumn.Name = "titulusDataGridViewTextBoxColumn";
            // 
            // beosztásDataGridViewTextBoxColumn
            // 
            this.beosztásDataGridViewTextBoxColumn.DataPropertyName = "Beosztás";
            this.beosztásDataGridViewTextBoxColumn.HeaderText = "Beosztás";
            this.beosztásDataGridViewTextBoxColumn.Name = "beosztásDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // beosztásNavigationDataGridViewTextBoxColumn
            // 
            this.beosztásNavigationDataGridViewTextBoxColumn.DataPropertyName = "BeosztásNavigation";
            this.beosztásNavigationDataGridViewTextBoxColumn.HeaderText = "BeosztásNavigation";
            this.beosztásNavigationDataGridViewTextBoxColumn.Name = "beosztásNavigationDataGridViewTextBoxColumn";
            // 
            // orakDataGridViewTextBoxColumn
            // 
            this.orakDataGridViewTextBoxColumn.DataPropertyName = "Orak";
            this.orakDataGridViewTextBoxColumn.HeaderText = "Orak";
            this.orakDataGridViewTextBoxColumn.Name = "orakDataGridViewTextBoxColumn";
            this.orakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusNavigationDataGridViewTextBoxColumn
            // 
            this.statusNavigationDataGridViewTextBoxColumn.DataPropertyName = "StatusNavigation";
            this.statusNavigationDataGridViewTextBoxColumn.HeaderText = "StatusNavigation";
            this.statusNavigationDataGridViewTextBoxColumn.Name = "statusNavigationDataGridViewTextBoxColumn";
            // 
            // oktatokBindingSource
            // 
            this.oktatokBindingSource.DataSource = typeof(SJCZZ8_FormsApp.Models.Oktatok);
            // 
            // UCTanarok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Name = "UCTanarok";
            this.Size = new System.Drawing.Size(612, 413);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oktatokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAdd;
        private Button buttonRemove;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn oktatoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titulusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beosztásDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beosztásNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orakDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusNavigationDataGridViewTextBoxColumn;
        private BindingSource oktatokBindingSource;
    }
}
