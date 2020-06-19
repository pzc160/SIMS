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
    public partial class StudentMain : Form
    {
        public StudentMain()
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

        private void RefreshData()
        {
            string no = this.textBox1.Text;
            string name = this.textBox2.Text;
            string subject = this.textBox3.Text;
            string className = this.textBox4.Text;
            string domitoryNo = this.textBox5.Text;

            Dictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                //{ "isHaveDomitory",false }
            };
            if (!string.IsNullOrEmpty(no))
                queryParams.Add("no", no);

            if (!string.IsNullOrEmpty(name))
                queryParams.Add("name", name);

            if (!string.IsNullOrEmpty(subject))
                queryParams.Add("subjectName", subject);

            if (!string.IsNullOrEmpty(className))
                queryParams.Add("className", className);

            if (!string.IsNullOrEmpty(domitoryNo))
                queryParams.Add("domitoryNo", domitoryNo);


            List<Student> students = new List<Student>();
            var res = APIHelper.Get<ApiResult<List<Student>>>(WebSetting.GetUrl("user/list"), queryParams);
            if (res != null && res.Code == 0)
                students = res.Data;

            this.dataGridView1.DataSource = students;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            addStudentForm.StartPosition = FormStartPosition.CenterScreen;
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView != null && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                var selectedRow = dataGridView.Rows[e.RowIndex];
                var selectedColumn = dataGridView.Columns[e.ColumnIndex];
                if (selectedRow != null && selectedColumn != null)
                {
                    string no = selectedRow.Cells["No"].Value.ToString();
                    if (!string.IsNullOrEmpty(no))
                    {
                        Student student = null;
                        var res = APIHelper.Get<ApiResult<Student>>(WebSetting.GetUrl("user/get"), new Dictionary<string, object>() { { "no", no } });
                        if (res != null && res.Code == 0)
                            student = res.Data;

                        if (student == null)
                        {
                            RefreshData();
                        }
                        else
                        {
                            switch (selectedColumn.HeaderText)
                            {
                                case "CheckIn":
                                    CheckIn checkInForm = new CheckIn(student);
                                    checkInForm.StartPosition = FormStartPosition.CenterScreen;
                                    if (checkInForm.ShowDialog() == DialogResult.OK)
                                    {
                                        MessageBox.Show("分配宿舍成功");
                                        RefreshData();
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
