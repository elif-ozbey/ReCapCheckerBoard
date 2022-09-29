using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCapDamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
            //button.Width = 50;
            //button.Height = 50;
            //button.Text = "My button"; //Bir butonun boyutlarini belirlemek icin
            //this.Controls.Add(button); //Bu butonun ekrana gelmesini saglar. This dedigi orma karsilik gelir
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //GetUpperBound(0) sifirinci boyutun (ilk boyut) en buyuk alabilecegi degeri dondurur
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();//ilk buton yeni bir butondur , ikinci buton da yeni bir butondur o nedenle yenilememiz gerekir
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Beige;
                    }
                    this.Controls.Add(buttons[i, j]);

                }
                top += 50;
                left = 0; //ikinci satira gectigimizde lefti tekrar sifirlamamiz gerektiginden birinci dongunun icinde tekrar lefti 0 yaptik
            }
        }
    }
}
