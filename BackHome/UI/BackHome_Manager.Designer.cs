namespace BackHome
{
    partial class BackHome_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackHome_Manager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返乡登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回乡登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿舍留言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿管发布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.同学发布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我要发布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Manager_panel = new CCWin.SkinControl.SkinPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返乡登记ToolStripMenuItem,
            this.宿舍留言ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(8, 39);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(162, 545);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 返乡登记ToolStripMenuItem
            // 
            this.返乡登记ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请假登记ToolStripMenuItem,
            this.回乡登记ToolStripMenuItem});
            this.返乡登记ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.返乡登记ToolStripMenuItem.Name = "返乡登记ToolStripMenuItem";
            this.返乡登记ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.返乡登记ToolStripMenuItem.Size = new System.Drawing.Size(161, 35);
            this.返乡登记ToolStripMenuItem.Text = "学生离校情况";
            // 
            // 请假登记ToolStripMenuItem
            // 
            this.请假登记ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.请假登记ToolStripMenuItem.Name = "请假登记ToolStripMenuItem";
            this.请假登记ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.请假登记ToolStripMenuItem.Text = "学生请假记录";
            this.请假登记ToolStripMenuItem.Click += new System.EventHandler(this.AskforLeave_Manager_Click);
            // 
            // 回乡登记ToolStripMenuItem
            // 
            this.回乡登记ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.回乡登记ToolStripMenuItem.Name = "回乡登记ToolStripMenuItem";
            this.回乡登记ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.回乡登记ToolStripMenuItem.Text = "学生回乡记录";
            this.回乡登记ToolStripMenuItem.Click += new System.EventHandler(this.Register_manager_click);
            // 
            // 宿舍留言ToolStripMenuItem
            // 
            this.宿舍留言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宿管发布ToolStripMenuItem,
            this.同学发布ToolStripMenuItem,
            this.我要发布ToolStripMenuItem});
            this.宿舍留言ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.宿舍留言ToolStripMenuItem.Name = "宿舍留言ToolStripMenuItem";
            this.宿舍留言ToolStripMenuItem.Size = new System.Drawing.Size(161, 35);
            this.宿舍留言ToolStripMenuItem.Text = "宿舍公告";
            this.宿舍留言ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 宿管发布ToolStripMenuItem
            // 
            this.宿管发布ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.宿管发布ToolStripMenuItem.Name = "宿管发布ToolStripMenuItem";
            this.宿管发布ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.宿管发布ToolStripMenuItem.Text = "宿管发布";
            // 
            // 同学发布ToolStripMenuItem
            // 
            this.同学发布ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.同学发布ToolStripMenuItem.Name = "同学发布ToolStripMenuItem";
            this.同学发布ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.同学发布ToolStripMenuItem.Text = "同学发布";
            // 
            // 我要发布ToolStripMenuItem
            // 
            this.我要发布ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.我要发布ToolStripMenuItem.Name = "我要发布ToolStripMenuItem";
            this.我要发布ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.我要发布ToolStripMenuItem.Text = "我要发布";
            // 
            // Manager_panel
            // 
            this.Manager_panel.BackColor = System.Drawing.Color.Transparent;
            this.Manager_panel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Manager_panel.DownBack = null;
            this.Manager_panel.Location = new System.Drawing.Point(194, 59);
            this.Manager_panel.MouseBack = null;
            this.Manager_panel.Name = "Manager_panel";
            this.Manager_panel.NormlBack = null;
            this.Manager_panel.Size = new System.Drawing.Size(906, 479);
            this.Manager_panel.TabIndex = 2;
            // 
            // BackHome_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 592);
            this.Controls.Add(this.Manager_panel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackHome_Manager";
            this.Text = "学生宿舍管理系统";
            this.Load += new System.EventHandler(this.BackHome_Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返乡登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请假登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回乡登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿舍留言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿管发布ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 同学发布ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我要发布ToolStripMenuItem;
        private CCWin.SkinControl.SkinPanel Manager_panel;
    }
}