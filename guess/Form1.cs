using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace guess
{
    public partial class Form1 : Form
    {
        public List<string> words = new List<string>();
        string newText;
        int i = 0;
        int remainingSeconds = 60;
        private int incorrectAttempts = 0;

        public Form1()
        {
            InitializeComponent();
            Setup("animals.txt");
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void KeylsPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (words[i].ToLower() == textBox1.Text.ToLower())
                {
                    // Resetujemy liczbê niepoprawnych prób
                    incorrectAttempts = 0;

                    if (i < words.Count - 1)
                    {
                        MessageBox.Show("Correct!", "Moo Says: ");
                        textBox1.Text = "";
                        i += 1;
                        newText = Scramble(words[i]);
                        SetColoredText(newText);
                        lblInfo.Text = "Words: " + (i + 1) + " of " + words.Count;
                        remainingSeconds = 60;
                        UpdateTimerLabel();
                    }
                    else
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                    }
                }
                else
                {
                    incorrectAttempts++;

                    if (incorrectAttempts >= 2)
                    {
                        MessageBox.Show("Incorrect! The correct answer is: " + words[i], "Moo Says: ");
                        textBox1.Text = "";
                        incorrectAttempts = 0; // Resetujemy liczbê niepoprawnych prób
                    }
                    else
                    {
                        MessageBox.Show("Incorrect!", "Moo Says: ");
                        textBox1.Text = "";
                    }
                }
                e.Handled = true;
            }
        }

        public void Setup(string filePath)
        {
            words = File.ReadLines(filePath).ToList();
            newText = Scramble(words[i]);
            SetColoredText(newText);
            lblInfo.Text = "Words: " + (i + 1) + " of " + words.Count;
            remainingSeconds = 60;
            UpdateTimerLabel();
        }

        private string Scramble(string text)
        {
            return new string(text.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }

        private void UpdateTimerLabel()
        {
            TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
            string displayTime = string.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
            label2.Text = displayTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            UpdateTimerLabel();
            if (remainingSeconds == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Czas siê skoñczy³!", "Koniec czasu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1.Enabled)
            {
                MessageBox.Show("Game over!", "End of the game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void hint_Click(object sender, EventArgs e)
        {
            if (words.Count > 0)
            {
                if (i < words.Count)
                {
                    MessageBox.Show("Hint: First letter of the word is '" + words[i][0] + "'", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No more words to guess!", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No words to guess!", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetColoredText(string text)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            foreach (char c in text)
            {
                richTextBox1.SelectionColor = GetRandomColor();
                richTextBox1.AppendText(c.ToString());
            }
        }

        private Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
