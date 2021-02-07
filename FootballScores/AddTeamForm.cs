using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballScores
{
    public partial class AddTeamForm : Form
    {
        private FootballManagement ft;
        private List<FootballManagement> footballManagements;
        public AddTeamForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FootballManagement football = ft.GetName(textBox1.Text);
            if(textBox1.Text!="")
            {
                footballManagements.Add(football);
            }
            MessageBox.Show("Fill out team name");
        }
    }
}
