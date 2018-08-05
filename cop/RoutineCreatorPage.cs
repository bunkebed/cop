﻿using System;
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
            var routine = new Routine(null, "Floor");
            
            routine.Skills.Add(cop.GetSkill("Front Full", "Floor"));
            routine.Skills.Add(cop.GetSkill("Front Full", "Floor"));

            RoutineTextArea.AppendText(routine.ToString());
        }
    }
}
