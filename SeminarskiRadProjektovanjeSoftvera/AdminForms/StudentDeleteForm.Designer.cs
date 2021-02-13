
namespace SeminarskiRadProjektovanjeSoftvera.Forms
{
    partial class StudentDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDeleteForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDeleteStudent = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSchoolClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dgvDeleteStudent);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cbSchoolClass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 461);
            this.panel1.TabIndex = 1;
            // 
            // dgvDeleteStudent
            // 
            this.dgvDeleteStudent.AllowUserToAddRows = false;
            this.dgvDeleteStudent.AllowUserToDeleteRows = false;
            this.dgvDeleteStudent.AllowUserToResizeColumns = false;
            this.dgvDeleteStudent.AllowUserToResizeRows = false;
            this.dgvDeleteStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeleteStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteStudent.Location = new System.Drawing.Point(15, 152);
            this.dgvDeleteStudent.MultiSelect = false;
            this.dgvDeleteStudent.Name = "dgvDeleteStudent";
            this.dgvDeleteStudent.ReadOnly = true;
            this.dgvDeleteStudent.RowHeadersWidth = 51;
            this.dgvDeleteStudent.RowTemplate.Height = 24;
            this.dgvDeleteStudent.Size = new System.Drawing.Size(576, 267);
            this.dgvDeleteStudent.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(438, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 33);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbSchoolClass
            // 
            this.cbSchoolClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSchoolClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchoolClass.FormattingEnabled = true;
            this.cbSchoolClass.Location = new System.Drawing.Point(180, 114);
            this.cbSchoolClass.Name = "cbSchoolClass";
            this.cbSchoolClass.Size = new System.Drawing.Size(189, 24);
            this.cbSchoolClass.TabIndex = 27;
            this.cbSchoolClass.SelectionChangeCommitted += new System.EventHandler(this.cbSchoolClass_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Choose school class";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(228, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Delete student";
            // 
            // StudentDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentDeleteForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDeleteStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbSchoolClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}