using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TennisGameProject
{
    public partial class ScoreForm : Form
    {
        public Dictionary<string, int> players = new Dictionary<string, int>();
        public Dictionary<(string, int), (string, int)> games = new Dictionary<(string, int), (string, int)>();

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void UpdateRecentGames()
        {
            latestGamesTable.Items.Clear();

            foreach (var game in games)
            {
                ListViewItem latestGamesView = new ListViewItem();

                string firstPlayerName = game.Key.Item1;
                string secondPlayerName = game.Value.Item1;

                int firstPlayerScore = game.Key.Item2;
                int secondPlayerScore = game.Value.Item2;

                string winnerName = firstPlayerScore > secondPlayerScore ? firstPlayerName : secondPlayerName;

                latestGamesView.SubItems[0].Text = firstPlayerName;
                latestGamesView.SubItems.Add(secondPlayerName);
                latestGamesView.SubItems.Add(firstPlayerScore != secondPlayerScore ? winnerName : "Draw");
                latestGamesView.SubItems.Add($"{firstPlayerScore} - {secondPlayerScore}");

                latestGamesTable.Items.Add(latestGamesView);
            }   
        }

        public void UpdateRanking()
        {
            rankingTable.Items.Clear();

            players.OrderByDescending(p => p.Value)
                   .ToList()
                   .ForEach(playerKeyPair =>
                   {
                       ListViewItem playerRanking = new ListViewItem();

                       playerRanking.SubItems[0].Text = playerKeyPair.Key;
                       playerRanking.SubItems.Add(playerKeyPair.Value.ToString());

                       rankingTable.Items.Add(playerRanking);
                   });
        }

        public (Dictionary<string, string> wins, Dictionary<string, string> losses, Dictionary<string, string> draws) LoadPlayerData(string playerName)
        {
            Dictionary<string, string> wins = new Dictionary<string, string>();
            Dictionary<string, string> losses = new Dictionary<string, string>();
            Dictionary<string, string> draws = new Dictionary<string, string>();

            games.Where(game => game.Key.Item1 == playerName)
                .Where(game => game.Key.Item2 > game.Value.Item2)
                .ToList()
                .ForEach(game =>
                {
                    wins.Add(game.Value.Item1, $"{game.Key.Item2} - {game.Value.Item2}");
                });

            games.Where(game => game.Key.Item1 == playerName)
                .Where(game => game.Key.Item2 < game.Value.Item2)
                .ToList()
                .ForEach(game =>
                {
                    losses.Add(game.Value.Item1, $"{game.Key.Item2} - {game.Value.Item2}");
                });

            games.Where(game => game.Key.Item1 == playerName)
                .Where(game => game.Key.Item2 == game.Value.Item2)
                .ToList()
                .ForEach(game =>
                {
                    draws.Add(game.Value.Item1, $"{game.Key.Item2} - {game.Value.Item2}");
                });

            // If second player is the victor

            games.Where(game => game.Value.Item1 == playerName)
                .Where(game => game.Value.Item2 > game.Key.Item2)
                .ToList()
                .ForEach(game =>
                {
                    wins.Add(game.Key.Item1, $"{game.Key.Item2} - {game.Value.Item2}");
                });

            games.Where(game => game.Value.Item1 == playerName)
                .Where(game => game.Value.Item2 < game.Key.Item2)
                .ToList()
                .ForEach(game =>
                {
                    losses.Add(game.Key.Item1, $"{game.Key.Item2} - {game.Value.Item2}");
                });

            games.Where(game => game.Value.Item1 == playerName)
                .Where(game => game.Value.Item2 == game.Key.Item2)
                .ToList()
                .ForEach(game =>
                {
                    draws.Add(game.Key.Item1, $"{game.Key.Item2} - {game.Value.Item2}");
                });

            return (wins, losses, draws);
        }

        private void addNewGameButton_Click(object sender, EventArgs e)
        {
            NewGameForm form = new NewGameForm(this);
            form.Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rankingTable.SelectedItems.Count == 0) return;

            ListViewItem selectedRow = this.rankingTable.SelectedItems[0];
            string playerName = selectedRow.SubItems[0].Text;

            PlayerInfoForm playerInfoForm = new PlayerInfoForm(
                this,
                playerName,
                LoadPlayerData(playerName)
            );

            playerInfoForm.ShowDialog();
        }

        private void FIXINGBUGS(object sender, EventArgs e)
        {

        }
    }
}
