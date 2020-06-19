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

namespace BackHome
{
    public partial class BackHomeRegister : Skin_Color
    {
        public BackHomeRegister()
        {
            InitializeComponent();
        }

        private void skinListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; uid = root; pwd = 12345; database = dorm_Info");//建立连接
            con.Open();//打开连接
            MySqlCommand cmd = new MySqlCommand("insert into backhome_register(StudentNumber,StudentName,LeaveTime,BackTime,Reason,Address)" +
                " values(txtnumber2.Text,txtname2.Text,TimePicker2_leave.value.Tostring(),TimePicker2_back, TimePicker_back.Value.ToString(),txtreason.Text,txtaddress.Text", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("提交成功","", MessageBoxButtons.OK, MessageBoxIcon.None);
        
        }
    }
}
