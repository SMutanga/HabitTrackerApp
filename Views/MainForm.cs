using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HabitTrackerApp.Views;

namespace HabitTrackerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddHabit_Click(object sender, EventArgs e)
        {
            using (var form = new AddHabitForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    lstHabits.Items.Add(form.HabitName);
                }

            }
           
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {

        }
    }
}
