﻿namespace TradingClient
{
    partial class FormClient
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
            this.btnCallService = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCallService
            // 
            this.btnCallService.Location = new System.Drawing.Point(331, 57);
            this.btnCallService.Name = "btnCallService";
            this.btnCallService.Size = new System.Drawing.Size(150, 25);
            this.btnCallService.TabIndex = 0;
            this.btnCallService.Text = "Call";
            this.btnCallService.UseVisualStyleBackColor = true;
            this.btnCallService.Click += new System.EventHandler(this.btnCallService_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 422);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCallService);
            this.Name = "FormClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallService;
        private System.Windows.Forms.TextBox textBox1;
    }
}

