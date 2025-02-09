using System;
using System.Windows.Forms;

namespace guess
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void again_Click(object sender, EventArgs e)
        {
            // Tworzymy nową instancję Form1 i pokazujemy ją
            Form1 form1 = new Form1();
            form1.Show();

            // Zamykamy bieżące okno
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            // Tworzymy nową instancję Form4 i pokazujemy ją
            Form4 form4 = new Form4();
            form4.Show();

            // Zamykamy bieżące okno
            this.Close();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            // Zamykamy aplikację
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
