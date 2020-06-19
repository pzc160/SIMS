namespace DormManagementApp2._0.View.CallAtService
{
    partial class CallAtService_ManagerHost
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
            this.components = new System.ComponentModel.Container();
            this.CheckButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OverallView = new System.Windows.Forms.DataGridView();
            this.ItemsView = new System.Windows.Forms.DataGridView();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.SIDtextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SIDlabel = new System.Windows.Forms.Label();
            this.Roomlabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AllApplicationSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OverallView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllApplicationSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CheckButton.Location = new System.Drawing.Point(160, 462);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(129, 47);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "查看/修改";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Deletebutton.Location = new System.Drawing.Point(499, 462);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(129, 47);
            this.Deletebutton.TabIndex = 1;
            this.Deletebutton.Text = "删除申请";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(5, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 363);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OverallView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ItemsView);
            this.splitContainer1.Size = new System.Drawing.Size(791, 363);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
            // 
            // OverallView
            // 
            this.OverallView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OverallView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverallView.Location = new System.Drawing.Point(0, 0);
            this.OverallView.Name = "OverallView";
            this.OverallView.RowHeadersWidth = 51;
            this.OverallView.RowTemplate.Height = 27;
            this.OverallView.Size = new System.Drawing.Size(263, 363);
            this.OverallView.TabIndex = 0;
            // 
            // ItemsView
            // 
            this.ItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsView.Location = new System.Drawing.Point(0, 0);
            this.ItemsView.Name = "ItemsView";
            this.ItemsView.RowHeadersWidth = 51;
            this.ItemsView.RowTemplate.Height = 27;
            this.ItemsView.Size = new System.Drawing.Size(524, 363);
            this.ItemsView.TabIndex = 0;
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoomTextBox.Location = new System.Drawing.Point(13, 30);
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(149, 25);
            this.RoomTextBox.TabIndex = 3;
            // 
            // SIDtextBox
            // 
            this.SIDtextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SIDtextBox.Location = new System.Drawing.Point(241, 30);
            this.SIDtextBox.Name = "SIDtextBox";
            this.SIDtextBox.Size = new System.Drawing.Size(149, 25);
            this.SIDtextBox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(460, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 25);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // SIDlabel
            // 
            this.SIDlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SIDlabel.AutoSize = true;
            this.SIDlabel.Location = new System.Drawing.Point(398, 37);
            this.SIDlabel.Name = "SIDlabel";
            this.SIDlabel.Size = new System.Drawing.Size(37, 15);
            this.SIDlabel.TabIndex = 6;
            this.SIDlabel.Text = "学号";
            // 
            // Roomlabel
            // 
            this.Roomlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Roomlabel.AutoSize = true;
            this.Roomlabel.Location = new System.Drawing.Point(167, 37);
            this.Roomlabel.Name = "Roomlabel";
            this.Roomlabel.Size = new System.Drawing.Size(52, 15);
            this.Roomlabel.TabIndex = 7;
            this.Roomlabel.Text = "房间号";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(674, 30);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(95, 25);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "查询";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CallAtService_ManagerHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 522);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Roomlabel);
            this.Controls.Add(this.SIDlabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SIDtextBox);
            this.Controls.Add(this.RoomTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.CheckButton);
            this.Name = "CallAtService_ManagerHost";
            this.Text = "来访申请";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OverallView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllApplicationSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView OverallView;
        private System.Windows.Forms.DataGridView ItemsView;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.TextBox SIDtextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label SIDlabel;
        private System.Windows.Forms.Label Roomlabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.BindingSource AllApplicationSource;
    }
}