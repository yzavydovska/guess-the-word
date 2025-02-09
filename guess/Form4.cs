using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess
{
    public partial class Form4 : Form
    {
        private List<string> words = new List<string>();
        private int currentAnimalIndex = 0;

        public Form4()
        {
            InitializeComponent();
            LoadAnimals("animals.txt");
            DisplayNextAnimalWithText();
        }

        private void LoadAnimals(string filePath)
        {
            if (File.Exists(filePath))
            {
                words = File.ReadAllLines(filePath).ToList();
            }
        }

        private void DisplayNextAnimalWithText()
        {
            if (currentAnimalIndex < words.Count)
            {
                string animal = words[currentAnimalIndex];
                label2.Text = "What does " + animal + " eat?";
                currentAnimalIndex++;
            }
            else
            {
                label2.Text = "No more animals";
                Application.Exit();
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apple_Click(object sender, EventArgs e)
        {
            CheckAnswer("apple");
        }

        private void carrot_Click(object sender, EventArgs e)
        {
            CheckAnswer("carrot");
        }

        private void honey_Click(object sender, EventArgs e)
        {
            CheckAnswer("honey");
        }

        private void fish_Click(object sender, EventArgs e)
        {
            CheckAnswer("fish");
        }

        private void bone_Click(object sender, EventArgs e)
        {
            CheckAnswer("bone");
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void CheckAnswer(string clickedItem)
        {
            string expectedAnswer = GetExpectedAnswer(words[currentAnimalIndex - 1]);

            if (clickedItem == expectedAnswer.ToLower())
            {
                MessageBox.Show("Correct!");
                // Ukrycie klikniętego obrazka
                PictureBox clickedPictureBox = (PictureBox)this.Controls.Find(clickedItem, true).FirstOrDefault();
                clickedPictureBox.Visible = false;
                DisplayNextAnimalWithText();
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
        }

        private string GetExpectedAnswer(string animal)
        {
            switch (animal.ToLower())
            {
                case "cat":
                    return "fish";
                case "bear":
                    return "honey";
                case "hedgehog":
                    return "apple";
                case "rabbit":
                    return "carrot";
                default:
                    return "bone"; 
            }
        }
    }
}
