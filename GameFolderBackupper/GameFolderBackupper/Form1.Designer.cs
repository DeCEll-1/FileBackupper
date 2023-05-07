namespace GameFolderBackupper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_paths = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SavePath = new System.Windows.Forms.Button();
            this.tb_CustomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_SourcePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TargetPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Deselect = new System.Windows.Forms.Button();
            this.lbl_SelectedPath = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_paths
            // 
            this.lb_paths.FormattingEnabled = true;
            this.lb_paths.Location = new System.Drawing.Point(12, 25);
            this.lb_paths.Name = "lb_paths";
            this.lb_paths.Size = new System.Drawing.Size(182, 329);
            this.lb_paths.TabIndex = 0;
            this.lb_paths.SelectedIndexChanged += new System.EventHandler(this.lb_paths_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current List Of Paths (custom named)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paths are saved in the documents folder";
            // 
            // btn_SavePath
            // 
            this.btn_SavePath.Location = new System.Drawing.Point(200, 289);
            this.btn_SavePath.Name = "btn_SavePath";
            this.btn_SavePath.Size = new System.Drawing.Size(194, 47);
            this.btn_SavePath.TabIndex = 5;
            this.btn_SavePath.Text = "Save Path";
            this.btn_SavePath.UseVisualStyleBackColor = true;
            this.btn_SavePath.Click += new System.EventHandler(this.btn_SavePath_Click);
            // 
            // tb_CustomName
            // 
            this.tb_CustomName.Location = new System.Drawing.Point(200, 41);
            this.tb_CustomName.Name = "tb_CustomName";
            this.tb_CustomName.Size = new System.Drawing.Size(572, 20);
            this.tb_CustomName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Custom Name";
            // 
            // tb_SourcePath
            // 
            this.tb_SourcePath.Location = new System.Drawing.Point(200, 101);
            this.tb_SourcePath.Name = "tb_SourcePath";
            this.tb_SourcePath.Size = new System.Drawing.Size(572, 20);
            this.tb_SourcePath.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Source Path";
            // 
            // tb_TargetPath
            // 
            this.tb_TargetPath.Location = new System.Drawing.Point(200, 163);
            this.tb_TargetPath.Name = "tb_TargetPath";
            this.tb_TargetPath.Size = new System.Drawing.Size(572, 20);
            this.tb_TargetPath.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Target Path";
            // 
            // btn_Backup
            // 
            this.btn_Backup.Location = new System.Drawing.Point(578, 289);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(194, 47);
            this.btn_Backup.TabIndex = 7;
            this.btn_Backup.Text = "Backup";
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(400, 289);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(172, 47);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Deselect
            // 
            this.btn_Deselect.Location = new System.Drawing.Point(200, 243);
            this.btn_Deselect.Name = "btn_Deselect";
            this.btn_Deselect.Size = new System.Drawing.Size(194, 40);
            this.btn_Deselect.TabIndex = 4;
            this.btn_Deselect.Text = "Deselect";
            this.btn_Deselect.UseVisualStyleBackColor = true;
            this.btn_Deselect.Click += new System.EventHandler(this.btn_Deselect_Click);
            // 
            // lbl_SelectedPath
            // 
            this.lbl_SelectedPath.AutoSize = true;
            this.lbl_SelectedPath.Location = new System.Drawing.Point(200, 9);
            this.lbl_SelectedPath.Name = "lbl_SelectedPath";
            this.lbl_SelectedPath.Size = new System.Drawing.Size(77, 13);
            this.lbl_SelectedPath.TabIndex = 8;
            this.lbl_SelectedPath.Text = "Selected Path:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Please copy paste the path";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_SelectedPath);
            this.Controls.Add(this.btn_Deselect);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_TargetPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_SourcePath);
            this.Controls.Add(this.tb_CustomName);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.btn_SavePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_paths);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_paths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SavePath;
        private System.Windows.Forms.TextBox tb_CustomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_SourcePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TargetPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Deselect;
        private System.Windows.Forms.Label lbl_SelectedPath;
        private System.Windows.Forms.Label label6;
    }
}

