using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using SJCZZ8_FormsApp.Models;

namespace SJCZZ8_FormsApp
{
    public partial class AddOktato : Form
    {
        TanulmanyiContext context = new TanulmanyiContext();
        public AddOktato()
        {
            InitializeComponent();

            comboBoxBeosztas.DataSource = context.Beosztasok.ToList();
            comboBoxBeosztas.DisplayMember = "Beosztasnev";
            comboBoxStatus.DataSource = context.Statusok.ToList();
            comboBoxStatus.DisplayMember = "Status";
        }

        private void textBoxNev_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[A-Za-z]{1,50} [A-Za-z]{1,50}$");
            if (!regex.IsMatch(textBoxNev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNev, "Szóközzel elválasztott vezeték és keresztnév kell!");
            }
        }

        private void textBoxNev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNev, string.Empty);
        }

        private void textBoxTitulus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitulus.Text) == true)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxTitulus, "Nem lehet üres!");
            }
        }

        private void textBoxTitulus_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxTitulus, string.Empty);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                if (MessageBox.Show("Biztosan hozzá akarja adni a rekordot?", "Hozzáadás", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
