namespace Controls.TextEditor
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
            this.txtEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.AllowCaretBeyondEOL = true;
            this.txtEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditor.EnableFolding = false;
            this.txtEditor.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtEditor.LineViewerStyle = ICSharpCode.TextEditor.Document.LineViewerStyle.FullRow;
            this.txtEditor.Location = new System.Drawing.Point(12, 12);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ShowSpaces = true;
            this.txtEditor.ShowTabs = true;
            this.txtEditor.ShowVRuler = true;
            this.txtEditor.Size = new System.Drawing.Size(534, 360);
            this.txtEditor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(27, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aplicar Formato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(177, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Indentar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(317, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Aplicar Regiones";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 421);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl txtEditor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
