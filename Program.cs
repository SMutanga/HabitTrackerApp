using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HabitTrackerCore.Services;

namespace HabitTrackerApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IHabitManagementService habitManagement = new HabitService();
            IHabitStatisticsService habitStatistics = (HabitService)habitManagement;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(habitManagement, habitStatistics));


        }
    }
}
