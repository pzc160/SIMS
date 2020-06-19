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
    public partial class BackHome_Student : Skin_Color
    {
        public BackHome_Student()
        {
            InitializeComponent();
        }

  
        private void StudentRegister_Load(object sender, EventArgs e)
        {

        }

        private void BackHome_click(object sender, EventArgs e)
        {
            BackHomeRegister backhomeRegister = new BackHomeRegister();//实例化子窗体
            backhomeRegister.TopLevel = false;
            backhomeRegister.Dock = DockStyle.Fill;//填充panel
            this.Student_panel.Controls.Add(backhomeRegister);
            backhomeRegister.Show();
        }

        private void Askforleave_click(object sender, EventArgs e)
        {
            AskForLeave askforleave = new AskForLeave();
            askforleave.TopLevel = false;
            askforleave.Dock = DockStyle.Fill;
            this.Student_panel.Controls.Add(askforleave);
            askforleave.Show();
        }
    }
}
