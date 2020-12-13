using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectRustan
{
    public partial class Form1 : Form
    {
        PriorityQueue patientQueue = new PriorityQueue();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                errorLbl.Text = "Please enter a name.";
            }
            else if (priorityBox.Text == "")
            {
                errorLbl.Text = "Please enter a priority.";
            }
            else if (!Regex.Match(priorityBox.Text, "^[abcdABCD]$").Success)
            {
                errorLbl.Text = "Please enter a valid priority [A-D]";
            }
            else
            {
                patientQueue.Enqueue(nameBox.Text, priorityBox.Text);
                nameBox.Text = "";
                priorityBox.Text = "";
                errorLbl.Text = "";
                queueBox.Text = patientQueue.Print();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admitBtn_Click(object sender, EventArgs e)
        {
            patientQueue.Dequeue();
            queueBox.Text = patientQueue.Print();
        }
    }
}
