
namespace WPFActivity
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
            this.LbList = new System.Windows.Forms.ListBox();
            this.btReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbList
            // 
            this.LbList.FormattingEnabled = true;
            this.LbList.Location = new System.Drawing.Point(164, 32);
            this.LbList.Name = "LbList";
            this.LbList.Size = new System.Drawing.Size(277, 173);
            this.LbList.TabIndex = 0;
            // 
            // btReadFile
            // 
            this.btReadFile.Location = new System.Drawing.Point(228, 237);
            this.btReadFile.Name = "btReadFile";
            this.btReadFile.Size = new System.Drawing.Size(188, 73);
            this.btReadFile.TabIndex = 1;
            this.btReadFile.Text = "Read File";
            this.btReadFile.UseVisualStyleBackColor = true;
            this.btReadFile.Click += new System.EventHandler(this.btReadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReadFile);
            this.Controls.Add(this.LbList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbList;
        private System.Windows.Forms.Button btReadFile;
    }
}

