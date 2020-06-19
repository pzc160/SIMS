using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormManagementApp2._0.View.CallAtService
{

    public partial class CallAtService_StudentHost : Form
    {
        Student student = new Student();
        List<CallAtApplication> SelectedApplications;
        List<CallAtApplication> AllApplications;
        long ID;
        Exception E = new OperationCanceledException();
        public CallAtService_StudentHost()
        {
            InitializeComponent();
            student.Name = "Ashily";
            student.StudentID = 2018301;
            student.PhoneNumber = 4637489;
            student.RoomNumber = 404;
            ItemsView.DataSource = SelectedApplications;
            OverallView.DataSource = AllApplications;

            string baseURL = "https://localhost:5001/api/CallAtApplicationItems";//////////
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);
            
        }

        private void AddCallAtApplication_Click(object sender, EventArgs e)
        {
            string baseURL = "https://localhost:5001/api/CallAtApplicationItems";//////////
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);
            int index = AllApplications.Count;
            ID = AllApplications[index].CallAtApplicationID;

            AddCallAtApplication addCallAt=new AddCallAtApplication();
            addCallAt.CurrentStudent = student;
            addCallAt.ID = ID;
            addCallAt.ShowDialog();
            if (addCallAt.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("添加成功！");
                baseURL = "https://localhost:5001/api/CallAtApplicationItems";//////////

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var task2 = client.GetStringAsync(baseURL);
                AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task2.Result);

                SelectedApplications = new List<CallAtApplication>();
            }
            else MessageBox.Show("添加操作取消");

        }

        private void ChangeCallAtApplication_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeCallAtApplication_student change = new ChangeCallAtApplication_student();
                if (ItemsView.CurrentRow != null)
                {
                    int index = ItemsView.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)ItemsView.Rows[index].Cells["CallAtApplicationID"].Value;   //获取单元格的值
                    change.Index = id;
                    change.ShowDialog();
                    
                    if (change.DialogResult == DialogResult.OK)//更新窗口的表单项
                    {
                        string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var task1 = client.GetStringAsync(baseURL);
                        AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);

                        SelectedApplications = new List<CallAtApplication>();//清空侧边表
                    }
                    else if (change.DialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("操作已取消！");
                    }
                }
                else if (OverallView.CurrentRow != null)
                {
                    int index = OverallView.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)OverallView.Rows[index].Cells["CallAtApplicationID"].Value;
                    change.Index = id;
                    change.ShowDialog();

                    if (change.DialogResult == DialogResult.OK)//更新窗口的表单项
                    {
                        string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var task1 = client.GetStringAsync(baseURL);
                        AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);

                        SelectedApplications = new List<CallAtApplication>();//清空侧边表
                    }else if (change.DialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("操作已取消！");
                    }
                }
                else { throw E; }
            }
            catch (OperationCanceledException E)
            {
                MessageBox.Show(E.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)//按照日期查询
        {
            string dateTime = dateTimePicker1.Text;
            string baseURL = "https://localhost:5001/api/CallAtApplicationItems" + dateTime;//////////////////////////
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            var task = client.GetStringAsync(baseURL);
            SelectedApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task.Result);
        }

        private void DeleteApplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemsView.CurrentRow != null)
                {
                    int index = ItemsView.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)ItemsView.Rows[index].Cells["CallAtApplicationID"].Value;   //获取单元格的值

                    string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var task1 = client.DeleteAsync(baseURL);

                    //更新表单
                    SelectedApplications.RemoveAt(index);
                    var task2 = client.GetStringAsync(baseURL);
                    AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task2.Result);
                }
                else if (OverallView.CurrentRow != null)
                {
                    int index = OverallView.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)OverallView.Rows[index].Cells["CallAtApplicationID"].Value;
                    string baseURL = "https://localhost:5001/api/CallAtApplicationItems" + id.ToString();
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var task1 = client.DeleteAsync(baseURL);
                    //更新表单
                    AllApplications.RemoveAt(index);
                    SelectedApplications = new List<CallAtApplication>();

                }
                else { throw E; }
            }
            catch (OperationCanceledException E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
