namespace GameFolderBackupper
{
    partial class Backup
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
            this.btn_CurrentlyUpdating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CurrentlyUpdating
            // 
            this.btn_CurrentlyUpdating.Enabled = false;
            this.btn_CurrentlyUpdating.Location = new System.Drawing.Point(12, 12);
            this.btn_CurrentlyUpdating.Name = "btn_CurrentlyUpdating";
            this.btn_CurrentlyUpdating.Size = new System.Drawing.Size(183, 134);
            this.btn_CurrentlyUpdating.TabIndex = 0;
            this.btn_CurrentlyUpdating.UseVisualStyleBackColor = true;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 158);
            this.Controls.Add(this.btn_CurrentlyUpdating);
            this.Name = "Backup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CurrentlyUpdating;
    }
}