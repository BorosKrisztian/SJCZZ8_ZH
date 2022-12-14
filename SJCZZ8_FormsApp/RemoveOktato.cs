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
    public partial class RemoveOktato : Form
    {
        TanulmanyiContext context = new TanulmanyiContext();
        public RemoveOktato()
        {
            InitializeComponent();

            listBoxOktato.DataSource = context.Oktatok.ToList();
            listBoxOktato.DisplayMember = "Nev";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni akarja a rekordot?", "Törlés", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var selectedoktato = (Oktatok)listBoxOktato.SelectedItem;

                var deloktato = (from x in context.Oktatok
                                 where x.OktatoId == selectedoktato.OktatoId
                                 select x).FirstOrDefault();

                context.Remove(deloktato);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                listBoxOktato.DataSource = context.Oktatok.ToList();
            } 
        }
    }
}
