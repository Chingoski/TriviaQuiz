using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaQuiz
{
    public partial class Joker : Form
    {
        public Joker()
        {
            InitializeComponent();
        }

        public void SetCategory(string category)
        {
            TriviaNewGame.CurrentCategory = category;
            this.Close();
        }
        private void BtnGeography_Click(object sender, EventArgs e)
        {
            SetCategory(btnGeography.Text);
        }

        private void BtnScience_Click(object sender, EventArgs e)
        {
            SetCategory(btnScience.Text);
        }

        private void BtnSport_Click(object sender, EventArgs e)
        {
            SetCategory(btnSport.Text+ "s");
        }

        private void BtnPopCulture_Click(object sender, EventArgs e)
        {
            SetCategory("PopCulture");
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            SetCategory("ComputerScience");
        }

        private void BtnGeography_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnGeography_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
