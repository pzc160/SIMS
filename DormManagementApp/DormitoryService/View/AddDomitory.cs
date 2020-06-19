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
    public partial class AddDomitory : Form
    {
        public AddDomitory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no = this.textBox1.Text;
            string phone = this.textBox2.Text;

            var res = APIHelper.Get<ApiResult>(WebSetting.GetUrl("domitory/add"),
               new Dictionary<string, object>() { { "no", no }, { "phone", phone } });
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
