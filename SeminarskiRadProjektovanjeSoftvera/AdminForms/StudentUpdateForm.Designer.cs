
namespace SeminarskiRadProjektovanjeSoftvera.Forms
{
    partial class StudentUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentUpdateForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUpdateStudent = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.Button();
            this.cbSchoolClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dgvUpdateStudent);
            this.panel1.Controls.Add(this.Details);
            this.panel1.Controls.Add(this.cbSchoolClass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 479);
            this.panel1.TabIndex = 2;
            // 
            // dgvUpdateStudent
            // 
            this.dgvUpdateStudent.AllowUserToAddRows = false;
            this.dgvUpdateStudent.AllowUserToDeleteRows = false;
            this.dgvUpdateStudent.AllowUserToResizeColumns = false;
            this.dgvUpdateStudent.AllowUserToResizeRows = false;
            this.dgvUpdateStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpdateStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateStudent.Location = new System.Drawing.Point(25, 126);
            this.dgvUpdateStudent.MultiSelect = false;
            this.dgvUpdateStudent.Name = "dgvUpdateStudent";
            this.dgvUpdateStudent.RowHeadersWidth = 51;
            this.dgvUpdateStudent.RowTemplate.Height = 24;
            this.dgvUpdateStudent.Size = new System.Drawing.Size(361, 267);
            this.dgvUpdateStudent.TabIndex = 29;
            // 
            // Details
            // 
            this.Details.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Details.Location = new System.Drawing.Point(169, 416);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(217, 33);
            this.Details.TabIndex = 28;
            this.Details.Text = "Show details about student";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // cbSchoolClass
            // 
            this.cbSchoolClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSchoolClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchoolClass.FormattingEnabled = true;
            this.cbSchoolClass.Location = new System.Drawing.Point(197, 77);
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
            this.label2.Location = new System.Drawing.Point(22, 80);
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
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Update student";
            // 
            // StudentUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 479);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentUpdateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentUpdateForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUpdateStudent;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.ComboBox cbSchoolClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}