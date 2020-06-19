namespace BackHome.UI
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.Btn_login = new CCWin.SkinControl.SkinButton();
            this.text_pwd = new CCWin.SkinControl.SkinTextBox();
            this.text_userName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.Btn_login);
            this.skinPanel1.Controls.Add(this.text_pwd);
            this.skinPanel1.Controls.Add(this.text_userName);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(58, 89);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(740, 354);
            this.skinPanel1.TabIndex = 1;
            // 
            // Btn_login
            // 
            this.Btn_login.BackColor = System.Drawing.Color.Transparent;
            this.Btn_login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_login.DownBack = null;
            this.Btn_login.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_login.Location = new System.Drawing.Point(532, 263);
            this.Btn_login.MouseBack = null;
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.NormlBack = null;
            this.Btn_login.Size = new System.Drawing.Size(81, 40);
            this.Btn_login.TabIndex = 2;
            this.Btn_login.Text = "登陆";
            this.Btn_login.UseVisualStyleBackColor = false;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_click);
            // 
            // text_pwd
            // 
            this.text_pwd.BackColor = System.Drawing.Color.Transparent;
            this.text_pwd.DownBack = null;
            this.text_pwd.Icon = null;
            this.text_pwd.IconIsButton = false;
            this.text_pwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_pwd.IsPasswordChat = '*';
            this.text_pwd.IsSystemPasswordChar = false;
            this.text_pwd.Lines = new string[0];
            this.text_pwd.Location = new System.Drawing.Point(156, 222);
            this.text_pwd.Margin = new System.Windows.Forms.Padding(0);
            this.text_pwd.MaxLength = 32767;
            this.text_pwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.text_pwd.MouseBack = null;
            this.text_pwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_pwd.Multiline = true;
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.NormlBack = null;
            this.text_pwd.Padding = new System.Windows.Forms.Padding(5);
            this.text_pwd.ReadOnly = false;
            this.text_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_pwd.Size = new System.Drawing.Size(193, 44);
            // 
            // 
            // 
            this.text_pwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_pwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.text_pwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.text_pwd.SkinTxt.Multiline = true;
            this.text_pwd.SkinTxt.Name = "BaseText";
            this.text_pwd.SkinTxt.PasswordChar = '*';
            this.text_pwd.SkinTxt.Size = new System.Drawing.Size(183, 34);
            this.text_pwd.SkinTxt.TabIndex = 0;
            this.text_pwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_pwd.SkinTxt.WaterText = "";
            this.text_pwd.TabIndex = 5;
            this.text_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_pwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_pwd.WaterText = "";
            this.text_pwd.WordWrap = true;
            // 
            // text_userName
            // 
            this.text_userName.BackColor = System.Drawing.Color.Transparent;
            this.text_userName.DownBack = null;
            this.text_userName.Icon = null;
            this.text_userName.IconIsButton = false;
            this.text_userName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_userName.IsPasswordChat = '\0';
            this.text_userName.IsSystemPasswordChar = false;
            this.text_userName.Lines = new string[0];
            this.text_userName.Location = new System.Drawing.Point(156, 124);
            this.text_userName.Margin = new System.Windows.Forms.Padding(0);
            this.text_userName.MaxLength = 32767;
            this.text_userName.MinimumSize = new System.Drawing.Size(28, 28);
            this.text_userName.MouseBack = null;
            this.text_userName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_userName.Multiline = true;
            this.text_userName.Name = "text_userName";
            this.text_userName.NormlBack = null;
            this.text_userName.Padding = new System.Windows.Forms.Padding(5);
            this.text_userName.ReadOnly = false;
            this.text_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_userName.Size = new System.Drawing.Size(193, 43);
            // 
            // 
            // 
            this.text_userName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_userName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_userName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.text_userName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.text_userName.SkinTxt.Multiline = true;
            this.text_userName.SkinTxt.Name = "BaseText";
            this.text_userName.SkinTxt.Size = new System.Drawing.Size(183, 33);
            this.text_userName.SkinTxt.TabIndex = 0;
            this.text_userName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_userName.SkinTxt.WaterText = "";
            this.text_userName.TabIndex = 4;
            this.text_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_userName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_userName.WaterText = "";
            this.text_userName.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(51, 222);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(52, 27);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "密码";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(51, 124);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(52, 27);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "账号";
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 501);
            this.Controls.Add(this.skinPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_in";
            this.Text = "学生宿舍管理系统";
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton Btn_login;
        private CCWin.SkinControl.SkinTextBox text_pwd;
        private CCWin.SkinControl.SkinTextBox text_userName;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
    }
}