using DormManagementApp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormManagementApp2._0.View.CallAtService
{
    public partial class CallAtService_ManagerHost : Form
    {
        List<CallAtApplication> SelectedApplications;
        List<CallAtApplication> AllApplications;
        Exception E = new OperationCanceledException();
        public CallAtService_ManagerHost()
        {
            InitializeComponent();
            ItemsView.DataSource = SelectedApplications;
            AllApplicationSource.DataSource = AllApplications;
            OverallView.DataSource = AllApplicationSource;

            string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);
        }

        private void button1_Click(object sender, EventArgs e)//修改或者查看申请详情
        {
            try {
                ChangeStatus changeStatus = new ChangeStatus();
                if (ItemsView.CurrentRow != null)
                {
                    int index = ItemsView.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)ItemsView.Rows[index].Cells["CallAtApplicationID"].Value;   //获取单元格的值
                    changeStatus.CurrentID = id;
                    changeStatus.ShowDialog();
                    
                    if (changeStatus.DialogResult == DialogResult.OK)//更新窗口的表单项
                    {
                        string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var task1 = client.GetStringAsync(baseURL);
                        AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);

                        SelectedApplications = new List<CallAtApplication>();//清空侧边表
                    }
                }
                else if (OverallView.CurrentRow != null)
                {
                    int index = OverallView.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)OverallView.Rows[index].Cells["CallAtApplicationID"].Value;
                    changeStatus.CurrentID = id;
                    changeStatus.ShowDialog();

                    if (changeStatus.DialogResult == DialogResult.OK)//更新窗口的表单项
                    {
                        string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var task1 = client.GetStringAsync(baseURL);
                        AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);

                        SelectedApplications = new List<CallAtApplication>();//清空侧边表
                    }
                }
                else { throw E; } 
            }
            catch (OperationCanceledException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string baseURL;
            if(RoomTextBox.Text!=null && SIDtextBox.Text == null)
            {
                baseURL = "https://localhost:5001/api/todo";///////////////
                
            }else if(RoomTextBox.Text == null && SIDtextBox.Text != null)
            {
                baseURL = "https://localhost:5001/api/todo";///////////////
            }
            else { baseURL = "https://localhost:5001/api/CallAtApplicationItems"; }
            
            if(RoomTextBox.Text != null && SIDtextBox.Text != null)
            {
                MessageBox.Show("查询信息输入过多，请选择一个输入");
            }
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            List<CallAtApplication> applications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);
            
        }

        private void Deletebutton_Click(object sender, EventArgs e)
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
                    string baseURL = "https://localhost:5001/api/CallAtApplicationItems"+ id.ToString();
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
