using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace DirectorySearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FolderSelectButton_Click(object sender, EventArgs e)
        {
            string targetPath = "";

            targetPath = this.GetSelectedPath();

            if(Directory.Exists(targetPath))
                this.DirSearch(targetPath);
        }


        public String GetSelectedPath()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.Description = "フォルダを指定してください。";

            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(fbd.SelectedPath);
                label3.Text += fbd.SelectedPath;
            }

            return fbd.SelectedPath;
        }

        public DirectoryInfo GetFileList(String path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo f in di.GetFiles("*.exe"))
            {
                System.Diagnostics.FileVersionInfo vi = System.Diagnostics.FileVersionInfo.GetVersionInfo(f.FullName);
                this.exeFileList.Text += f.Name + " : " + vi.FileVersion + "\r\n";
            }

            foreach (FileInfo f in di.GetFiles("*.dll"))
            {
                System.Diagnostics.FileVersionInfo vi = System.Diagnostics.FileVersionInfo.GetVersionInfo(f.FullName);
                this.dllFileList.Text += f.Name + " : " + vi.FileVersion + "\r\n";
            }

            return di;
        }

        public void DirSearch(String path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo fi in di.GetFiles("*.dll"))
            {
                System.Diagnostics.FileVersionInfo vi = System.Diagnostics.FileVersionInfo.GetVersionInfo(fi.FullName);
                this.dllFileList.Text += fi.FullName + " : " + vi.FileVersion + "\r\n";
            }

            foreach (FileInfo fi in di.GetFiles("*.exe"))
            {
                System.Diagnostics.FileVersionInfo vi = System.Diagnostics.FileVersionInfo.GetVersionInfo(fi.FullName);
                this.exeFileList.Text += fi.FullName + " : " + vi.FileVersion + "\r\n";
            }

            foreach (string d in Directory.GetDirectories(path))
            {
                DirSearch(d);
            }
        }
    }
}
