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
        public RoutineCreatorPage()
        {
            InitializeComponent();
            cop = new CopReader();

            var events = cop.GetEvents();
            foreach(var evt in events)
            {
                this.EventComboBox.Items.Add(evt);
            }            
        }

        private void RoutineTextArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoutineCalcButton_Click(object sender, EventArgs e)
        {
            var skills = new List<string>();

            skills.Add("Front Full");
            skills.Add("Back Full");
            skills.Add("Wide Arm Press");

            var routine = cop.GetRoutine(skills, "Floor");

            RoutineTextArea.AppendText(routine.ToString());
        }

        readonly CopReader cop;

        private void EventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var groups = cop.GetGroupsByEvent(EventComboBox.SelectedItem.ToString());

            foreach(var group in groups)
            {
                this.ElementGroupComboBox.Items.Add(group);
            }
        }

        private void ElementGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
