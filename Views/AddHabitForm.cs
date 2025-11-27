using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitTrackerApp.Views
{
    public partial class AddHabitForm : Form
    {
        public AddHabitForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public string HabitName
        {
            get { return txtHabitName.Text.Trim(); }
        }

    }
}
