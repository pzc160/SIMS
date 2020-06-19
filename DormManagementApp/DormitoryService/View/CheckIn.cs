using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormManagementApp
{
    public partial class CheckIn : Form
    {
        private Student Student { get; set; }
        public CheckIn(Student student)
        {
            InitializeComponent();
            Student = student;
        }


        protected override void OnShown(EventArgs e)
        {

            List<Domitory> list = new List<Domitory>();
            var res = APIHelper.Get<ApiResult<List<Domitory>>>(WebSetting.GetUrl("domitory/list"));
            if (res != null && res.Code == 0)
                list = res.Data;

            if (list.Count < 1)
                MessageBox.Show("not have domitory");

            this.comboBox1.DisplayMember = "No";
            this.comboBox1.ValueMember = "No";
            this.comboBox1.DataSource = list;

            this.textBox1.Text = Student.No;
            this.textBox2.Text = Student.Name;
            this.textBox3.Text = Student.Sex;
            this.textBox4.Text = Student.SubjectName;
            this.textBox5.Text = Student.ClassName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string domitoryNo = comboBox1.SelectedValue.ToString();
            if (string.IsNullOrEmpty(domitoryNo))
            {
                MessageBox.Show("not select domitoryNo");
                return;
            }

            var res = APIHelper.Get<ApiResult>(WebSetting.GetUrl("user/checkIn"),
                new Dictionary<string, object>() { { "no", Student.No }, { "domitoryNo", domitoryNo } });
            if (res == null || res.Code != 0)
            {
                MessageBox.Show("check in failed!" + (res != null ? res.Msg : ""));
                return;
            }
            else
            {
                MessageBox.Show("success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
