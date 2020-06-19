using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using MySql.Data.MySqlClient;

namespace BackHome.UI
{
    public partial class Log_in : Skin_Color
    {
        public Log_in()
        {
            InitializeComponent();
        }

        public void Btn_login_click(object sender, EventArgs e)
        {
             try
                {
                    string sqlstr = "server = localhost; uid = root; pwd = 12345; database = dorm_Info";
                    MySqlConnection conn = new MySqlConnection(sqlstr);
                    conn.Open();
                    string UserNamestr = string.Format("SELECT * FROM sys_user where userName = '{0}' and pwd = {1};",
                    text_userName.Text, text_pwd.Text);
                    MySqlCommand comm = new MySqlCommand(UserNamestr, conn);
                    MySqlDataReader dr = comm.ExecuteReader();
                    if (dr.Read())
                    {
                        string userName = dr.GetString(dr.GetOrdinal("userName"));
                        string pwd = dr.GetString(dr.GetOrdinal("pwd"));
                    if (userName == text_userName.Text && pwd == text_pwd.Text&& text_userName.Text.Contains('t'))
                    {
                        this.DialogResult = DialogResult.Yes; //宿管登陆
                    }
                    else 
                    {
                        this.DialogResult = DialogResult.OK; //学生登陆
                    }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误，请检查后重新输入！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());               
                }
            
        }

    }
   
}
