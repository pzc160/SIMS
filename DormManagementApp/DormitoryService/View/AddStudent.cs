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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            List<string> list = new List<string>() { "男", "女" };
            this.comboBox2.DataSource = list;
            this.comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no = this.textBox1.Text;
            string name = this.textBox2.Text;
            string sex = this.comboBox2.SelectedValue.ToString();
            string subject = this.textBox4.Text;
            string className = this.textBox5.Text;

            var res = APIHelper.Get<ApiResult>(WebSetting.GetUrl("user/add"),
                new Dictionary<string, object>() {
                    { "no", no },
                    { "name", name },
                    { "sex", sex },
                    { "subjectName", subject },
                    { "className", className },
                });

            if (res == null || res.Code != 0)
            {
                MessageBox.Show("add failed!" + (res != null ? res.Msg : ""));
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
