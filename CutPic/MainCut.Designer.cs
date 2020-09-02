namespace CutPic
{
    partial class PicCut
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicCut));
            this.MinNot = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberCbox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MinNot
            // 
            this.MinNot.Icon = ((System.Drawing.Icon)(resources.GetObject("MinNot.Icon")));
            this.MinNot.Text = "双击进行截图";
            this.MinNot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinNot_MouseClick);
            this.MinNot.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MinNot_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "说明：双击托盘图标进行截图";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "截图快捷键：Ctrl+";
            // 
            // NumberCbox
            // 
            this.NumberCbox.AllowDrop = true;
            this.NumberCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberCbox.FormattingEnabled = true;
            this.NumberCbox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.NumberCbox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.NumberCbox.Location = new System.Drawing.Point(126, 44);
            this.NumberCbox.Name = "NumberCbox";
            this.NumberCbox.Size = new System.Drawing.Size(48, 20);
            this.NumberCbox.TabIndex = 2;
            this.NumberCbox.SelectedIndexChanged += new System.EventHandler(this.NumberCbox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PicCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 110);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NumberCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PicCut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "截图设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PicCut_Load);
            this.SizeChanged += new System.EventHandler(this.PicCut_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MinNot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumberCbox;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

