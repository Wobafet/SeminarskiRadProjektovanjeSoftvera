
namespace SeminarskiRadProjektovanjeSoftvera.Forms
{
    partial class TeacherChooseSchoolClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherChooseSchoolClassForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEvalution = new System.Windows.Forms.RadioButton();
            this.rbAttendanceRecord = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ucSchoolClass = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.ucSchoolClass);
            this.panel1.Controls.Add(this.rbEvalution);
            this.panel1.Controls.Add(this.rbAttendanceRecord);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 271);
            this.panel1.TabIndex = 0;
            // 
            // rbEvalution
            // 
            this.rbEvalution.AutoSize = true;
            this.rbEvalution.Location = new System.Drawing.Point(289, 153);
            this.rbEvalution.Name = "rbEvalution";
            this.rbEvalution.Size = new System.Drawing.Size(87, 21);
            this.rbEvalution.TabIndex = 36;
            this.rbEvalution.TabStop = true;
            this.rbEvalution.Text = "Evalution";
            this.rbEvalution.UseVisualStyleBackColor = true;
            // 
            // rbAttendanceRecord
            // 
            this.rbAttendanceRecord.AutoSize = true;
            this.rbAttendanceRecord.Location = new System.Drawing.Point(65, 153);
            this.rbAttendanceRecord.Name = "rbAttendanceRecord";
            this.rbAttendanceRecord.Size = new System.Drawing.Size(146, 21);
            this.rbAttendanceRecord.TabIndex = 35;
            this.rbAttendanceRecord.TabStop = true;
            this.rbAttendanceRecord.Text = "Attendance record";
            this.rbAttendanceRecord.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(337, 214);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 29);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ucSchoolClass
            // 
            this.ucSchoolClass.Location = new System.Drawing.Point(31, 55);
            this.ucSchoolClass.Name = "ucSchoolClass";
            this.ucSchoolClass.Size = new System.Drawing.Size(420, 49);
            this.ucSchoolClass.TabIndex = 37;
            // 
            // TeacherChooseSchoolClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherChooseSchoolClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose school class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherChooseSchoolClassForm_FormClosing);
            this.Load += new System.EventHandler(this.TeacherChooseSchoolClassForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbAttendanceRecord;
        private System.Windows.Forms.RadioButton rbEvalution;
        private UserControls.UCComboBox ucSchoolClass;
    }
}