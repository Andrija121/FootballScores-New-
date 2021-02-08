using System;
using System.Windows.Forms;

namespace FootballScores
{
    public partial class AddTeamForm : Form
    {
        private readonly FootballManagement _footballManagement;

        public AddTeamForm()
        {
            InitializeComponent();
            _footballManagement = new FootballManagement();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var result = _footballManagement.AddTeam(textBox1.Text);
                if (result)
                {
                    MessageBox.Show("Team " + textBox1.Text + " added", "New team added", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Team " + textBox1.Text + " already exists", "Error while adding team",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill out team name");
            }
        }
    }
}