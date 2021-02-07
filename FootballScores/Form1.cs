﻿using System;
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

    /* 
    - dodati team management
    - mogucnost da se unose nazivi timova 

    - prilikom unosa rezultata, korisnik moze da bira vec unete timove

        - kad se radi pretraga, korisnik moze da bira tim iz liste unetih timova*/
    public partial class Form1 : Form
    {
        private FootballTeam ft;
        public Form1()
        {
            InitializeComponent();
            ft = new FootballTeam();
        }

        private void btnAddMatchResult_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a = Convert.ToInt32(tbHomeScore.Text);
            int b = Convert.ToInt32(textBox1.Text);
            ft.AddMatch(comboBox1.Text, comboBox2.Text, a, b);
            foreach (var match in ft.GetMatches())
            {
                listBox1.Items.Add(match);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox4.Text != "")
                foreach (var match in ft.GetMatchesByTeam(comboBox3.Text))
                {
                    listBox1.Items.Add(match);
                }
            else
            {
                foreach (var match in ft.GetMatches())
                {
                    listBox1.Items.Add(match);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeamForm f2 = new AddTeamForm();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
    }
