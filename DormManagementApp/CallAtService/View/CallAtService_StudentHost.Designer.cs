namespace DormManagementApp2._0.View.CallAtService
{
    partial class CallAtService_StudentHost
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
            this.AddApplication = new System.Windows.Forms.Button();
            this.ChangeApplication = new System.Windows.Forms.Button();
            this.DeleteApplication = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OverallView = new System.Windows.Forms.DataGridView();
            this.ItemsView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OverallView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddApplication
            // 
            this.AddApplication.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddApplication.Location = new System.Drawing.Point(55, 453);
            this.AddApplication.Name = "AddApplication";
            this.AddApplication.Size = new System.Drawing.Size(128, 46);
            this.AddApplication.TabIndex = 0;
            this.AddApplication.Text = "添加来访";
            this.AddApplication.UseVisualStyleBackColor = true;
            this.AddApplication.Click += new System.EventHandler(this.AddCallAtApplication_Click);
            // 
            // ChangeApplication
            // 
            this.ChangeApplication.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeApplication.Location = new System.Drawing.Point(314, 453);
            this.ChangeApplication.Name = "ChangeApplication";
            this.ChangeApplication.Size = new System.Drawing.Size(128, 46);
            this.ChangeApplication.TabIndex = 1;
            this.ChangeApplication.Text = "修改来访";
            this.ChangeApplication.UseVisualStyleBackColor = true;
            this.ChangeApplication.Click += new System.EventHandler(this.ChangeCallAtApplication_Click);
            // 
            // DeleteApplication
            // 
            this.DeleteApplication.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteApplication.Location = new System.Drawing.Point(567, 453);
            this.DeleteApplication.Name = "DeleteApplication";
            this.DeleteApplication.Size = new System.Drawing.Size(128, 46);
            this.DeleteApplication.TabIndex = 2;
            this.DeleteApplication.Text = "删除来访";
            this.DeleteApplication.UseVisualStyleBackColor = true;
            this.DeleteApplication.Click += new System.EventHandler(this.DeleteApplication_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(13, 98);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OverallView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ItemsView);
            this.splitContainer1.Size = new System.Drawing.Size(739, 332);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 3;
            // 
            // OverallView
            // 
            this.OverallView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OverallView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverallView.Location = new System.Drawing.Point(0, 0);
            this.OverallView.Name = "OverallView";
            this.OverallView.ReadOnly = true;
            this.OverallView.RowHeadersWidth = 51;
            this.OverallView.RowTemplate.Height = 27;
            this.OverallView.Size = new System.Drawing.Size(384, 332);
            this.OverallView.TabIndex = 0;
            // 
            // ItemsView
            // 
            this.ItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsView.Location = new System.Drawing.Point(0, 0);
            this.ItemsView.Name = "ItemsView";
            this.ItemsView.ReadOnly = true;
            this.ItemsView.RowHeadersWidth = 51;
            this.ItemsView.RowTemplate.Height = 27;
            this.ItemsView.Size = new System.Drawing.Size(351, 332);
            this.ItemsView.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 25);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(284, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CallAtService_StudentHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.DeleteApplication);
            this.Controls.Add(this.ChangeApplication);
            this.Controls.Add(this.AddApplication);
            this.Name = "CallAtService_StudentHost";
            this.Text = "来访申请";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OverallView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddApplication;
        private System.Windows.Forms.Button ChangeApplication;
        private System.Windows.Forms.Button DeleteApplication;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView OverallView;
        private System.Windows.Forms.DataGridView ItemsView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}