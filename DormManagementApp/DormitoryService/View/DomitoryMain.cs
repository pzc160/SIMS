using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace DormManagementApp
{
    public partial class DomitoryMain : Form
    {
        public DomitoryMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDomitory addDomitory = new AddDomitory();
            addDomitory.StartPosition = FormStartPosition.CenterScreen;
            if (addDomitory.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void RefreshData()
        {
            string no = this.textBox1.Text;
            string phone = this.textBox2.Text;

            Dictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                //{ "isHaveDomitory",false }
            };
            if (!string.IsNullOrEmpty(no))
                queryParams.Add("no", no);

            if (!string.IsNullOrEmpty(phone))
                queryParams.Add("phone", phone);


            List<Domitory> domitorys = new List<Domitory>();
            var res = APIHelper.Get<ApiResult<List<Domitory>>>(WebSetting.GetUrl("domitory/list"), queryParams);
            if (res != null && res.Code == 0)
                domitorys = res.Data;

            this.dataGridView1.DataSource = domitorys;
        }
    }
}
