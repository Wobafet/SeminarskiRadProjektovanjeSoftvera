
namespace SeminarskiRadProjektovanjeSoftvera.Dialogs
{
    partial class StudentUpdateMiniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentUpdateMiniForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.ucFirstName = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCTextBox();
            this.ucLastName = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCTextBox();
            this.ucSchoolClass = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.ucSchoolClass);
            this.panel2.Controls.Add(this.ucLastName);
            this.panel2.Controls.Add(this.ucFirstName);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 282);
            this.panel2.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(275, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 33);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucFirstName
            // 
            this.ucFirstName.Location = new System.Drawing.Point(9, 50);
            this.ucFirstName.Name = "ucFirstName";
            this.ucFirstName.Size = new System.Drawing.Size(441, 43);
            this.ucFirstName.TabIndex = 35;
            // 
            // ucLastName
            // 
            this.ucLastName.Location = new System.Drawing.Point(9, 109);
            this.ucLastName.Name = "ucLastName";
            this.ucLastName.Size = new System.Drawing.Size(441, 43);
            this.ucLastName.TabIndex = 36;
            // 
            // ucSchoolClass
            // 
            this.ucSchoolClass.Location = new System.Drawing.Point(9, 174);
            this.ucSchoolClass.Name = "ucSchoolClass";
            this.ucSchoolClass.Size = new System.Drawing.Size(441, 49);
            this.ucSchoolClass.TabIndex = 37;
            // 
            // StudentUpdateMiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 282);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentUpdateMiniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentUpdateMiniForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private UserControls.UCComboBox ucSchoolClass;
        private UserControls.UCTextBox ucLastName;
        private UserControls.UCTextBox ucFirstName;
    }
}