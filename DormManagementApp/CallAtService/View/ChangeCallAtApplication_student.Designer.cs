namespace DormManagementApp2._0.View.CallAtService
{
    partial class ChangeCallAtApplication_student
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
            this.VisitorName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangeOK = new System.Windows.Forms.Button();
            this.ChangeCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VisitorName
            // 
            this.VisitorName.Location = new System.Drawing.Point(151, 40);
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.Size = new System.Drawing.Size(215, 25);
            this.VisitorName.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(151, 119);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(215, 25);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "来访者姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "来访时间";
            // 
            // Remarks
            // 
            this.Remarks.Location = new System.Drawing.Point(151, 229);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(215, 154);
            this.Remarks.TabIndex = 6;
            this.Remarks.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "备注";
            // 
            // ChangeOK
            // 
            this.ChangeOK.Location = new System.Drawing.Point(72, 441);
            this.ChangeOK.Name = "ChangeOK";
            this.ChangeOK.Size = new System.Drawing.Size(97, 34);
            this.ChangeOK.TabIndex = 8;
            this.ChangeOK.Text = "确定";
            this.ChangeOK.UseVisualStyleBackColor = true;
            this.ChangeOK.Click += new System.EventHandler(this.ChangeOK_Click);
            // 
            // ChangeCancle
            // 
            this.ChangeCancle.Location = new System.Drawing.Point(291, 441);
            this.ChangeCancle.Name = "ChangeCancle";
            this.ChangeCancle.Size = new System.Drawing.Size(97, 34);
            this.ChangeCancle.TabIndex = 9;
            this.ChangeCancle.Text = "取消";
            this.ChangeCancle.UseVisualStyleBackColor = true;
            this.ChangeCancle.Click += new System.EventHandler(this.ChangeCancle_Click);
            // 
            // ChangeCallAtApplication_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 514);
            this.Controls.Add(this.ChangeCancle);
            this.Controls.Add(this.ChangeOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Remarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.VisitorName);
            this.Name = "ChangeCallAtApplication_student";
            this.Text = "修改来访申请";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VisitorName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Remarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangeOK;
        private System.Windows.Forms.Button ChangeCancle;
    }
}