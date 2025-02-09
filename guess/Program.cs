using System;
using System.Windows.Forms;

namespace guess
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form2 form2 = new Form2();
            Application.Run(form2);

            if (form2.DialogResult == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.FormClosed += (s, args) =>
                {
                    // Po zamkniêciu Form1, uruchamiamy Form3
                    Form3 form3 = new Form3();
                    Application.Run(form3);
                };
                Application.Run(form1);
            }
        }
    }
}
