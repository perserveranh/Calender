namespace Calender
{
    partial class Ajob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmrFromHours = new System.Windows.Forms.NumericUpDown();
            this.nmrFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nmrToMinute = new System.Windows.Forms.NumericUpDown();
            this.nmrtoHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrtoHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cbbStatus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.ckbDone);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 32);
            this.panel1.TabIndex = 0;
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(4, 4);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(15, 14);
            this.ckbDone.TabIndex = 0;
            this.ckbDone.UseVisualStyleBackColor = true;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(27, 4);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(306, 20);
            this.txtJob.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmrToMinute);
            this.panel2.Controls.Add(this.nmrtoHours);
            this.panel2.Controls.Add(this.nmrFromMinute);
            this.panel2.Controls.Add(this.nmrFromHours);
            this.panel2.Location = new System.Drawing.Point(339, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 32);
            this.panel2.TabIndex = 2;
            // 
            // nmrFromHours
            // 
            this.nmrFromHours.Location = new System.Drawing.Point(3, 4);
            this.nmrFromHours.Name = "nmrFromHours";
            this.nmrFromHours.Size = new System.Drawing.Size(38, 20);
            this.nmrFromHours.TabIndex = 0;
            // 
            // nmrFromMinute
            // 
            this.nmrFromMinute.Location = new System.Drawing.Point(52, 4);
            this.nmrFromMinute.Name = "nmrFromMinute";
            this.nmrFromMinute.Size = new System.Drawing.Size(38, 20);
            this.nmrFromMinute.TabIndex = 1;
            // 
            // nmrToMinute
            // 
            this.nmrToMinute.Location = new System.Drawing.Point(176, 4);
            this.nmrToMinute.Name = "nmrToMinute";
            this.nmrToMinute.Size = new System.Drawing.Size(36, 20);
            this.nmrToMinute.TabIndex = 3;
            // 
            // nmrtoHours
            // 
            this.nmrtoHours.Location = new System.Drawing.Point(129, 4);
            this.nmrtoHours.Name = "nmrtoHours";
            this.nmrtoHours.Size = new System.Drawing.Size(34, 20);
            this.nmrtoHours.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đến";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(563, 4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(56, 21);
            this.cbbStatus.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(626, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(675, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(42, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Ajob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Ajob";
            this.Size = new System.Drawing.Size(736, 36);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrtoHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrToMinute;
        private System.Windows.Forms.NumericUpDown nmrtoHours;
        private System.Windows.Forms.NumericUpDown nmrFromMinute;
        private System.Windows.Forms.NumericUpDown nmrFromHours;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox ckbDone;
    }
}
