using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace High_School_Simulator_Cs_Win64
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int done, stress, missing, fatigue = 0;
        int grade = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void work_btn_Click(object sender, EventArgs e)
        {
            done++;
            missing += 2;
            fatigue++;
            stress += 2;
            grade -= 2;
            updateLabel("Getting work done!");
            checkStatus();
        }

        private void updateLabel(string s)
        {
            done_label.Text = "Work done: " + done;
            stress_label.Text = "Stress: " + stress;
            missing_label.Text = "Assignments Missing: " + missing;
            fatigue_label.Text = "Fatigue: " + fatigue;
            grade_label.Text = "Grade: " + grade;
            status_label.Text = s;
        }

        private void cram_btn_Click(object sender, EventArgs e)
        {
            if(missing < 1)
            {
                status_label.Text = "You dont need to cram";
                checkStatus();
                return;
            }
            checkStatus();
            done += 2;
            fatigue += 10;
            missing--;
            grade += 3;
            stress += 10;
            updateLabel("Cramming lots of work");
            checkStatus();
        }

        private void cheat_btn_Click(object sender, EventArgs e)
        {
            int caught = rand.Next(101);
            if(caught <= 30)
            {
                status_label.Text = "You were expelled!";
                MessageBox.Show("You got caught cheating");
                MessageBox.Show("You lose");
                Application.Exit();
            } else
            {
                checkStatus();
                fatigue++;
                stress -= 5;
                missing -= 5;
                grade += 8;
                done += 6;
                updateLabel("Copying other's work...");
                checkStatus();
            }
        }

        private void sleep_btn_Click(object sender, EventArgs e)
        {
            if(fatigue < 1 || stress < 1)
            {
                updateLabel("There is no need to sleep");
                checkStatus();
                return;
            }
            missing += 3;
            grade -= 4;
            stress -= 8;
            fatigue -= 10;
            updateLabel("Sleeping the day away...");
            checkStatus();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            Form f = new AboutBox1();
            f.ShowDialog();
        }
        private void checkStatus()
        {
            if (fatigue < 0)
                fatigue = 0;
            if (stress < 0)
                stress = 0;
            if (missing < 0)
                missing = 0;
            if (grade < 0)
                grade = 0;
            if(fatigue > 150 || stress > 250 || missing >= 250)
            {
                status_label.Text = "You are too worn out!";
                MessageBox.Show("You lose");
                Application.Exit();
            }
            if(grade < 50)
            {
                status_label.Text = "You failed school!";
                MessageBox.Show("You lose");
                Application.Exit();
            }
        }
        private void math_btn_Click(object sender, EventArgs e)
        {
            string message = "This will now factor a number. The program will show you each factor as it is found.";
            string title = "Information";
            MessageBox.Show(message, title);
            int num = 2147483646;
            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    MessageBox.Show("Found Factor: " + i);
                }
            }
            MessageBox.Show("Finished factoring!");
        }
    }
}
