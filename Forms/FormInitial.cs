using JogoGourmetDotNet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace JogoGourmetDotNet.Forms
{
    public partial class FormInitial : Form
    {
        public Food pasta = new Food("Lasanha", "");
        public Food noPasta = new Food("Bolo de chocolate", "");
        private ListFoods foodsPasta = new();
        private ListFoods foodsNoPasta = new();
        private string? newDescription;
        private string? newQuality;
        private bool typeFood;
        public bool response = false;
        private int counter = 0;
        public FormInitial()
        {
            foodsPasta.GetFoods().Add(pasta);
            foodsNoPasta.GetFoods().Add(noPasta);
            InitializeComponent();
        }

        public void Init()
        {
            var initial = MessageBox.Show("Pense em um prato que gosta.", "Jogo Gourmet", MessageBoxButtons.OK);
            if (initial == DialogResult.OK)
            {
                Game();
            }
            else
            {
                Close();
            }
        }

        private void Game()
        {
            //var countPasta = foodsPasta.GetFoods().Count;

            DialogResult confirm = MessageBox.Show("O prato que você pensou é uma massa?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                PastaChoice();
            }
            else
            {
                NoPastaChoice();
            }

        }

        private void PastaChoice()
        {
            var pasta = foodsPasta.GetFoods();
            var countPasta = foodsPasta.GetFoods().Count;
            string confirmText;
            foreach (var item in pasta)
            {
                var quality = item.GetQuality();
                var description = item.GetDescription();
                int result;

                if (quality != "")
                {
                    confirmText = "O prato que você pensou é " + quality + " ? ";
                    result = Next(confirmText);
                }

                else
                {
                    confirmText = "O prato que você pensou é " + description + " ? ";
                    result = Next(confirmText);
                }

                if (result == 1)
                {
                    confirmText = "O prato que você pensou é " + description + " ? ";
                    result = Next(confirmText);
                    if (result == 0)
                    {
                        counter++;
                        continue;
                    }
                    else
                    {
                        Finish();
                    }
                }

                else if (result == 0)
                {
                    if (counter < countPasta)
                    {
                        counter++;
                        continue;
                    }
                }
            }

            Quit(true);
        }

        private void NoPastaChoice()
        {
            var noPasta = foodsNoPasta.GetFoods();
            var countNoPasta = foodsNoPasta.GetFoods().Count;
            string confirmText;
            foreach (var item in noPasta)
            {
                var quality = item.GetQuality();
                var description = item.GetDescription();
                int result;

                if (quality != "")
                {
                    confirmText = "O prato que você pensou é " + quality + " ? ";
                    result = Next(confirmText);
                }
                else
                {
                    confirmText = "O prato que você pensou é " + description + " ? ";
                    result = Next(confirmText);
                }

                if (result == 1)
                {
                    confirmText = "O prato que você pensou é " + description + " ? ";
                    result = Next(confirmText);
                    if (result == 0)
                    {
                        counter++;
                        continue;
                    }
                    else
                    {
                        Finish();
                    }

                }
                else
                {
                    if (counter < countNoPasta)
                    {
                        counter++;
                        continue;
                    }
                }
            }

            Quit(false);
        }

        public void Finish()
        {
            _ = MessageBox.Show("Acertei de novo", "Jogo Gourmet", MessageBoxButtons.OK);
            Init();
        }

        public static int Next(string confirmText)
        {
            DialogResult confirmPasta = MessageBox.Show(confirmText, "Confirm", MessageBoxButtons.YesNo);
            if (confirmPasta == DialogResult.No)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void Quit(bool foodType)
        {
            typeFood = foodType;
            buttonOkQuit2.Visible = true;
            buttonOkQuit1.Visible = true;
            buttonCancel.Visible = true;
            textBoxQuit1.Visible = true;
            textBoxQuit2.Visible = false;
            this.labelInitial.Text = "Qual prato você pensou?";
            this.ShowDialog();
        }

        public void AddFood(bool TypeFood, string newDescription, string newQuality)
        {
            if (TypeFood)
            {
                var newFoodPasta = new Food(newDescription, newQuality);
                foodsPasta.GetFoods().Add(newFoodPasta);
                this.Hide();
            }
            else
            {
                var newFoodNoPasta = new Food(newDescription, newQuality);
                foodsNoPasta.GetFoods().Add(newFoodNoPasta);
                this.Hide();
            }
            Init();
        }

        private void buttonOkQuit1_Click(object sender, EventArgs e)
        {
            var type = typeFood ? "Lasanha" : "Bolo de Chocolate";
            newDescription = textBoxQuit1.Text;
            buttonOkQuit1.Visible = false;
            buttonOkQuit2.Visible = true;
            textBoxQuit1.Visible = false;
            textBoxQuit2.Visible = true;
            this.labelInitial.Text = newDescription + " é ____ mas " + type + " não";
        }

        private void buttonOkQuit2_Click(object sender, EventArgs e)
        {
            newQuality = textBoxQuit2.Text;
            AddFood(typeFood, newDescription, newQuality);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
