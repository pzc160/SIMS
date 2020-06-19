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
    public partial class Manager_Query : Skin_Color
    {
        public Manager_Query()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 连接字符串
        /// </summary>
        private static string sqlstr = "server = localhost; uid = root; pwd = 12345; database = dorm_Info";
        //数据适配器
        MySqlDataAdapter adapter = null;
        MySqlDataAdapter adapter1 = null;
        /// 数据集对象
        DataSet dSet = null;
        DataSet dSet1 = null;


        private void Manager_Query_Load(object sender, EventArgs e)
        {
           // TODO: 这行代码将数据加载到表“dorm_infoDataSet_Askforleave.askforleave_register”中。您可以根据需要移动或删除它。
           this.askforleave_registerTableAdapter.Fill(this.dorm_infoDataSet_Askforleave.askforleave_register);
           // TODO: 这行代码将数据加载到表“dorm_infoDataSet.backhome_register”中。您可以根据需要移动或删除它。
           this.backhome_registerTableAdapter.Fill(this.dorm_infoDataSet.backhome_register);

            adapter = new MySqlDataAdapter("select * from backhome_register",sqlstr);
            dSet = new DataSet();
            adapter.Fill(dSet);
            DataGridView2.DataSource = dSet.Tables[0];


            adapter1 = new MySqlDataAdapter("select * from askforleave_register", sqlstr);
            dSet1 = new DataSet();
            adapter1.Fill(dSet1);
            DataGridView1.DataSource = dSet1.Tables[0];
        }


        private void Btn_Updatebackhome_click(object sender, EventArgs e)
        {
            //创建命令重建对象
            MySqlCommandBuilder scb1 = new MySqlCommandBuilder(adapter);
            //更新数据
            try
            {
                adapter.Update(dSet);
                timer1.Interval = 1000;
                timer1.Start();
                // 显示对话框
                MessageBox.Show("提交成功！", "1秒后自动关闭",
                MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 停止定时器
            timer1.Stop();
            // 向对话框发送按键 Enter
            SendKeys.Send("ENTER");
        }
        private void Bnt_askforleave_update_click(object sender, EventArgs e)
        {
 
            //创建命令重建对象
            MySqlCommandBuilder scb = new MySqlCommandBuilder(adapter1);
            //更新数据
            try
            {
               adapter1.Update(dSet1);
                //启动定时器
               timer1.Interval = 1000;
               timer1.Start();
                // 显示对话框
                MessageBox.Show("提交成功！","1秒后自动关闭",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void query_askforleave_click(object sender, EventArgs e)
        {
 
            MySqlConnection con = new MySqlConnection("server = localhost; uid = root; pwd = 12345; database = dorm_Info");//建立连接
            con.Open();//打开连接
           string sql = string.Format("select * from askforleave_register where StudentNumber={0} or StudentName={1} ", this.askforleave_txt.Text, this.askforleave_txt.Text);//SQL语句
            MySqlDataAdapter sad = new MySqlDataAdapter(sql, con);//创建查询dao器
            DataSet ds = new DataSet();//创建结果集
            sad.Fill(ds);//将结果集填入
            con.Close();//关闭连接
            this.DataGridView1.DataSource = ds.Tables[0];//获取结果集中第一个表，指定数据源

        }

        private void Btn_backhome_query_click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; uid = root; pwd = 12345; database = dorm_Info");//建立连接
            con.Open();//打开连接
            string sql = string.Format("select * from askforleave_register where StudentNumber={0} or StudentName={1} ", this.askforleave_txt.Text, this.askforleave_txt.Text);//SQL语句
            MySqlDataAdapter sad1 = new MySqlDataAdapter(sql, con);//创建查询dao器
            DataSet ds1 = new DataSet();//创建结果集
            sad1.Fill(ds1);//将结果集填入
            con.Close();//关闭连接
            this.DataGridView2.DataSource = ds1.Tables[0];//获取结果集中第一个表，指定数据源
        }
    }
    
}

