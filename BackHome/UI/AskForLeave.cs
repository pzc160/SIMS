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
    public partial class AskForLeave :  Skin_Color
    {
        public AskForLeave()
        {
            InitializeComponent();
        }

        private void submit_askforleave_click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; uid = root; pwd = 12345; database = dorm_Info");//建立连接
            con.Open();//打开连接
            MySqlCommand cmd = new MySqlCommand("insert into askforleave_register(StudentNumber,StudentName,LeaveTime,BackTime,Reason,Address)" +
                " values(txtnumber.Text,txt,txtname.Text,TimePicker_leave.value.Tostring(),TimePicker_back, TimePicker_back.Value.ToString(),txtreason.Text,txtaddress.Text", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("提交成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
