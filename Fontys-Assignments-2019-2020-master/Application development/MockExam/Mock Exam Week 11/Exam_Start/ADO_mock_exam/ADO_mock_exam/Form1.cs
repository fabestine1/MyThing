using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_mock_exam
{

    public partial class Form1 : Form
    {
        public enum roles
        {
            KING,
            KNIGHT,
            WITCH,
            WIZARD
        }
        public List<string> players = new List<string>();

        public List<roles> playerRoles = new List<roles>();

        public bool sorted;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            if (tbPlayerName.Text == String.Empty)
            {
                MessageBox.Show("Please enter the name!");
            }
            else if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter the role!");
            }
            else
            {
                var newPlayer = tbPlayerName.Text;
                var unique = true;
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i] == newPlayer)
                    {
                        MessageBox.Show("There already exists a player with this name");
                        unique = false;
                    }
                    else if (playerRoles[i] == roles.KING && cmbRole.SelectedIndex == 0)
                    {
                        MessageBox.Show("There already exists a king");
                        unique = false;
                    }
                }
                if (unique)
                {
                    players.Add(newPlayer);
                    playerRoles.Add((roles)cmbRole.SelectedIndex);
                }
            }
            UpdatePlayersOverview();
        }

        private void UpdatePlayersOverview()
        {
            lbPlayers.Items.Clear();
            for (int i = 0; i < players.Count; i++)
            {
                lbPlayers.Items.Add($"{players[i]}");
            }
        }

        private void btnSneakPeek_Click(object sender, EventArgs e)
        {
            if (tbKiller.Text == String.Empty)
            {
                MessageBox.Show("Please enter the name of the killer!");
            }
            else if (lbPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the victim!");
            }
            else
            {
                var killer = tbKiller.Text;
                var indexOfTheKiller = players.IndexOf(killer);
                var indexOfTheVictim = lbPlayers.SelectedIndex;

                if (indexOfTheKiller == -1)
                {
                    MessageBox.Show("There is no such player!");
                }
                else
                {
                    MessageBox.Show($"{players[indexOfTheKiller]} is a {playerRoles[indexOfTheKiller]}, {players[indexOfTheVictim]} is a {playerRoles[indexOfTheVictim]}");
                }

            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            if (tbKiller.Text == String.Empty)
            {
                MessageBox.Show("Please enter the name of the killer!");
            }
            else if (lbPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the victim!");
            }
            else
            {
                var killer = tbKiller.Text;
                var indexOfTheKiller = players.IndexOf(killer);
                var indexOfTheVictim = lbPlayers.SelectedIndex;

                if (indexOfTheKiller == -1)
                {
                    MessageBox.Show($"{tbKiller.Text} does not exist!");
                }
                else if (indexOfTheKiller == indexOfTheVictim)
                {
                    MessageBox.Show($"You cannot kill yourself!");
                }
                else
                {
                    if (playerRoles[indexOfTheKiller] == roles.WITCH)
                    {
                        players.RemoveAt(indexOfTheVictim);
                        playerRoles.RemoveAt(indexOfTheVictim);

                    }
                    else if (playerRoles[indexOfTheVictim] == roles.WITCH)
                    {
                        if (playerRoles[indexOfTheKiller] == roles.WIZARD)
                        {
                            players.RemoveAt(indexOfTheVictim);
                            playerRoles.RemoveAt(indexOfTheVictim);
                        }
                        else
                        {
                            players.RemoveAt(indexOfTheKiller);
                            playerRoles.RemoveAt(indexOfTheKiller);
                            MessageBox.Show("Oops, you died!");
                        }
                    }
                    else
                    {
                        players.RemoveAt(indexOfTheVictim);
                        playerRoles.RemoveAt(indexOfTheVictim);
                    }
                }
                UpdatePlayersOverview();



            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var cntKing = 0;
            var cntKnight = 0;
            var cntWitch = 0;
            var cntWizard = 0;

            for (int i = 0; i < playerRoles.Count; i++)
            {
                if (playerRoles[i] == roles.KING)
                {
                    cntKing++;
                }
                else if (playerRoles[i] == roles.KNIGHT)
                {
                    cntKnight++;
                }
                else if (playerRoles[i] == roles.WITCH)
                {
                    cntWitch++;
                }
                else if (playerRoles[i] == roles.WIZARD)
                {
                    cntWizard++;
                }
            }
            MessageBox.Show($"Kings: {cntKing}, Knights: {cntKnight}, Witches: {cntWitch}, Wizards: {cntWizard}");

            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

 