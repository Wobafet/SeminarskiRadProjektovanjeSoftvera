
namespace SeminarskiRadProjektovanjeSoftvera.Forms
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtbPeriodNumber = new System.Windows.Forms.TextBox();
            this.gbAbsent = new System.Windows.Forms.GroupBox();
            this.clbStudents = new System.Windows.Forms.CheckedListBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbAbsent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.txtbPeriodNumber);
            this.panel1.Controls.Add(this.gbAbsent);
            this.panel1.Controls.Add(this.lblClassName);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 450);
            this.panel1.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(208, 39);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(66, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtbPeriodNumber
            // 
            this.txtbPeriodNumber.Location = new System.Drawing.Point(137, 39);
            this.txtbPeriodNumber.Name = "txtbPeriodNumber";
            this.txtbPeriodNumber.Size = new System.Drawing.Size(49, 22);
            this.txtbPeriodNumber.TabIndex = 6;
            // 
            // gbAbsent
            // 
            this.gbAbsent.Controls.Add(this.clbStudents);
            this.gbAbsent.Location = new System.Drawing.Point(15, 83);
            this.gbAbsent.Name = "gbAbsent";
            this.gbAbsent.Size = new System.Drawing.Size(297, 319);
            this.gbAbsent.TabIndex = 5;
            this.gbAbsent.TabStop = false;
            this.gbAbsent.Text = "Check who is absent";
            // 
            // clbStudents
            // 
            this.clbStudents.FormattingEnabled = true;
            this.clbStudents.Location = new System.Drawing.Point(9, 21);
            this.clbStudents.Name = "clbStudents";
            this.clbStudents.Size = new System.Drawing.Size(282, 293);
            this.clbStudents.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(21, 42);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(94, 17);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Class number";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(208, 415);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAbsent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clbStudents;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtbPeriodNumber;
        private System.Windows.Forms.GroupBox gbAbsent;
    }
}