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
            this.SuspendLayout();
            // 
            // RoutineTextArea
            // 
            this.RoutineTextArea.Location = new System.Drawing.Point(80, 29);
            this.RoutineTextArea.Name = "RoutineTextArea";
            this.RoutineTextArea.Size = new System.Drawing.Size(673, 319);
            this.RoutineTextArea.TabIndex = 0;
            this.RoutineTextArea.Text = "";
            this.RoutineTextArea.TextChanged += new System.EventHandler(this.RoutineTextArea_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 944);
            this.Controls.Add(this.RoutineTextArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RoutineTextArea;
    }
}

