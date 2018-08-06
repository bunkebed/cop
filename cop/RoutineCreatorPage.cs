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
        }

        private void RoutineTextArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoutineCalcButton_Click(object sender, EventArgs e)
        {
            var cop = new CopReader();
            var skills = new List<string>();

            skills.Add("Front Full");
            skills.Add("Back Full");
            skills.Add("Wide Arm Press");

            var routine = cop.GetRoutine(skills, "Floor");

            RoutineTextArea.AppendText(routine.ToString());
        }
    }
}
