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
using HabitTrackerCore.Models;
using HabitTrackerCore.Services;

namespace HabitTrackerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private HabitService _habitService = new HabitService();

        private void RefreshHabitList()
        {
            lstHabits.Items.Clear();

            foreach (var habit in _habitService.GetAll())
            {
                lstHabits.Items.Add(habit);
            }
        }


        private void btnAddHabit_Click(object sender, EventArgs e)
        {
            using (var form = new AddHabitForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _habitService.AddHabit(form.HabitName);
                    RefreshHabitList();
                }
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (lstHabits.SelectedItem is Habit selectedHabit)
            {
                _habitService.CompleteHabit(selectedHabit);
                RefreshHabitList();
            }
            else
            {
                MessageBox.Show("Please select a habit to mark as completed.");
            }

        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            var stats = _habitService.GetStats();

            string message =
                $"Total Habits: {stats.total}\n" +
                $"Completed: {stats.completed}\n" +
                $"Pending: {stats.pending}\n" +
                $"Completion Rate: {stats.rate:F2}%";

            MessageBox.Show(message, "Habit Statistics");
        }
    }
}
