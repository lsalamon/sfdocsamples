﻿using Fwk.Net.Ftp;
namespace FwkFtpClient.Test
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
            this.components = new System.ComponentModel.Container();
            this.ftpComponent1 = new Fwk.Net.Ftp.FTPComponent(this.components);
            this.SuspendLayout();
            // 
            // ftpComponent1
            // 
            this.ftpComponent1.FTPPass = "";
            this.ftpComponent1.FTPPath = ".";
            this.ftpComponent1.FTPPort = 2222;
            this.ftpComponent1.FTPServer = null;
            this.ftpComponent1.FTPUser = "anonymous";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FTPComponent ftpComponent1;
    }
}