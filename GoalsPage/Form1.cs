using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoalsPage
{
    public partial class Form1 : Form
    {
        private List<string> goals = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Workout App Goals";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string goal = goalTextBox.Text;
            if (!string.IsNullOrWhiteSpace(goal))
            {
                goals.Add(goal);
                goalTextBox.Clear();
                UpdateGoalsList();
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            int index = goalsList.SelectedIndex;
            if (index >= 0 && index < goals.Count)
            {
                goals[index] = "[Complete] " + goals[index];
                UpdateGoalsList();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = goalsList.SelectedIndex;
            if (index >= 0 && index < goals.Count)
            {
                goals.RemoveAt(index);
                UpdateGoalsList();
            }
        }

        private void UpdateGoalsList()
        {
            goalsList.Items.Clear();
            foreach (string goal in goals)
            {
                goalsList.Items.Add(goal);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go to home page
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int index = goalsList.SelectedIndex;
            if (index >= 0 && index < goals.Count)
            {
                //go to workout page
                //at goals[index];
            }
        }

        
    }
}
