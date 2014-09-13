using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PVDataProcessor.Tool;

namespace PVDataProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*DB db = new DB();
            db.Load(DateTime.Now, "test.csv");*/
        }

        private void A_P_FileCutter_CheckedChanged(object sender, EventArgs e)
        {
            A_FileCutter.Enabled = A_P_FileCutter.Checked;
        }
        private void A_P_ValidCutter_CheckedChanged(object sender, EventArgs e)
        {
            A_ValidCutter.Enabled = A_P_ValidCutter.Checked;
        }
        private void A_P_Calculation_CheckedChanged(object sender, EventArgs e)
        {
            A_Calculation.Enabled = A_P_Calculation.Checked;
        }

        private void A_F_CSVFilePath_TextChanged(object sender, EventArgs e)
        {
            F_CSVFilePath.Text = A_F_CSVFilePath.Text;
        }
        private void A_F_StartDate_ValueChanged(object sender, EventArgs e)
        {
            F_StartDate.Value = A_F_StartDate.Value;
        }
        private void A_F_OutputDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            F_OutputDirectroyPath.Text = A_F_OutputDirectoryPath.Text;
            if (A_S_ProcessingDirectory.Checked)
            {
                A_V_DirectoryPath.Text = A_F_OutputDirectoryPath.Text;
                A_C_DirectoryPath.Text = A_F_OutputDirectoryPath.Text;
            }
        }
        private void A_F_FileNamePattern_TextChanged(object sender, EventArgs e)
        {
            F_FileNamePattern.Text = A_F_FileNamePattern.Text;
        }
        private void A_F_CSVFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open log file";
            ofd.Filter = "Log File(*.csv;*.txt)|*.csv;*.txt|All File(*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                A_F_CSVFilePath.Text = ofd.FileName;
            }
        }
        private void A_F_OutputDirectoryOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select output directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                A_F_OutputDirectoryPath.Text = fbd.SelectedPath;
            }
        }

        private void A_S_ProcessingDirectory_CheckedChanged(object sender, EventArgs e)
        {
            A_V_DirectoryPath.Enabled = !A_S_ProcessingDirectory.Checked;
            A_V_DirectoryOpen.Enabled = !A_S_ProcessingDirectory.Checked;
            A_C_DirectoryPath.Enabled = !A_S_ProcessingDirectory.Checked;
            A_C_DirectoryOpen.Enabled = !A_S_ProcessingDirectory.Checked;
            if (A_S_ProcessingDirectory.Checked)
            {
                A_V_DirectoryPath.Text = A_F_OutputDirectoryPath.Text;
                A_C_DirectoryPath.Text = A_F_OutputDirectoryPath.Text;
            }
        }
        private void A_S_OutputDirectory_CheckedChanged(object sender, EventArgs e)
        {
            A_V_OutputDirectoryPath.Enabled = !(A_S_OutputDirectory.Checked | A_V_OverWrite.Checked);
            A_V_OutputDirectoryOpen.Enabled = !(A_S_OutputDirectory.Checked | A_V_OverWrite.Checked);
            if (A_S_OutputDirectory.Checked)
            {
                A_V_OutputDirectoryPath.Text = A_F_OutputDirectoryPath.Text;
            }
        }

        private void A_V_DirectoryPath_TextChanged(object sender, EventArgs e)
        {
            V_DirectoryPath.Text = A_V_DirectoryPath.Text;
            if (A_V_OverWrite.Checked)
                A_V_OutputDirectoryPath.Text = A_V_DirectoryPath.Text;
        }
        private void A_V_DirectoryOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select source directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                A_V_DirectoryPath.Text = fbd.SelectedPath;
            }
        }
        private void A_V_OverWrite_CheckedChanged(object sender, EventArgs e)
        {
            A_V_OutputDirectoryPath.Enabled = !(A_S_OutputDirectory.Checked | A_V_OverWrite.Checked);
            A_V_OutputDirectoryOpen.Enabled = !(A_S_OutputDirectory.Checked | A_V_OverWrite.Checked);
            if (A_V_OverWrite.Checked)
            {
                A_V_OutputDirectoryPath.Text = A_V_DirectoryPath.Text;
            }
        }
        private void A_V_OutputDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            V_OutputDirectoryPath.Text = A_V_OutputDirectoryPath.Text;
        }
        private void A_V_OutputDirectoryOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select output directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                A_V_OutputDirectoryPath.Text = fbd.SelectedPath;
            }
        }

        private void A_C_OutputPath_TextChanged(object sender, EventArgs e)
        {
            C_OutputPath.Text = A_C_OutputPath.Text;
        }


        private void F_StartDate_ValueChanged(object sender, EventArgs e)
        {
            A_F_StartDate.Value = F_StartDate.Value;
        }
        private void F_FileNamePattern_TextChanged(object sender, EventArgs e)
        {
            A_F_FileNamePattern.Text = F_FileNamePattern.Text;
        }
        private void F_CSVFilePath_TextChanged(object sender, EventArgs e)
        {
            A_F_CSVFilePath.Text = F_CSVFilePath.Text;
        }
        private void F_OutputDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            A_F_OutputDirectoryPath.Text = F_OutputDirectroyPath.Text;
        }
        private void F_CSVFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open log file";
            ofd.Filter = "Log File(*.csv;*.txt)|*.csv;*.txt|All File(*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                F_CSVFilePath.Text = ofd.FileName;
            }
        }
        private void F_OutputDirectoryOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select output directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                F_OutputDirectroyPath.Text = fbd.SelectedPath;
            }
        }

        private void V_DirectoryPath_TextChanged(object sender, EventArgs e)
        {
            A_V_DirectoryPath.Text = V_DirectoryPath.Text;
        }
        private void V_DirectoryOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select source directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                V_DirectoryPath.Text = fbd.SelectedPath;
            }
        }
        private void V_OverWrite_CheckedChanged(object sender, EventArgs e)
        {
            label9.Enabled = !V_OverWrite.Checked;
            V_OutputDirectoryPath.Enabled = !V_OverWrite.Checked;
            V_OutputDirecrotyOpen.Enabled = !V_OverWrite.Checked;
            if (V_OverWrite.Checked)
                V_OutputDirectoryPath.Text = V_DirectoryPath.Text;
        }
        private void V_OutputDirectoryOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select output directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                V_OutputDirectoryPath.Text = fbd.SelectedPath;
            }
        }
        private void V_OutputDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            A_V_OutputDirectoryPath.Text = V_OutputDirectoryPath.Text;
        }

        private void C_DirectoryPath_TextChanged(object sender, EventArgs e)
        {
            A_C_DirectoryPath.Text = C_DirectoryPath.Text;
        }
        private void C_DirectoryOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select source directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                V_DirectoryPath.Text = fbd.SelectedPath;
            }
        }
        private void C_OutputDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            A_C_OutputPath.Text = C_OutputPath.Text;
        }
        private void C_OutputDirectoryOpen_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save log file";
            sfd.Filter = "Log File(*.csv;*.txt)|*.csv;*.txt|All File(*.*)|*.*";
            sfd.FilterIndex = 0;
            sfd.RestoreDirectory = true;
            sfd.CheckFileExists = true;
            sfd.CheckPathExists = true;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                C_DirectoryPath.Text = sfd.FileName;
            }
        }

        private void Process_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    {
                        DB db = new DB();
                        db.Load(F_StartDate.Value, F_CSVFilePath.Text);
                        Processing.CutPerDay(db.Datas, F_FileNamePattern.Text, F_OutputDirectroyPath.Text);
                    }
                    break;
                case 2:
                    Processing.ValidDataIndex(V_DirectoryPath.Text, V_OutputDirectoryPath.Text, (double)V_C_Threshold.Value, (double)V_S_Threshold.Value);
                    break;
                case 4:
                    Processing.TimeCutter(T_InputDirectoryPath.Text, T_OutputDirectoryPath.Text, new TimeSpan((int)T_CuttingHour.Value, (int)T_CuttingMinutes.Value, (int)T_CuttingSecond.Value));
                    break;
                default:
                    break;
            }
        }

        private void T_InputDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            if (T_OverWrite.Checked)
            {
                T_OutputDirectoryPath.Text = T_InputDirectoryPath.Text;
            }
        }

        private void T_OverWrite_CheckedChanged(object sender, EventArgs e)
        {
            T_OutputDirectoryPath.Enabled = !(T_OverWrite.Checked);
            label19.Enabled = !(T_OverWrite.Checked);
            T_OutputDirectorySave.Enabled = !(T_OverWrite.Checked);
            if (T_OverWrite.Checked)
            {
                T_OutputDirectoryPath.Text = T_InputDirectoryPath.Text;
            }
        }

        private void T_DirectoryOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select source directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                T_InputDirectoryPath.Text = fbd.SelectedPath;
            }
        }

        private void T_OutputDirectorySave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select output directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                T_OutputDirectoryPath.Text = fbd.SelectedPath;
            }
        }

    }
}
