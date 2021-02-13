
namespace SeminarskiRadProjektovanjeSoftvera.Forms
{
    partial class GradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeForm));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbClassificationPeriod = new System.Windows.Forms.ComboBox();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dgvGradeStudent = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogIn.Location = new System.Drawing.Point(490, 410);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(108, 28);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Save grades";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cbClassificationPeriod);
            this.panel1.Controls.Add(this.lblSubjectName);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.dgvGradeStudent);
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 450);
            this.panel1.TabIndex = 1;
            // 
            // cbClassificationPeriod
            // 
            this.cbClassificationPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificationPeriod.FormattingEnabled = true;
            this.cbClassificationPeriod.Location = new System.Drawing.Point(472, 22);
            this.cbClassificationPeriod.Name = "cbClassificationPeriod";
            this.cbClassificationPeriod.Size = new System.Drawing.Size(126, 24);
            this.cbClassificationPeriod.TabIndex = 34;
            this.cbClassificationPeriod.SelectionChangeCommitted += new System.EventHandler(this.cbClassificationPeriod_SelectionChangeCommitted);
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSubjectName.Location = new System.Drawing.Point(237, 25);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(208, 16);
            this.lblSubjectName.TabIndex = 33;
            this.lblSubjectName.Text = "Choose classification period";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSubject.Location = new System.Drawing.Point(31, 25);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(65, 16);
            this.lblSubject.TabIndex = 32;
            this.lblSubject.Text = "Subject:";
            // 
            // dgvGradeStudent
            // 
            this.dgvGradeStudent.AllowUserToAddRows = false;
            this.dgvGradeStudent.AllowUserToDeleteRows = false;
            this.dgvGradeStudent.AllowUserToResizeColumns = false;
            this.dgvGradeStudent.AllowUserToResizeRows = false;
            this.dgvGradeStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGradeStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeStudent.Location = new System.Drawing.Point(34, 75);
            this.dgvGradeStudent.MultiSelect = false;
            this.dgvGradeStudent.Name = "dgvGradeStudent";
            this.dgvGradeStudent.RowHeadersWidth = 51;
            this.dgvGradeStudent.RowTemplate.Height = 24;
            this.dgvGradeStudent.Size = new System.Drawing.Size(564, 319);
            this.dgvGradeStudent.TabIndex = 30;
            this.dgvGradeStudent.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGradeStudent_CellValueChanged);
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GradeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvGradeStudent;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbClassificationPeriod;
        private System.Windows.Forms.Label lblSubjectName;
    }
}