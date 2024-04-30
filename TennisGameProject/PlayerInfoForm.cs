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
    public partial class PlayerInfoForm : Form
    {
        private Dictionary<string, string> wins;
        private Dictionary<string, string> losses;
        private Dictionary<string, string> draws;

        private ScoreForm scoreForm;
        private string playerName;

        public PlayerInfoForm(ScoreForm scoreForm, string playerName, (Dictionary<string, string> wins, Dictionary<string, string> losses, Dictionary<string, string> draws) data)
        {
            InitializeComponent();

            this.scoreForm = scoreForm;
            this.playerName = playerName;

            this.wins = data.wins;
            this.losses = data.losses;
            this.draws = data.draws;

            this.playerNameLabel.Text = playerName;

            wins.ToList().ForEach(w =>
            {
                ListViewItem win = new ListViewItem();

                win.SubItems[0].Text = w.Key;
                win.SubItems.Add(w.Value);

                winsTable.Items.Add(win);
            });

            losses.ToList().ForEach(l =>
            {
                ListViewItem loss = new ListViewItem();

                loss.SubItems[0].Text = l.Key;
                loss.SubItems.Add(l.Value);

                lossesTable.Items.Add(loss);
            });

            draws.ToList().ForEach(d =>
            {
                ListViewItem draw = new ListViewItem();

                draw.SubItems[0].Text = d.Key;
                draw.SubItems.Add(d.Value);

                drawsTable.Items.Add(draw);
            });

            InitializeComponent();
        }

        private void playerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlayerInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
