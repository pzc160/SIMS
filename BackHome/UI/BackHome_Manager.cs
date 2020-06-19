using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackHome.UI;
using CCWin;


namespace BackHome
{
    public partial class BackHome_Manager : Skin_Color
    {
        public BackHome_Manager()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BackHome_Manager_Load(object sender, EventArgs e)
        {

        }

        private void AskforLeave_Manager_Click(object sender, EventArgs e)
        {
            Manager_Query manager_query = new Manager_Query();//实例化子窗体
            manager_query.TopLevel = false;
            manager_query.Dock = DockStyle.Fill;//填充panel
            this.Manager_panel.Controls.Add(manager_query);
            manager_query.Show();
        }

        private void Register_manager_click(object sender, EventArgs e)
        {
            Manager_Query manager_query = new Manager_Query();//实例化子窗体
            manager_query.TopLevel = false;
            manager_query.Dock = DockStyle.Fill;//填充panel
            this.Manager_panel.Controls.Add(manager_query);
            manager_query.Show();
        }
    }
}
