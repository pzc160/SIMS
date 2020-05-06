namespace Stu_Backhome_Info
{
    partial class Stu_backhome_info
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtReturn_date = new System.Windows.Forms.TextBox();
            this.txtDeparure_date = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Return_date = new System.Windows.Forms.Label();
            this.Deparure_date = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.Label();
            this.StuName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "返乡信息表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(470, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtReturn_date);
            this.splitContainer1.Panel2.Controls.Add(this.txtDeparure_date);
            this.splitContainer1.Panel2.Controls.Add(this.txtDestination);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.Return_date);
            this.splitContainer1.Panel2.Controls.Add(this.Deparure_date);
            this.splitContainer1.Panel2.Controls.Add(this.Destination);
            this.splitContainer1.Panel2.Controls.Add(this.StuName);
            this.splitContainer1.Panel2.Controls.Add(this.ID);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 432);
            this.splitContainer1.SplitterDistance = 573;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtReturn_date
            // 
            this.txtReturn_date.Location = new System.Drawing.Point(232, 315);
            this.txtReturn_date.Name = "txtReturn_date";
            this.txtReturn_date.Size = new System.Drawing.Size(151, 25);
            this.txtReturn_date.TabIndex = 9;
            // 
            // txtDeparure_date
            // 
            this.txtDeparure_date.Location = new System.Drawing.Point(232, 250);
            this.txtDeparure_date.Name = "txtDeparure_date";
            this.txtDeparure_date.Size = new System.Drawing.Size(151, 25);
            this.txtDeparure_date.TabIndex = 8;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(232, 189);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(151, 25);
            this.txtDestination.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(232, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 25);
            this.txtID.TabIndex = 5;
            // 
            // Return_date
            // 
            this.Return_date.AutoSize = true;
            this.Return_date.Location = new System.Drawing.Point(69, 325);
            this.Return_date.Name = "Return_date";
            this.Return_date.Size = new System.Drawing.Size(67, 15);
            this.Return_date.TabIndex = 4;
            this.Return_date.Text = "返校时间";
            // 
            // Deparure_date
            // 
            this.Deparure_date.AutoSize = true;
            this.Deparure_date.Location = new System.Drawing.Point(69, 260);
            this.Deparure_date.Name = "Deparure_date";
            this.Deparure_date.Size = new System.Drawing.Size(67, 15);
            this.Deparure_date.TabIndex = 3;
            this.Deparure_date.Text = "离校时间";
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Location = new System.Drawing.Point(69, 192);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(82, 15);
            this.Destination.TabIndex = 2;
            this.Destination.Text = "返乡目的地";
            // 
            // StuName
            // 
            this.StuName.AutoSize = true;
            this.StuName.Location = new System.Drawing.Point(69, 128);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(37, 15);
            this.StuName.TabIndex = 1;
            this.StuName.Text = "姓名";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(69, 57);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(37, 15);
            this.ID.TabIndex = 0;
            this.ID.Text = "学号";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(274, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(462, 467);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 34);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Stu_backhome_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 596);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Stu_backhome_info";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label StuName;
        private System.Windows.Forms.Label Return_date;
        private System.Windows.Forms.Label Deparure_date;
        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReturn_date;
        private System.Windows.Forms.TextBox txtDeparure_date;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
    }
}