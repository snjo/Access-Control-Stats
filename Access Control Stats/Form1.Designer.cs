namespace Access_Control_Stats
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.RichTextBox();
            this.checkFullList = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV|*.csv|All files|*.*";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(93, 16);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(38, 15);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "label1";
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Location = new System.Drawing.Point(12, 60);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(298, 412);
            this.textResult.TabIndex = 3;
            this.textResult.Text = "";
            // 
            // checkFullList
            // 
            this.checkFullList.AutoSize = true;
            this.checkFullList.Location = new System.Drawing.Point(13, 39);
            this.checkFullList.Name = "checkFullList";
            this.checkFullList.Size = new System.Drawing.Size(66, 19);
            this.checkFullList.TabIndex = 4;
            this.checkFullList.Text = "Full List";
            this.checkFullList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 484);
            this.Controls.Add(this.checkFullList);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonOpenFile;
        private Label labelFileName;
        private RichTextBox textResult;
        private CheckBox checkFullList;
    }
}