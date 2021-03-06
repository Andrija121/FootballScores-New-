﻿using System;
using System.Windows.Forms;

namespace FootballScores
{
    /* 
    - dodati team management
    - mogucnost da se unose nazivi timova 

    - prilikom unosa rezultata, korisnik moze da bira vec unete timove

        - kad se radi pretraga, korisnik moze da bira tim iz liste unetih timova*/
    public partial class Form1 : Form
    {
        private readonly FootballManagement footballManagement;
        private readonly FootballMatch ft;

        public Form1()
        {
            InitializeComponent();
            ft = new FootballMatch();
            footballManagement = new FootballManagement();
        }

        private void btnAddMatchResult_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var a = Convert.ToInt32(numericUpDown1.Value);           
            var b = Convert.ToInt32(numericUpDown2.Value);
            ft.AddMatch(comboBox1.Text, comboBox2.Text, a, b);
            foreach (var match in ft.GetMatches()) listBox1.Items.Add(match.GetInfo());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox3.Text != "")
                foreach (var match in ft.GetMatchesByTeam(comboBox3.Text))
                { 
                    listBox1.Items.Add(match.GetInfo());
                }
            else
                foreach (var match in ft.GetMatches())
                    listBox1.Items.Add(match.GetInfo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new AddTeamForm();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var teams = footballManagement.GetTeams();
            foreach (var team in teams)
            {
                comboBox1.Items.Add(team);
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            var teams = footballManagement.GetTeams();
            foreach (var team in teams)
            {
                comboBox2.Items.Add(team);
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            var teams = footballManagement.GetTeams();
            foreach (var team in teams)
            {
                comboBox3.Items.Add(team);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            { 
            ft.DeleteMatch(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            foreach (var match in ft.GetMatches())
                listBox1.Items.Add(match.GetInfo());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ft.ChangeScore(listBox1.SelectedIndex, Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value));
                listBox1.Items.Clear();
                foreach (var match in ft.GetMatches())
                    listBox1.Items.Add(match.GetInfo());
            }
        }
    }
}