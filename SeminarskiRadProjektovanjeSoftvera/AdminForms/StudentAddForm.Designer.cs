
namespace SeminarskiRadProjektovanjeSoftvera.Forms
{
    partial class StudentAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAddForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucSchoolClass = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCComboBox();
            this.ucLastName = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCTextBox();
            this.ucFirstName = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 329);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.ucSchoolClass);
            this.panel2.Controls.Add(this.ucLastName);
            this.panel2.Controls.Add(this.ucFirstName);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 329);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(277, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 33);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save student";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(168, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add student";
            // 
            // ucSchoolClass
            // 
            this.ucSchoolClass.Location = new System.Drawing.Point(10, 202);
            this.ucSchoolClass.Name = "ucSchoolClass";
            this.ucSchoolClass.Size = new System.Drawing.Size(441, 49);
            this.ucSchoolClass.TabIndex = 40;
            // 
            // ucLastName
            // 
            this.ucLastName.Location = new System.Drawing.Point(10, 137);
            this.ucLastName.Name = "ucLastName";
            this.ucLastName.Size = new System.Drawing.Size(441, 43);
            this.ucLastName.TabIndex = 39;
            // 
            // ucFirstName
            // 
            this.ucFirstName.Location = new System.Drawing.Point(10, 78);
            this.ucFirstName.Name = "ucFirstName";
            this.ucFirstName.Size = new System.Drawing.Size(441, 43);
            this.ucFirstName.TabIndex = 38;
            // 
            // StudentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 329);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentAddForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private UserControls.UCComboBox ucSchoolClass;
        private UserControls.UCTextBox ucLastName;
        private UserControls.UCTextBox ucFirstName;
    }
}