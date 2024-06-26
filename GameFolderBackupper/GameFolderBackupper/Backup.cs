﻿using GameFolderBackupper.Classes;
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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            foreach (var item in Statics.db.Path)
            {   
                string result = CopyDirectory(item.SourcePath, item.TargetPath, item.CustomName);

                btn_CurrentlyUpdating.Text = item.CustomName;

                if (result != "Completed")
                {
                    MessageBox.Show("Source directory not found: " + item.SourcePath + "    " + result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.Close();
        }

        static string CopyDirectory(string sourceDir, string destinationDir, string customName)
        {

            try
            {

                //slow as balls
                //if (Directory.Exists(Path.Combine(destinationDir, customName)))
                //{
                //    UpdateFileAttributes(new DirectoryInfo(Path.Combine(destinationDir, customName)));
                //    Directory.Delete(Path.Combine(destinationDir, customName), true);
                //}

                // Get information about the source directory
                var dir = new DirectoryInfo(sourceDir);

                // Check if the source directory exists
                if (!dir.Exists)
                    return "Source directory not found:";



                // Cache directories before we start copying
                DirectoryInfo[] dirs = dir.GetDirectories();

                // Create the destination directory
                Directory.CreateDirectory(Path.Combine(destinationDir, customName));

                // Get the files in the source directory and copy to the destination directory
                foreach (FileInfo file in dir.GetFiles())
                {
                    string targetFilePath = Path.Combine(Path.Combine(destinationDir, customName), file.Name);
                    file.CopyTo(targetFilePath);
                }

                // If recursive and copying subdirectories, recursively call this method
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(Path.Combine(destinationDir, customName), subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir);
                }
                return "Completed";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        static string CopyDirectory(string sourceDir, string destinationDir)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                return "Source directory not found:";

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            foreach (DirectoryInfo subDir in dirs)
            {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir);
            }
            return "Completed";
        }

        private static void UpdateFileAttributes(DirectoryInfo dInfo)
        {
            return;//slow as balls
            //https://stackoverflow.com/questions/17273650/setting-file-attributes-recursively-subfolders
            // Set Directory attribute
            dInfo.Attributes &= ~FileAttributes.ReadOnly;

            // get list of all files in the directory and clear 
            // the Read-Only flag

            foreach (FileInfo file in dInfo.GetFiles())
            {
                file.Attributes &= ~FileAttributes.ReadOnly;
            }

            // recurse all of the subdirectories
            foreach (DirectoryInfo subDir in dInfo.GetDirectories())
            {
                UpdateFileAttributes(subDir);
            }
        }

    }
}
