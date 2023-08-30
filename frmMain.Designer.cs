namespace TestNAudio
{
    partial class frmMain
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtsoundfile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputFileName = new System.Windows.Forms.TextBox();
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.btnEndRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(641, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(81, 29);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "播  放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtsoundfile
            // 
            this.txtsoundfile.Location = new System.Drawing.Point(145, 12);
            this.txtsoundfile.Multiline = true;
            this.txtsoundfile.Name = "txtsoundfile";
            this.txtsoundfile.ReadOnly = true;
            this.txtsoundfile.Size = new System.Drawing.Size(493, 27);
            this.txtsoundfile.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(11, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(128, 29);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "选择音频文件：";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(728, 10);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(81, 29);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "暂  停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(815, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(81, 29);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "停  止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(622, 94);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(94, 29);
            this.btnDir.TabIndex = 8;
            this.btnDir.Text = "浏  览";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "选择输出路径：";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(123, 95);
            this.txtOutputDir.Multiline = true;
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.ReadOnly = true;
            this.txtOutputDir.Size = new System.Drawing.Size(493, 27);
            this.txtOutputDir.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "设置文件名：";
            // 
            // txtOutputFileName
            // 
            this.txtOutputFileName.Location = new System.Drawing.Point(123, 132);
            this.txtOutputFileName.Multiline = true;
            this.txtOutputFileName.Name = "txtOutputFileName";
            this.txtOutputFileName.Size = new System.Drawing.Size(493, 27);
            this.txtOutputFileName.TabIndex = 12;
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.Location = new System.Drawing.Point(628, 135);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(94, 29);
            this.btnStartRecord.TabIndex = 13;
            this.btnStartRecord.Text = "开始录制";
            this.btnStartRecord.UseVisualStyleBackColor = true;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // btnEndRecord
            // 
            this.btnEndRecord.Location = new System.Drawing.Point(737, 135);
            this.btnEndRecord.Name = "btnEndRecord";
            this.btnEndRecord.Size = new System.Drawing.Size(94, 29);
            this.btnEndRecord.TabIndex = 13;
            this.btnEndRecord.Text = "完成录制";
            this.btnEndRecord.UseVisualStyleBackColor = true;
            this.btnEndRecord.Click += new System.EventHandler(this.btnEndRecord_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.btnEndRecord);
            this.Controls.Add(this.btnStartRecord);
            this.Controls.Add(this.txtOutputFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtsoundfile);
            this.Controls.Add(this.btnBrowse);
            this.Name = "frmMain";
            this.Text = "NAudio功能测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPlay;
        private TextBox txtsoundfile;
        private Button btnBrowse;
        private Button btnPause;
        private Button btnStop;
        private Button btnDir;
        private Label label1;
        private TextBox txtOutputDir;
        private Label label2;
        private TextBox txtOutputFileName;
        private Button btnStartRecord;
        private Button btnEndRecord;
    }
}