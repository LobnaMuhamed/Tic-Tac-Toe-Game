using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        enum enPlayer
        {
            Player1 = 1, Player2 = 2, Draw = 3
        }

        enPlayer CurrentPlayer = enPlayer.Player1;
        byte NumberOfTurns = 9;

        PictureBox GetBox(byte i, byte j)
        {
            Control control = tableGame.GetControlFromPosition(i, j);
            PictureBox pictureBox = control as PictureBox;
            return pictureBox;
        }

        void RestartGame()
        {
            for (byte i = 0; i < 3; i++)
            {
                for (byte j = 0; j < 3; j++)
                {
                    GetBox(i, j).Image = Resources.question_mark_96;
                    GetBox(i, j).Tag = "?";
                    GetBox(i, j).BackColor = Color.Transparent;
                }
            }
            CurrentPlayer = enPlayer.Player1;
            lblPlayer.Text = "Player 1";
            lblWinner.Text = "In Progress";
            NumberOfTurns = 9;

        }

        void UpdatesOfCheckWinner()
        {

            if (CheckWinner() != enPlayer.Draw)
            {
                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblWinner.Text = (CheckWinner() == enPlayer.Player1 ? "Player 2" : "Player 1");
                lblPlayer.Text = "Game Over";
            }
            if (CheckWinner() == enPlayer.Draw && NumberOfTurns == 0)
            {
                lblWinner.Text = "Draw";
                lblPlayer.Text = "Game Over";

            }
        }

        enPlayer CheckWinner()
        {
            for (byte i = 0; i < 3; i++)
            {
                if ((string)GetBox(i, 0).Tag != "?"
                    && GetBox(i, 0).Tag == GetBox(i, 1).Tag
                    && GetBox(i, 1).Tag == GetBox(i, 2).Tag)
                {
                    GetBox(i, 0).BackColor = Color.Chartreuse;
                    GetBox(i, 1).BackColor = Color.Chartreuse;
                    GetBox(i, 2).BackColor = Color.Chartreuse;
                    return CurrentPlayer;
                }
            }
            for (byte j = 0; j < 3; j++)
            {
                if ((string)GetBox(0, j).Tag != "?"
                    && GetBox(0, j).Tag == GetBox(1, j).Tag
                    && GetBox(1, j).Tag == GetBox(2, j).Tag)
                {
                    GetBox(0, j).BackColor = Color.Chartreuse;
                    GetBox(1, j).BackColor = Color.Chartreuse;
                    GetBox(2, j).BackColor = Color.Chartreuse;
                    return CurrentPlayer;
                }
            }
            if ((string)GetBox(0, 0).Tag != "?"
                    && GetBox(0, 0).Tag == GetBox(1, 1).Tag
                    && GetBox(1, 1).Tag == GetBox(2, 2).Tag)
            {
                GetBox(0, 0).BackColor = Color.Chartreuse;
                GetBox(1, 1).BackColor = Color.Chartreuse;
                GetBox(2, 2).BackColor = Color.Chartreuse;
                return CurrentPlayer;
            }

            if ((string)GetBox(0, 2).Tag != "?"
                               && GetBox(0, 2).Tag == GetBox(1, 1).Tag
                               && GetBox(1, 1).Tag == GetBox(2, 0).Tag)
            {
                GetBox(0, 2).BackColor = Color.Chartreuse;
                GetBox(1, 1).BackColor = Color.Chartreuse;
                GetBox(2, 0).BackColor = Color.Chartreuse;
                return CurrentPlayer;
            }
            return enPlayer.Draw;
        }


        private void BoxClick(object sender, EventArgs e)
        {

            if ((string)((PictureBox)sender).Tag != "?")
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckWinner() != enPlayer.Draw || (CheckWinner() == enPlayer.Draw && NumberOfTurns == 0))
            {
                MessageBox.Show("Restart Game", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentPlayer == enPlayer.Player1)
            {
                CurrentPlayer = enPlayer.Player2;
                ((PictureBox)sender).Image = Resources.X;
                ((PictureBox)sender).Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                CurrentPlayer = enPlayer.Player1;
                ((PictureBox)sender).Image = Resources.O;
                ((PictureBox)sender).Tag = "O";
                lblPlayer.Text = "Player 1";

            }
            NumberOfTurns--;
            UpdatesOfCheckWinner();


        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
