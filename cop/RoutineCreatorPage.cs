using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cop
{
    public partial class RoutineCreatorPage : Form
    {
        #region Fields

        readonly CopReader cop;
        readonly Routine routine;

        #endregion

        /// <summary>
        /// Constructor for the Routine Creator Page
        /// </summary>
        public RoutineCreatorPage()
        {
            InitializeComponent();
            cop = new CopReader();
            routine = new Routine();

            InitializeEventComboBox();
        }

        /// <summary>
        /// Initialize the events in the event combo box
        /// </summary>
        private void InitializeEventComboBox()
        {
            var events = cop.GetEvents();
            foreach (var evt in events)
            {
                this.EventComboBox.Items.Add(evt);
            }
        }

        private void RoutineCalcButton_Click(object sender, EventArgs e)
        {
            DifficultyTextBox.ResetText();
            DifficultyTextBox.AppendText(routine.CalculateDifficulty() + "");
        }

        private void EventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElementGroupComboBox.Items.Clear();
            SkillComboBox.Items.Clear();

            // Modifying the routine
            routine.Skills.Clear();
            routine.Event = EventComboBox.SelectedItem.ToString();

            var groups = cop.GetGroupsByEvent(EventComboBox.SelectedItem.ToString());

            foreach(var group in groups)
            {
                this.ElementGroupComboBox.Items.Add(group);
            }

            UpdateRoutineTextArea();
        }

        private void ElementGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillComboBox.Items.Clear();

            var skills = cop.GetSkillsByGroup(
                EventComboBox.SelectedItem.ToString(),
                ElementGroupComboBox.SelectedItem.ToString());

            foreach (var skill in skills)
            {
                this.SkillComboBox.Items.Add(skill);
            }
        }

        /// <summary>
        /// Add a Skill to the current routine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            routine.Skills.Add((Skill)SkillComboBox.SelectedItem);
            UpdateRoutineTextArea();
        }

        private void RoutineTextArea_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Update the contents of the RoutineTextArea
        /// </summary>
        private void UpdateRoutineTextArea()
        {
            RoutineTextArea.Clear();
            RoutineTextArea.AppendText(routine.ToString());
        }
    }
}
