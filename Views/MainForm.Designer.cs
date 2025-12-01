namespace HabitTrackerApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstHabits = new System.Windows.Forms.ListBox();
            this.btnAddHabit = new System.Windows.Forms.Button();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.btnResetAllHabits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(262, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Habit Tracker";
            // 
            // lstHabits
            // 
            this.lstHabits.FormattingEnabled = true;
            this.lstHabits.Location = new System.Drawing.Point(26, 92);
            this.lstHabits.Name = "lstHabits";
            this.lstHabits.Size = new System.Drawing.Size(300, 290);
            this.lstHabits.TabIndex = 1;
            // 
            // btnAddHabit
            // 
            this.btnAddHabit.Location = new System.Drawing.Point(473, 104);
            this.btnAddHabit.Name = "btnAddHabit";
            this.btnAddHabit.Size = new System.Drawing.Size(107, 23);
            this.btnAddHabit.TabIndex = 2;
            this.btnAddHabit.Text = "Add Habit";
            this.btnAddHabit.UseVisualStyleBackColor = true;
            this.btnAddHabit.Click += new System.EventHandler(this.btnAddHabit_Click);
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Location = new System.Drawing.Point(473, 145);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(107, 23);
            this.btnMarkCompleted.TabIndex = 3;
            this.btnMarkCompleted.Text = "Mark Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = true;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // btnViewStats
            // 
            this.btnViewStats.Location = new System.Drawing.Point(473, 187);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(107, 23);
            this.btnViewStats.TabIndex = 4;
            this.btnViewStats.Text = "View Stats";
            this.btnViewStats.UseVisualStyleBackColor = true;
            this.btnViewStats.Click += new System.EventHandler(this.btnViewStats_Click);
            // 
            // btnResetAllHabits
            // 
            this.btnResetAllHabits.Location = new System.Drawing.Point(473, 279);
            this.btnResetAllHabits.Name = "btnResetAllHabits";
            this.btnResetAllHabits.Size = new System.Drawing.Size(107, 23);
            this.btnResetAllHabits.TabIndex = 5;
            this.btnResetAllHabits.Text = "Reset";
            this.btnResetAllHabits.UseVisualStyleBackColor = true;
            this.btnResetAllHabits.Click += new System.EventHandler(this.btnResetAllHabits_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnResetAllHabits);
            this.Controls.Add(this.btnViewStats);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.btnAddHabit);
            this.Controls.Add(this.lstHabits);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habit Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstHabits;
        private System.Windows.Forms.Button btnAddHabit;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Button btnResetAllHabits;
    }
}

