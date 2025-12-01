using System;
using System.Windows.Forms;
using HabitTrackerApp.Views;
using HabitTrackerCore.Models;
using HabitTrackerCore.Services;

namespace HabitTrackerApp
{
    public partial class MainForm : Form
    {
        private readonly IHabitManagementService _habitManagement;
        private readonly IHabitStatisticsService _habitStatistics;

        public MainForm(IHabitManagementService management, IHabitStatisticsService statistics)
        {
            InitializeComponent();
            _habitManagement = management;
            _habitStatistics = statistics;
            RefreshHabitList();
        }

        private void RefreshHabitList()
        {
            lstHabits.Items.Clear();

            foreach (var habit in _habitManagement.GetAll())
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
                    _habitManagement.AddHabit(form.HabitName);
                    RefreshHabitList();
                }
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (lstHabits.SelectedItem is Habit selectedHabit)
            {
                _habitManagement.CompleteHabit(selectedHabit);
                RefreshHabitList();
            }
            else
            {
                MessageBox.Show("Please select a habit to mark as completed.");
            }
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            var stats = _habitStatistics.GetStats();

            string message =
        $"Total Habits: {stats.total}\n" +
        $"Completed: {stats.completed}\n" +
        $"Pending: {stats.pending}\n" +
        $"Completion Rate: {stats.rate:F2}%";

            MessageBox.Show(message, "Habit Statistics");
        }

        private void btnResetAllHabits_Click(object sender, EventArgs e)
        {
            _habitManagement.ResetAllHabits();
            RefreshHabitList();
            MessageBox.Show("All habits have been reset!");
        }
    }
}
