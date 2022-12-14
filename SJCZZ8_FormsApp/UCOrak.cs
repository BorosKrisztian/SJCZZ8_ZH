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
    public partial class UCOrak : UserControl
    {
        TanulmanyiContext context = new TanulmanyiContext();

        public bool betoltott = false;
        public UCOrak()
        {
            InitializeComponent();

            listBoxTantargy.DataSource = context.Tantárgyak.ToList();
            listBoxTantargy.DisplayMember = "Tantárgynév";
            listBoxOktato.DataSource = context.Oktatok.ToList();
            listBoxOktato.DisplayMember = "Nev";

            betoltott = true;
        }

        private void textBoxTantargy_TextChanged(object sender, EventArgs e)
        {
            var tantargyak = from x in context.Tantárgyak.ToList()
                             where x.Tantárgynév.Contains(textBoxTantargy.Text)
                             select x;

            listBoxTantargy.DataSource = tantargyak.ToList();
        }

        private void textBoxOktato_TextChanged(object sender, EventArgs e)
        {
            var oktatok = from x in context.Oktatok.ToList()
                          where x.Nev.Contains(textBoxOktato.Text)
                          select x;

            listBoxOktato.DataSource = oktatok.ToList();
        }

        private void listBoxTantargy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (betoltott == true) { SavListazas(); };
        }

        private void SavListazas()
        {
            var selectedtantargy = (Tantárgyak)listBoxTantargy.SelectedItem;
            var selectedoktato = (Oktatok)listBoxOktato.SelectedItem;

            var orak = from x in context.Orak
                       where (x.Targy == selectedtantargy.Tkód && x.Tanar == selectedoktato.OktatoId)
                       select new
                       {
                           Sav = x.SavNavigation.Időpont,
                       };

            try
            {
                listBoxOra.DataSource = orak.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            listBoxOra.DisplayMember = "Sav";
        }

        private void listBoxOktato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (betoltott == true) { SavListazas(); };
        }
    }
}
