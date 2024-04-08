using AnInterestingWebSiteName.Classes;
using GameFolderBackupper.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFolderBackupper
{
    public partial class Form1 : Form
    {
        public static MyPath MyPath1 { get; set; }
        SerilisationStuff SS = new SerilisationStuff();
        public Form1()
        {

            Statics.db = SS.XMLDeserialiserWS();

            InitializeComponent();

            ReFreshForm();

        }

        public void ReFreshForm()
        {
            lb_paths.Items.Clear();

            if (Statics.db?.Path == null) return;

            foreach (var item in Statics.db?.Path)
            {
                lb_paths.Items.Add(item?.CustomName);
            }
        }

        private void lb_paths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_paths.SelectedItem != null)
            {

                foreach (var item in Statics.db.Path)
                {

                    MyPath1 = item;
                    if (lb_paths.Text == item.CustomName)
                    {
                        tb_CustomName.Text = item.CustomName;
                        tb_SourcePath.Text = item.SourcePath;
                        tb_TargetPath.Text = item.TargetPath;
                        MyPath1 = item;
                        lbl_SelectedPath.Text = "Selected Path: " + item.CustomName;
                        btn_SavePath.Text = "Update Path";
                        break;
                    }
                }

            }
            else
            {
                tb_CustomName.Text = null;
                tb_SourcePath.Text = null;
                tb_TargetPath.Text = null;
            }
        }

        private void btn_SavePath_Click(object sender, EventArgs e)
        {
            if (MyPath1 == null)
            {
                if (tb_CustomName.Text != null && tb_SourcePath.Text != null && tb_TargetPath.Text != null)
                {
                    MyPath myPath = new MyPath();
                    myPath.CustomName = tb_CustomName.Text;

                    if (tb_SourcePath.Text == "documents")
                    {
                        myPath.SourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    }
                    else if (tb_SourcePath.Text == "downloads")
                    {
                        myPath.SourcePath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
                    }
                    else
                    {
                        myPath.SourcePath = tb_SourcePath.Text;
                    }

                    myPath.TargetPath = tb_TargetPath.Text;

                    BaseClass mydb = Statics.db;
                    if (mydb == null)
                    {
                        mydb = new BaseClass();
                    }
                    if (mydb.Path == null)
                    {
                        mydb.Path = new List<MyPath>();
                    }
                    mydb.Path.Add(myPath);
                    SS.Save(mydb);
                    MyPath1 = myPath;
                    lbl_SelectedPath.Text = "Selected Path: " + MyPath1.CustomName;
                    btn_SavePath.Text = "Update Path";
                    ReFreshForm();
                }
            }
            else
            {

                MyPath oldPath = MyPath1;

                MyPath1.CustomName = tb_CustomName.Text;
                if (tb_SourcePath.Text == "documents")
                {
                    MyPath1.SourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
                else if (tb_SourcePath.Text == "downloads")
                {
                    MyPath1.SourcePath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
                }
                else
                {
                    MyPath1.SourcePath = tb_SourcePath.Text;
                }

                MyPath1.TargetPath = tb_TargetPath.Text;
                MyPath1.TargetPath = tb_TargetPath.Text;

                BaseClass mydb = Statics.db;
                if (mydb == null)
                {
                    mydb = new BaseClass();
                }
                if (mydb.Path == null)
                {
                    mydb.Path = new List<MyPath>();
                }
                mydb.Path.Remove(oldPath);
                mydb.Path.Add(MyPath1);
                SS.Save(mydb);
                lbl_SelectedPath.Text = "Selected Path: " + MyPath1.CustomName;
                btn_SavePath.Text = "Update Path";
                ReFreshForm();
            }
        }

        private void btn_Deselect_Click(object sender, EventArgs e)
        {
            MyPath1 = null;
            tb_CustomName.Text = null;
            tb_SourcePath.Text = null;
            tb_TargetPath.Text = null;
            lbl_SelectedPath.Text = "Selected Path: Null";
            btn_SavePath.Text = "Save Path";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MyPath1 != null)
            {
                BaseClass mydb = Statics.db;
                if (mydb == null)
                {
                    mydb = new BaseClass();
                }
                if (mydb.Path == null)
                {
                    mydb.Path = new List<MyPath>();
                }
                mydb.Path.Remove(MyPath1);
                SS.Save(mydb);
                btn_Deselect_Click(null, null);
                ReFreshForm();
            }
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

    }
}
