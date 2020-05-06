using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stu.BLL;
using Stu.Models;

namespace Stu_Backhome_Info
{
    public partial class Stu_backhome_info : Form
    {
        StuManager stu = new StuManager();

        public Stu_backhome_info()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = stu.GetStudentList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStu = new Student();
            newStu.ID = int.Parse(txtID.Text);
            newStu.Name = txtName.Text;
            newStu.Destination = txtDestination.Text;
            newStu.Departure_date = txtDeparure_date.Text;
            newStu.Return_date = txtReturn_date.Text;

            if (stu.AddStudent(newStu))
            {
                MessageBox.Show("添加成功");
                dataGridView1.DataSource = stu.GetStudentList();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //判断是否选中dataGridView1里的一行
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作");
                return;
            }
            txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDestination.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtDeparure_date.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtReturn_date.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //判断是否选中dataGridView1里的一行
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作");
                return;
            }
            Student newStu = new Student();
            newStu.ID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            newStu.Name = txtName.Text;
            newStu.Destination = txtDestination.Text;
            newStu.Departure_date = txtDeparure_date.Text;
            newStu.Return_date = txtReturn_date.Text;


            //保存修改
            if (stu.UpdateStudent(newStu))
            {
                MessageBox.Show("修改成功");
                dataGridView1.DataSource = stu.GetStudentList();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView1.SelectedRows.Count <= 0)//用于判断是否选中了一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //删除
            if (stu.DelStudent(id))
            {
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = stu.GetStudentList();
                txtID.Text = "";
                txtName.Text = "";
                txtDestination.Text = "";
                txtDeparure_date.Text = "";
                txtReturn_date.Text = "";

            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    
    }
}
