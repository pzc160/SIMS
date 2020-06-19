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
    public partial class Main : Form
    {
        private Form form = null;
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        protected override void OnShown(EventArgs e)
        {
            int xWidth = SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度
            int yHeight = SystemInformation.PrimaryMonitorSize.Height;//高度
            this.Location = new Point((xWidth - Width) / 2, (yHeight - Height) / 2);

            Init();
            StudentMain student = new StudentMain();
            student.MdiParent = this;
            student.StartPosition = FormStartPosition.CenterScreen;
            form = student;
            student.Show();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Init();
            StudentMain student = new StudentMain();
            student.MdiParent = this;
            student.StartPosition = FormStartPosition.CenterScreen;

            form = student;
            student.Show();
        }

        private void Domitory_Click(object sender, EventArgs e)
        {
            DomitoryMain domitory = new DomitoryMain();
            domitory.MdiParent = this;
            domitory.StartPosition = FormStartPosition.CenterScreen;

            Init();
            form = domitory;
            domitory.Show();
        }

        private void checkInMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInMain checkIn = new CheckInMain();
            checkIn.MdiParent = this;
            checkIn.StartPosition = FormStartPosition.CenterScreen;

            Init();
            form = checkIn;

            checkIn.Show();
        }
        private void Init()
        {
            if (form != null)
                form.Close();
        }
    }
}
