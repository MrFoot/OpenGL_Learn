namespace Transfrom
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cbx = new System.Windows.Forms.CheckBox();
            this.cby = new System.Windows.Forms.CheckBox();
            this.cbz = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(35, 12);
            this.trackBar1.Maximum = 250;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(347, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cbx
            // 
            this.cbx.AutoSize = true;
            this.cbx.Location = new System.Drawing.Point(475, 13);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(30, 16);
            this.cbx.TabIndex = 1;
            this.cbx.Text = "x";
            this.cbx.UseVisualStyleBackColor = true;
            this.cbx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cby
            // 
            this.cby.AutoSize = true;
            this.cby.Location = new System.Drawing.Point(475, 54);
            this.cby.Name = "cby";
            this.cby.Size = new System.Drawing.Size(30, 16);
            this.cby.TabIndex = 2;
            this.cby.Text = "y";
            this.cby.UseVisualStyleBackColor = true;
            // 
            // cbz
            // 
            this.cbz.AutoSize = true;
            this.cbz.Location = new System.Drawing.Point(475, 96);
            this.cbz.Name = "cbz";
            this.cbz.Size = new System.Drawing.Size(30, 16);
            this.cbz.TabIndex = 3;
            this.cbz.Text = "z";
            this.cbz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.cbz);
            this.Controls.Add(this.cby);
            this.Controls.Add(this.cbx);
            this.Controls.Add(this.trackBar1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox cbx;
        private System.Windows.Forms.CheckBox cby;
        private System.Windows.Forms.CheckBox cbz;
    }
}

