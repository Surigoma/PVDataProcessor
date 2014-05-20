using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PVDataProcessor
{
    public partial class ProcessPrev : Form
    {
        public ProcessPrev()
        {
            InitializeComponent();
        }

        private void ProcessPrev_Load(object sender, EventArgs e)
        {

        }
        public void SetTitle(string data)
        {
            ProcessTitle.Text = data;
            this.Update();
        }
        public void UpdateProgress(int i)
        {
            Bar1.Value = i;
            this.Update();
        }
        public void SetMaxProgress(int i)
        {
            Bar1.Maximum = i;
            this.Update();
        }
        public void UpdateAllProgress(int i)
        {
            Bar2.Value = i;
            this.Update();
        }
        public void SetMaxAllProgress(int i )
        {
            Bar2.Maximum = i;
            this.Update();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Update();
        }
    }
}
