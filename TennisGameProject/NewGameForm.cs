using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisGameProject
{
    public partial class NewGameForm : Form
    {
        ScoreForm scoreForm;

        public NewGameForm(ScoreForm scoreForm)
        {
            InitializeComponent();
            this.scoreForm = scoreForm;
        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstPlayerName = firstPlayerNameTextBox.Text;
            string secondPlayerName = secondPlayerNameTextBox.Text;

            int firstPlayerPoints = (int) pointsFirstPlayerNumeric.Value;
            int secondPlayerPoints = (int) pointsSecondPlayerNumeric.Value;

            this.scoreForm.games.Add(
                (
                    firstPlayerName,
                    firstPlayerPoints
                ),
                (
                    secondPlayerName,
                    secondPlayerPoints
                )
            );

            this.scoreForm.UpdateRecentGames();

            if(!this.scoreForm.players.ContainsKey(firstPlayerName))
                this.scoreForm.players.Add(firstPlayerName, 0);

            if (!this.scoreForm.players.ContainsKey(secondPlayerName))
                this.scoreForm.players.Add(secondPlayerName, 0);

            this.scoreForm.players[firstPlayerName] += firstPlayerPoints;
            this.scoreForm.players[secondPlayerName] += secondPlayerPoints;

            this.scoreForm.UpdateRanking();

            this.Close();
        }

        private void BUGFIXINGTOO(object sender, EventArgs e)
        {

        }
    }
}
