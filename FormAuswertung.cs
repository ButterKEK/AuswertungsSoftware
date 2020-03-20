using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuswertungsSoftware
{
    public partial class FrmAuswertung : Form
    {
        int scoreTeamA = 0;
        int scoreTeamB = 0;
        int scoreTeamC = 0;
        int scoreTeamD = 0;

        int previousScoreTeamA = 0;
        int previousScoreTeamB = 0;
        int previousScoreTeamC = 0;
        int previousScoreTeamD = 0;


        /* Methods */

        private void printScores()
        {
            lblTeamAScore.Text = "Team A: " + scoreTeamA;
            lblTeamBScore.Text = "Team B: " + scoreTeamB;
            lblTeamCScore.Text = "Team C: " + scoreTeamC;
            lblTeamDScore.Text = "Team D: " + scoreTeamD;
        }


        public FrmAuswertung()
        {
            InitializeComponent();
            printScores();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntFullscreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnTeamAPlus_Click(object sender, EventArgs e)
        {
            scoreTeamA++;

            printScores();
        }

        private void btnTeamAMinus_Click(object sender, EventArgs e)
        {
            scoreTeamA--;

            if (scoreTeamA < 0)
            {
                scoreTeamA = 0;
            }

            printScores();
        }


        private void btnTeamBPlus_Click(object sender, EventArgs e)
        {
            scoreTeamB++;

            printScores();
        }

        private void btnTeamBMinus_Click(object sender, EventArgs e)
        {
            scoreTeamB--;

            if (scoreTeamB < 0)
            {
                scoreTeamB = 0;
            }

            printScores();
        }


        private void btnTeamCPlus_Click(object sender, EventArgs e)
        {
            scoreTeamC++;

            printScores();
        }

        private void btnTeamCMinus_Click(object sender, EventArgs e)
        {
            scoreTeamC--;

            if (scoreTeamC < 0)
            {
                scoreTeamC = 0;
            }

            printScores();
        }


        private void btnTeamDPlus_Click(object sender, EventArgs e)
        {
            scoreTeamD++;

            printScores();
        }

        private void btnTeamDMinus_Click(object sender, EventArgs e)
        {
            scoreTeamD--;

            if (scoreTeamD < 0)
            {
                scoreTeamD = 0;
            }

            printScores();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            /* Saving the Values */
            previousScoreTeamA = scoreTeamA;
            previousScoreTeamB = scoreTeamB;
            previousScoreTeamC = scoreTeamC;
            previousScoreTeamD = scoreTeamD;

            /* Actually reseting them */
            scoreTeamA = 0;
            scoreTeamB = 0;
            scoreTeamC = 0;
            scoreTeamD = 0;

            printScores();
        }

        private void btnRestorePrevious_Click(object sender, EventArgs e)
        {
            scoreTeamA = previousScoreTeamA;
            scoreTeamB = previousScoreTeamB;
            scoreTeamC = previousScoreTeamC;
            scoreTeamD = previousScoreTeamD;

            printScores();
        }

    }
}
