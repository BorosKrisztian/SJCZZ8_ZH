namespace SJCZZ8_FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonOrak_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UCOrak uCOrak = new UCOrak();
            panel1.Controls.Add(uCOrak);

            uCOrak.Dock = DockStyle.Fill;
        }

        private void buttonTanarok_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UCTanarok uCTanarok = new UCTanarok();
            panel1.Controls.Add(uCTanarok);

            uCTanarok.Dock = DockStyle.Fill;
        }
    }
}