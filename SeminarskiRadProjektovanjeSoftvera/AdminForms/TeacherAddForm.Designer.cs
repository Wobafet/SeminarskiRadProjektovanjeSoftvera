
namespace SeminarskiRadProjektovanjeSoftvera.Dialogs
{
    partial class TeacherAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAddForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucFirstName = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCTextBox();
            this.ucLastName = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCTextBox();
            this.ucEmail = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCTextBox();
            this.ucPassword = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCTextBox();
            this.ucSubject = new SeminarskiRadProjektovanjeSoftvera.UserControls.UCComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(320, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 33);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save teacher";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(187, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Add teacher";
            // 
            // ucFirstName
            // 
            this.ucFirstName.Location = new System.Drawing.Point(36, 75);
            this.ucFirstName.Name = "ucFirstName";
            this.ucFirstName.Size = new System.Drawing.Size(441, 43);
            this.ucFirstName.TabIndex = 31;
            // 
            // ucLastName
            // 
            this.ucLastName.Location = new System.Drawing.Point(36, 131);
            this.ucLastName.Name = "ucLastName";
            this.ucLastName.Size = new System.Drawing.Size(441, 43);
            this.ucLastName.TabIndex = 32;
            // 
            // ucEmail
            // 
            this.ucEmail.Location = new System.Drawing.Point(36, 186);
            this.ucEmail.Name = "ucEmail";
            this.ucEmail.Size = new System.Drawing.Size(441, 43);
            this.ucEmail.TabIndex = 33;
            // 
            // ucPassword
            // 
            this.ucPassword.Location = new System.Drawing.Point(36, 235);
            this.ucPassword.Name = "ucPassword";
            this.ucPassword.Size = new System.Drawing.Size(441, 43);
            this.ucPassword.TabIndex = 34;
            // 
            // ucSubject
            // 
            this.ucSubject.Location = new System.Drawing.Point(36, 293);
            this.ucSubject.Name = "ucSubject";
            this.ucSubject.Size = new System.Drawing.Size(441, 49);
            this.ucSubject.TabIndex = 35;
            // 
            // TeacherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 422);
            this.Controls.Add(this.ucSubject);
            this.Controls.Add(this.ucPassword);
            this.Controls.Add(this.ucEmail);
            this.Controls.Add(this.ucLastName);
            this.Controls.Add(this.ucFirstName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeacherForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherAddForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private UserControls.UCTextBox ucFirstName;
        private UserControls.UCTextBox ucLastName;
        private UserControls.UCTextBox ucEmail;
        private UserControls.UCTextBox ucPassword;
        private UserControls.UCComboBox ucSubject;
    }
}