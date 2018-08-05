namespace cop
{
    partial class RoutineCreatorPage
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
            this.RoutineTextArea = new System.Windows.Forms.RichTextBox();
            this.RoutineCalcButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EventComboBox = new System.Windows.Forms.ComboBox();
            this.EventLabel = new System.Windows.Forms.Label();
            this.ElementGroupLabel = new System.Windows.Forms.Label();
            this.ElementGroupComboBox = new System.Windows.Forms.ComboBox();
            this.SkillLabel = new System.Windows.Forms.Label();
            this.SkillComboBox = new System.Windows.Forms.ComboBox();
            this.AddSkillButton = new System.Windows.Forms.Button();
            this.DifficultyTextBox = new System.Windows.Forms.TextBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoutineTextArea
            // 
            this.RoutineTextArea.Location = new System.Drawing.Point(599, 35);
            this.RoutineTextArea.Name = "RoutineTextArea";
            this.RoutineTextArea.Size = new System.Drawing.Size(448, 195);
            this.RoutineTextArea.TabIndex = 0;
            this.RoutineTextArea.Text = "";
            this.RoutineTextArea.TextChanged += new System.EventHandler(this.RoutineTextArea_TextChanged);
            // 
            // RoutineCalcButton
            // 
            this.RoutineCalcButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoutineCalcButton.Location = new System.Drawing.Point(599, 236);
            this.RoutineCalcButton.Name = "RoutineCalcButton";
            this.RoutineCalcButton.Size = new System.Drawing.Size(146, 41);
            this.RoutineCalcButton.TabIndex = 1;
            this.RoutineCalcButton.Text = "Calc Routine";
            this.RoutineCalcButton.UseVisualStyleBackColor = true;
            this.RoutineCalcButton.Click += new System.EventHandler(this.RoutineCalcButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.DifficultyLabel);
            this.panel1.Controls.Add(this.DifficultyTextBox);
            this.panel1.Controls.Add(this.AddSkillButton);
            this.panel1.Controls.Add(this.SkillComboBox);
            this.panel1.Controls.Add(this.SkillLabel);
            this.panel1.Controls.Add(this.ElementGroupComboBox);
            this.panel1.Controls.Add(this.ElementGroupLabel);
            this.panel1.Controls.Add(this.EventLabel);
            this.panel1.Controls.Add(this.EventComboBox);
            this.panel1.Controls.Add(this.RoutineTextArea);
            this.panel1.Controls.Add(this.RoutineCalcButton);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 384);
            this.panel1.TabIndex = 2;
            // 
            // EventComboBox
            // 
            this.EventComboBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventComboBox.FormattingEnabled = true;
            this.EventComboBox.Location = new System.Drawing.Point(243, 32);
            this.EventComboBox.Name = "EventComboBox";
            this.EventComboBox.Size = new System.Drawing.Size(232, 45);
            this.EventComboBox.TabIndex = 2;
            this.EventComboBox.Text = "Select An Event";
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLabel.Location = new System.Drawing.Point(17, 35);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(92, 37);
            this.EventLabel.TabIndex = 3;
            this.EventLabel.Text = "Event:";
            // 
            // ElementGroupLabel
            // 
            this.ElementGroupLabel.AutoSize = true;
            this.ElementGroupLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementGroupLabel.Location = new System.Drawing.Point(17, 103);
            this.ElementGroupLabel.Name = "ElementGroupLabel";
            this.ElementGroupLabel.Size = new System.Drawing.Size(203, 37);
            this.ElementGroupLabel.TabIndex = 4;
            this.ElementGroupLabel.Text = "Element Group:";
            // 
            // ElementGroupComboBox
            // 
            this.ElementGroupComboBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementGroupComboBox.FormattingEnabled = true;
            this.ElementGroupComboBox.Location = new System.Drawing.Point(243, 103);
            this.ElementGroupComboBox.Name = "ElementGroupComboBox";
            this.ElementGroupComboBox.Size = new System.Drawing.Size(232, 45);
            this.ElementGroupComboBox.TabIndex = 5;
            this.ElementGroupComboBox.Text = "Select A Group";
            // 
            // SkillLabel
            // 
            this.SkillLabel.AutoSize = true;
            this.SkillLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillLabel.Location = new System.Drawing.Point(17, 175);
            this.SkillLabel.Name = "SkillLabel";
            this.SkillLabel.Size = new System.Drawing.Size(73, 37);
            this.SkillLabel.TabIndex = 6;
            this.SkillLabel.Text = "Skill:";
            // 
            // SkillComboBox
            // 
            this.SkillComboBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillComboBox.FormattingEnabled = true;
            this.SkillComboBox.Location = new System.Drawing.Point(243, 175);
            this.SkillComboBox.Name = "SkillComboBox";
            this.SkillComboBox.Size = new System.Drawing.Size(232, 45);
            this.SkillComboBox.TabIndex = 7;
            this.SkillComboBox.Text = "Select A Skill";
            // 
            // AddSkillButton
            // 
            this.AddSkillButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkillButton.Location = new System.Drawing.Point(350, 246);
            this.AddSkillButton.Name = "AddSkillButton";
            this.AddSkillButton.Size = new System.Drawing.Size(125, 41);
            this.AddSkillButton.TabIndex = 8;
            this.AddSkillButton.Text = "Add Skill";
            this.AddSkillButton.UseVisualStyleBackColor = true;
            // 
            // DifficultyTextBox
            // 
            this.DifficultyTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyTextBox.Location = new System.Drawing.Point(917, 243);
            this.DifficultyTextBox.Name = "DifficultyTextBox";
            this.DifficultyTextBox.Size = new System.Drawing.Size(130, 35);
            this.DifficultyTextBox.TabIndex = 9;
            this.DifficultyTextBox.Text = "0.0";
            this.DifficultyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLabel.Location = new System.Drawing.Point(815, 243);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(96, 29);
            this.DifficultyLabel.TabIndex = 10;
            this.DifficultyLabel.Text = "Difficulty: ";
            // 
            // RoutineCreatorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1162, 944);
            this.Controls.Add(this.panel1);
            this.Name = "RoutineCreatorPage";
            this.Text = "Routine Creator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RoutineTextArea;
        private System.Windows.Forms.Button RoutineCalcButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.TextBox DifficultyTextBox;
        private System.Windows.Forms.Button AddSkillButton;
        private System.Windows.Forms.ComboBox SkillComboBox;
        private System.Windows.Forms.Label SkillLabel;
        private System.Windows.Forms.ComboBox ElementGroupComboBox;
        private System.Windows.Forms.Label ElementGroupLabel;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.ComboBox EventComboBox;
    }
}

