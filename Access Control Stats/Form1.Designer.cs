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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            buttonOpenFile = new Button();
            textResult = new RichTextBox();
            checkFullList = new CheckBox();
            errorLog = new RichTextBox();
            comboBoxEncoding = new ComboBox();
            label1 = new Label();
            buttonReloadFiles = new Button();
            buttonClearFiles = new Button();
            textFileList = new RichTextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "CSV|*.csv|All files|*.*";
            openFileDialog1.Multiselect = true;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 23);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Open";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // textResult
            // 
            textResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textResult.Location = new Point(12, 64);
            textResult.Name = "textResult";
            textResult.Size = new Size(391, 322);
            textResult.TabIndex = 3;
            textResult.Text = "";
            // 
            // checkFullList
            // 
            checkFullList.AutoSize = true;
            checkFullList.Location = new Point(12, 41);
            checkFullList.Name = "checkFullList";
            checkFullList.Size = new Size(138, 19);
            checkFullList.TabIndex = 4;
            checkFullList.Text = "Full List (with names)";
            checkFullList.UseVisualStyleBackColor = true;
            // 
            // errorLog
            // 
            errorLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorLog.Location = new Point(12, 463);
            errorLog.Name = "errorLog";
            errorLog.Size = new Size(390, 81);
            errorLog.TabIndex = 5;
            errorLog.Text = "";
            // 
            // comboBoxEncoding
            // 
            comboBoxEncoding.FormattingEnabled = true;
            comboBoxEncoding.Items.AddRange(new object[] { "UTF-8", "Latin1", "ANSI" });
            comboBoxEncoding.Location = new Point(307, 37);
            comboBoxEncoding.Name = "comboBoxEncoding";
            comboBoxEncoding.Size = new Size(96, 23);
            comboBoxEncoding.TabIndex = 6;
            comboBoxEncoding.Text = "ANSI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 42);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 7;
            label1.Text = "Encoding";
            // 
            // buttonReloadFiles
            // 
            buttonReloadFiles.Location = new Point(93, 12);
            buttonReloadFiles.Name = "buttonReloadFiles";
            buttonReloadFiles.Size = new Size(75, 23);
            buttonReloadFiles.TabIndex = 8;
            buttonReloadFiles.Text = "Reload files";
            buttonReloadFiles.UseVisualStyleBackColor = true;
            buttonReloadFiles.Click += buttonReloadFiles_Click;
            // 
            // buttonClearFiles
            // 
            buttonClearFiles.Location = new Point(174, 12);
            buttonClearFiles.Name = "buttonClearFiles";
            buttonClearFiles.Size = new Size(96, 23);
            buttonClearFiles.TabIndex = 9;
            buttonClearFiles.Text = "Clear file list";
            buttonClearFiles.UseVisualStyleBackColor = true;
            buttonClearFiles.Click += buttonClearFiles_Click;
            // 
            // textFileList
            // 
            textFileList.Location = new Point(12, 392);
            textFileList.Name = "textFileList";
            textFileList.Size = new Size(390, 65);
            textFileList.TabIndex = 10;
            textFileList.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 556);
            Controls.Add(textFileList);
            Controls.Add(buttonClearFiles);
            Controls.Add(buttonReloadFiles);
            Controls.Add(label1);
            Controls.Add(comboBoxEncoding);
            Controls.Add(errorLog);
            Controls.Add(checkFullList);
            Controls.Add(textResult);
            Controls.Add(buttonOpenFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonOpenFile;
        private RichTextBox textResult;
        private CheckBox checkFullList;
        private RichTextBox errorLog;
        private ComboBox comboBoxEncoding;
        private Label label1;
        private Button buttonReloadFiles;
        private Button buttonClearFiles;
        private RichTextBox textFileList;
    }
}