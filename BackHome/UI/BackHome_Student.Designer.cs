namespace BackHome
{
    partial class BackHome_Student
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackHome_Student));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返乡登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回乡登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿舍留言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿管发布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.同学发布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我要发布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Student_panel = new System.Windows.Forms.Panel();
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
            this.menuStrip1.Size = new System.Drawing.Size(124, 449);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返乡登记ToolStripMenuItem
            // 
            this.返乡登记ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请假登记ToolStripMenuItem,
            this.回乡登记ToolStripMenuItem});
            this.返乡登记ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.返乡登记ToolStripMenuItem.Name = "返乡登记ToolStripMenuItem";
            this.返乡登记ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.返乡登记ToolStripMenuItem.Size = new System.Drawing.Size(123, 35);
            this.返乡登记ToolStripMenuItem.Text = "离校登记";
            // 
            // 请假登记ToolStripMenuItem
            // 
            this.请假登记ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.请假登记ToolStripMenuItem.Name = "请假登记ToolStripMenuItem";
            this.请假登记ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.请假登记ToolStripMenuItem.Text = "请假登记";
            this.请假登记ToolStripMenuItem.Click += new System.EventHandler(this.Askforleave_click);
            // 
            // 回乡登记ToolStripMenuItem
            // 
            this.回乡登记ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.回乡登记ToolStripMenuItem.Name = "回乡登记ToolStripMenuItem";
            this.回乡登记ToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.回乡登记ToolStripMenuItem.Text = "回乡登记";
            this.回乡登记ToolStripMenuItem.Click += new System.EventHandler(this.BackHome_click);
            // 
            // 宿舍留言ToolStripMenuItem
            // 
            this.宿舍留言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宿管发布ToolStripMenuItem,
            this.同学发布ToolStripMenuItem,
            this.我要发布ToolStripMenuItem});
            this.宿舍留言ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.宿舍留言ToolStripMenuItem.Name = "宿舍留言ToolStripMenuItem";
            this.宿舍留言ToolStripMenuItem.Size = new System.Drawing.Size(123, 35);
            this.宿舍留言ToolStripMenuItem.Text = "宿舍公告";
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
            // Student_panel
            // 
            this.Student_panel.BackColor = System.Drawing.Color.Transparent;
            this.Student_panel.CausesValidation = false;
            this.Student_panel.Location = new System.Drawing.Point(135, 66);
            this.Student_panel.Name = "Student_panel";
            this.Student_panel.Size = new System.Drawing.Size(752, 407);
            this.Student_panel.TabIndex = 3;
            // 
            // BackHome_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 496);
            this.Controls.Add(this.Student_panel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BackHome_Student";
            this.Text = "学生宿舍管理系统";
            this.Load += new System.EventHandler(this.StudentRegister_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 宿舍留言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿管发布ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 同学发布ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我要发布ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请假登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回乡登记ToolStripMenuItem;
        private System.Windows.Forms.Panel Student_panel;
        private System.Windows.Forms.ToolStripMenuItem 返乡登记ToolStripMenuItem;
    }
}

