using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwdGenerator
{
    public partial class GenPass : Form
    {
        public GenPass()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            string lettre = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random {};
            int j = Convert.ToInt32(nbCaracTxtBox.Text);
            string valeur = "";
            for (int i = 0; i < j; i++)
            {
                int nb = random.Next(62);
                valeur += lettre[nb];
            }
            pwdGenTxtBox.Text = valeur;
        }

        private void genLetterBtn_Click(object sender, EventArgs e)
        {
            string lettre = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random{};
            int j = Convert.ToInt32(nbCaracTxtBox.Text);
            string valeur = "";
            for (int i = 0; i < j; i++)
            {
                int nb = random.Next(26);
                valeur += lettre[nb];
            }
            pwdGenTxtBox.Text = valeur;
        }

        private void genNbBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random { };
            string valeur = "";
            int j = Convert.ToInt32(nbCaracTxtBox.Text);
            for (int i = 0; i < j; i++)
            {
                int nb = random.Next(10);
                valeur += nb;
            }
            pwdGenTxtBox.Text = valeur;
        }

        private void genLetterMinBtn_Click(object sender, EventArgs e)
        {
            string lettre = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random { };
            int j = Convert.ToInt32(nbCaracTxtBox.Text);
            string valeur = "";
            for (int i = 0; i < j; i++)
            {
                int nb = random.Next(26);
                valeur += lettre[nb];
            }
            pwdGenTxtBox.Text = valeur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pwdGenTxtBox.UseSystemPasswordChar =! pwdGenTxtBox.UseSystemPasswordChar ;
        }
    }
}
