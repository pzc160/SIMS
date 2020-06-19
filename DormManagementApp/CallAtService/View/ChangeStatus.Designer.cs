namespace DormManagementApp2._0
{
    partial class ChangeStatus
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
            this.CheckOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CallAtApproved = new System.Windows.Forms.CheckBox();
            this.CallAtDenied = new System.Windows.Forms.CheckBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.TimeLable = new System.Windows.Forms.Label();
            this.RoomLable = new System.Windows.Forms.Label();
            this.RemarkLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckOK
            // 
            this.CheckOK.Location = new System.Drawing.Point(232, 511);
            this.CheckOK.Name = "CheckOK";
            this.CheckOK.Size = new System.Drawing.Size(146, 54);
            this.CheckOK.TabIndex = 0;
            this.CheckOK.Text = "确认";
            this.CheckOK.UseVisualStyleBackColor = true;
            this.CheckOK.Click += new System.EventHandler(this.CheckOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "来访者姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "来访时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "宿舍号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "反馈：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "备注：";
            // 
            // CallAtApproved
            // 
            this.CallAtApproved.AutoSize = true;
            this.CallAtApproved.Location = new System.Drawing.Point(210, 404);
            this.CallAtApproved.Name = "CallAtApproved";
            this.CallAtApproved.Size = new System.Drawing.Size(59, 19);
            this.CallAtApproved.TabIndex = 6;
            this.CallAtApproved.Text = "同意";
            this.CallAtApproved.UseVisualStyleBackColor = true;
            this.CallAtApproved.CheckedChanged += new System.EventHandler(this.CallAtApproved_CheckedChanged);
            // 
            // CallAtDenied
            // 
            this.CallAtDenied.AutoSize = true;
            this.CallAtDenied.Location = new System.Drawing.Point(384, 404);
            this.CallAtDenied.Name = "CallAtDenied";
            this.CallAtDenied.Size = new System.Drawing.Size(59, 19);
            this.CallAtDenied.TabIndex = 7;
            this.CallAtDenied.Text = "拒绝";
            this.CallAtDenied.UseVisualStyleBackColor = true;
            this.CallAtDenied.CheckedChanged += new System.EventHandler(this.CallAtDenied_CheckedChanged);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(207, 61);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(55, 15);
            this.NameLable.TabIndex = 8;
            this.NameLable.Text = "Alishy";
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.Location = new System.Drawing.Point(207, 139);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(87, 15);
            this.TimeLable.TabIndex = 9;
            this.TimeLable.Text = "6.18 15:00";
            // 
            // RoomLable
            // 
            this.RoomLable.AutoSize = true;
            this.RoomLable.Location = new System.Drawing.Point(207, 227);
            this.RoomLable.Name = "RoomLable";
            this.RoomLable.Size = new System.Drawing.Size(31, 15);
            this.RoomLable.TabIndex = 10;
            this.RoomLable.Text = "404";
            // 
            // RemarkLable
            // 
            this.RemarkLable.AutoSize = true;
            this.RemarkLable.Location = new System.Drawing.Point(207, 314);
            this.RemarkLable.Name = "RemarkLable";
            this.RemarkLable.Size = new System.Drawing.Size(87, 15);
            this.RemarkLable.TabIndex = 11;
            this.RemarkLable.Text = "**********";
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 593);
            this.Controls.Add(this.RemarkLable);
            this.Controls.Add(this.RoomLable);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.CallAtDenied);
            this.Controls.Add(this.CallAtApproved);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckOK);
            this.Name = "ChangeStatus";
            this.Text = "来访申请详情";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CallAtApproved;
        private System.Windows.Forms.CheckBox CallAtDenied;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Label RoomLable;
        private System.Windows.Forms.Label RemarkLable;
    }
}