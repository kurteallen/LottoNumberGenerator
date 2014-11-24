using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotteryNumbers.Controller;
using LotteryNumbers.View;

namespace LotteryNumbers
{
    public partial class LotteryForm : Form
    {

        private  int toFortyNine = 49;
        private  int toFortyFive = 45;
        private  int toNine = 9;
        private  int chooseSix = 6;
        private  int chooseFour = 4;
        private  int fromZero = 0;
        private  int fromOne = 1;
       

        public LotteryForm()
        {
            InitializeComponent();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
        
        private void lottoMaxBTN_Click(object sender, EventArgs e)
        {
            getNumbers("lottoMaxCanada", fromOne, toFortyNine, chooseSix, true);
            lotteryPicBox.Image = Properties.Resources.lottoMax_50x29;
            if (!encoreBTN.Visible)
                encoreBTN.Visible = true;
        }
        private void pick4BTN_Click(object sender, EventArgs e)
        {
            getNumbers("pick4Ontario", fromZero, toNine, chooseFour, false);
            lotteryPicBox.Image = Properties.Resources.Pick4_50x31;
            if (!encoreBTN.Visible)
                encoreBTN.Visible = true;

        }

        private void lottarioBTN_Click(object sender, EventArgs e)
        {
            getNumbers("lottario", fromOne, toFortyFive, chooseSix, true);
            lotteryPicBox.Image = Properties.Resources.lottario_51x29;
            if (!encoreBTN.Visible)
                encoreBTN.Visible = true;
        }

        private void lotto649BTN_Click(object sender, EventArgs e)
        {
            getNumbers("lotto649Canada", fromOne, toFortyNine, chooseSix, true);
            lotteryPicBox.Image = Properties.Resources.lotto649_51x29;
            if (!encoreBTN.Visible)
                encoreBTN.Visible = true;
            
        }

        private void getNumbers(String lotto, int min, int max, int choices, bool playEncore)
        {
            LotteryNumberController presenter = new LotteryNumberController(this);
            String LotteryNumbers = presenter.RetrieveNumbers(lotto, min, max, choices);
            if (LotteryNumbers != null)
                numberResult.Text = LotteryNumbers;

            else
             numberResult.Text = "Error, Try Again";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LotteryNumberController presenter = new LotteryNumberController(this);
            String encoreNumber = presenter.RetrieveNumbers();
            encoreLabel.Text = encoreNumber;

        }

    }
}