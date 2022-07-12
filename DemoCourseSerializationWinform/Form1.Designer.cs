namespace DemoCourseSerializationWinform
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CourseId = new System.Windows.Forms.TextBox();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.txt_CourseFees = new System.Windows.Forms.TextBox();
            this.btn_BinaryWrite = new System.Windows.Forms.Button();
            this.btn_XmlWrite = new System.Windows.Forms.Button();
            this.btn_SoapWrite = new System.Windows.Forms.Button();
            this.btn_JsonWrite = new System.Windows.Forms.Button();
            this.btn_JsonRead = new System.Windows.Forms.Button();
            this.btn_SoapRead = new System.Windows.Forms.Button();
            this.btn_XmlRead = new System.Windows.Forms.Button();
            this.btn_BinaryRead = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Fees";
            // 
            // txt_CourseId
            // 
            this.txt_CourseId.Location = new System.Drawing.Point(131, 30);
            this.txt_CourseId.Name = "txt_CourseId";
            this.txt_CourseId.Size = new System.Drawing.Size(151, 20);
            this.txt_CourseId.TabIndex = 3;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Location = new System.Drawing.Point(131, 66);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Size = new System.Drawing.Size(151, 20);
            this.txt_CourseName.TabIndex = 4;
            // 
            // txt_CourseFees
            // 
            this.txt_CourseFees.Location = new System.Drawing.Point(131, 99);
            this.txt_CourseFees.Name = "txt_CourseFees";
            this.txt_CourseFees.Size = new System.Drawing.Size(151, 20);
            this.txt_CourseFees.TabIndex = 5;
            // 
            // btn_BinaryWrite
            // 
            this.btn_BinaryWrite.Location = new System.Drawing.Point(70, 197);
            this.btn_BinaryWrite.Name = "btn_BinaryWrite";
            this.btn_BinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btn_BinaryWrite.TabIndex = 6;
            this.btn_BinaryWrite.Text = "Binary Write";
            this.btn_BinaryWrite.UseVisualStyleBackColor = true;
            this.btn_BinaryWrite.Click += new System.EventHandler(this.btn_BinaryWrite_Click);
            // 
            // btn_XmlWrite
            // 
            this.btn_XmlWrite.Location = new System.Drawing.Point(70, 238);
            this.btn_XmlWrite.Name = "btn_XmlWrite";
            this.btn_XmlWrite.Size = new System.Drawing.Size(75, 23);
            this.btn_XmlWrite.TabIndex = 7;
            this.btn_XmlWrite.Text = "XML Write";
            this.btn_XmlWrite.UseVisualStyleBackColor = true;
            this.btn_XmlWrite.Click += new System.EventHandler(this.btn_XmlWrite_Click);
            // 
            // btn_SoapWrite
            // 
            this.btn_SoapWrite.Location = new System.Drawing.Point(70, 280);
            this.btn_SoapWrite.Name = "btn_SoapWrite";
            this.btn_SoapWrite.Size = new System.Drawing.Size(75, 23);
            this.btn_SoapWrite.TabIndex = 8;
            this.btn_SoapWrite.Text = "SOAP Write";
            this.btn_SoapWrite.UseVisualStyleBackColor = true;
            this.btn_SoapWrite.Click += new System.EventHandler(this.btn_SoapWrite_Click);
            // 
            // btn_JsonWrite
            // 
            this.btn_JsonWrite.Location = new System.Drawing.Point(70, 322);
            this.btn_JsonWrite.Name = "btn_JsonWrite";
            this.btn_JsonWrite.Size = new System.Drawing.Size(75, 23);
            this.btn_JsonWrite.TabIndex = 9;
            this.btn_JsonWrite.Text = "JSON Write";
            this.btn_JsonWrite.UseVisualStyleBackColor = true;
            this.btn_JsonWrite.Click += new System.EventHandler(this.btn_JsonWrite_Click);
            // 
            // btn_JsonRead
            // 
            this.btn_JsonRead.Location = new System.Drawing.Point(163, 322);
            this.btn_JsonRead.Name = "btn_JsonRead";
            this.btn_JsonRead.Size = new System.Drawing.Size(75, 23);
            this.btn_JsonRead.TabIndex = 13;
            this.btn_JsonRead.Text = "JSON Read";
            this.btn_JsonRead.UseVisualStyleBackColor = true;
            this.btn_JsonRead.Click += new System.EventHandler(this.btn_JsonRead_Click);
            // 
            // btn_SoapRead
            // 
            this.btn_SoapRead.Location = new System.Drawing.Point(163, 280);
            this.btn_SoapRead.Name = "btn_SoapRead";
            this.btn_SoapRead.Size = new System.Drawing.Size(75, 23);
            this.btn_SoapRead.TabIndex = 12;
            this.btn_SoapRead.Text = "SOAP Read";
            this.btn_SoapRead.UseVisualStyleBackColor = true;
            this.btn_SoapRead.Click += new System.EventHandler(this.btn_SoapRead_Click);
            // 
            // btn_XmlRead
            // 
            this.btn_XmlRead.Location = new System.Drawing.Point(163, 238);
            this.btn_XmlRead.Name = "btn_XmlRead";
            this.btn_XmlRead.Size = new System.Drawing.Size(75, 23);
            this.btn_XmlRead.TabIndex = 11;
            this.btn_XmlRead.Text = "XML Read";
            this.btn_XmlRead.UseVisualStyleBackColor = true;
            this.btn_XmlRead.Click += new System.EventHandler(this.btn_XmlRead_Click);
            // 
            // btn_BinaryRead
            // 
            this.btn_BinaryRead.Location = new System.Drawing.Point(163, 197);
            this.btn_BinaryRead.Name = "btn_BinaryRead";
            this.btn_BinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btn_BinaryRead.TabIndex = 10;
            this.btn_BinaryRead.Text = "Binary Read";
            this.btn_BinaryRead.UseVisualStyleBackColor = true;
            this.btn_BinaryRead.Click += new System.EventHandler(this.btn_BinaryRead_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(70, 143);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(168, 32);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 372);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_JsonRead);
            this.Controls.Add(this.btn_SoapRead);
            this.Controls.Add(this.btn_XmlRead);
            this.Controls.Add(this.btn_BinaryRead);
            this.Controls.Add(this.btn_JsonWrite);
            this.Controls.Add(this.btn_SoapWrite);
            this.Controls.Add(this.btn_XmlWrite);
            this.Controls.Add(this.btn_BinaryWrite);
            this.Controls.Add(this.txt_CourseFees);
            this.Controls.Add(this.txt_CourseName);
            this.Controls.Add(this.txt_CourseId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CourseId;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.TextBox txt_CourseFees;
        private System.Windows.Forms.Button btn_BinaryWrite;
        private System.Windows.Forms.Button btn_XmlWrite;
        private System.Windows.Forms.Button btn_SoapWrite;
        private System.Windows.Forms.Button btn_JsonWrite;
        private System.Windows.Forms.Button btn_JsonRead;
        private System.Windows.Forms.Button btn_SoapRead;
        private System.Windows.Forms.Button btn_XmlRead;
        private System.Windows.Forms.Button btn_BinaryRead;
        private System.Windows.Forms.Button btn_Clear;
    }
}

