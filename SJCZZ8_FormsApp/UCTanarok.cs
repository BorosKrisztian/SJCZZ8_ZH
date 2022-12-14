using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SJCZZ8_FormsApp.Models;

namespace SJCZZ8_FormsApp
{
    public partial class UCTanarok : UserControl
    {
        TanulmanyiContext context = new TanulmanyiContext();
        public UCTanarok()
        {
            InitializeComponent();
            oktatokBindingSource.DataSource = context.Oktatok.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddOktato addOktato = new AddOktato();
            if (addOktato.ShowDialog() == DialogResult.OK)
            {
                List < Oktatok > oktatok = context.Oktatok.ToList();

                Oktatok oktato = new Oktatok();
                oktato.OktatoId = oktatok.LastOrDefault().OktatoId + 1;
                oktato.Nev = addOktato.textBoxNev.Text;
                oktato.Titulus = addOktato.textBoxTitulus.Text;
                oktato.Beosztás = ((Beosztasok)addOktato.comboBoxBeosztas.SelectedItem).BeosztasId;
                oktato.Status = ((Statusok)addOktato.comboBoxStatus.SelectedItem).Skod;

                context.Add(oktato);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                oktatokBindingSource.DataSource = context.Oktatok.ToList();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveOktato removeOktato = new RemoveOktato();
            removeOktato.ShowDialog();

            oktatokBindingSource.DataSource = context.Oktatok.ToList();
        }
    }
}
