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

namespace JogoGourmetDotNet.Forms
{
    public partial class FormInitial : Form
    {
        public Food pasta = new Food("Lasanha", "");
        public Food noPasta = new Food("Bolo de chocolate", "");
        private ListFoods foodsPasta = new();
        private ListFoods foodsNoPasta = new();
        public bool response = false;
        int contador = 0;
        public FormInitial()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            foodsPasta.GetFoods().Add(pasta);
            foodsNoPasta.GetFoods().Add(noPasta);


            this.labelInitial.Text = "Pense em um prato que gosta.";

        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Game();
        }
        private void Game()
        {
            var countPasta = foodsPasta.GetFoods().Count();
            var countNoPasta = foodsNoPasta.GetFoods().Count();
            DialogResult confirm = MessageBox.Show("O prato que você pensou é uma massa?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                contador = +1;
                var pasta = foodsPasta.GetFoods().First();
                var confirmText = "O prato que você pensou é " + pasta.GetDescription() + " ? ";
                var confirmPasta = MessageBox.Show(confirmText, "Confirm", MessageBoxButtons.YesNo);
                if (confirmPasta == DialogResult.Yes)
                {
                    Finish();
                }
                else if (confirmPasta == DialogResult.No)
                {
                    if (contador > countPasta)
                    {
                        Game();
                    }
                    else
                    {
                        Next(true);
                    }
                }
            }
            if (confirm == DialogResult.No)
            {
                contador = +1;
                var noPasta = foodsNoPasta.GetFoods().FirstOrDefault();
                var confirmText = "O prato que você pensou é " + noPasta.GetDescription() + " ? ";
                var confirmNoPasta = MessageBox.Show(confirmText, "Confirm", MessageBoxButtons.YesNo);
                if (confirmNoPasta == DialogResult.Yes)
                {
                    Finish();
                }
                else if (confirmNoPasta == DialogResult.No)
                {
                    if (contador > countPasta)
                    {
                        ButtonOk_Click();
                    }
                    else
                    {
                        Next(false);
                    }
                }
            }

        }

        public void Finish()
        {
            _ = MessageBox.Show("Acertei de novo", "Jogo Gourmet", MessageBoxButtons.OK);
            Init();
        }

        public void Next(bool typeFood)
        {
            FormQuit frmquit = new FormQuit(typeFood, pasta, noPasta);
            frmquit.ShowDialog();
        }

        public void AddFood(bool TypeFood, string newFood, string newCharacteristic)
        {
            FormQuit frmquit = new FormQuit();

            if (TypeFood)
            {
                var newFoodPasta = new Food(newFood, newCharacteristic);
                foodsPasta.GetFoods().Add(newFoodPasta);
                //frmquit.Hide();
            }
            else
            {
                var newFoodNoPasta = new Food(newFood, newCharacteristic);
                foodsPasta.GetFoods().Add(newFoodNoPasta);
                //frmquit.Hide();
            }

            Init();
        }


    }
}
