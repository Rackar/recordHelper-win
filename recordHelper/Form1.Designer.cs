namespace recordHelper
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.speed = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mytime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // speed
            // 
            this.speed.BackColor = System.Drawing.SystemColors.Control;
            this.speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speed.Location = new System.Drawing.Point(168, 16);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(79, 44);
            this.speed.TabIndex = 0;
            this.speed.Text = "加速(&W)";
            this.speed.UseVisualStyleBackColor = false;
            this.speed.Click += new System.EventHandler(this.speed_Click);
            // 
            // normal
            // 
            this.normal.BackColor = System.Drawing.SystemColors.Control;
            this.normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normal.Location = new System.Drawing.Point(70, 16);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(79, 44);
            this.normal.TabIndex = 1;
            this.normal.Text = "正常(&Q)";
            this.normal.UseVisualStyleBackColor = false;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // cut
            // 
            this.cut.BackColor = System.Drawing.SystemColors.Control;
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.Location = new System.Drawing.Point(266, 16);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(79, 44);
            this.cut.TabIndex = 2;
            this.cut.Text = "剪掉(&E)";
            this.cut.UseVisualStyleBackColor = false;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.Location = new System.Drawing.Point(12, 23);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(28, 30);
            this.num.TabIndex = 3;
            this.num.Text = "0";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Control;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Location = new System.Drawing.Point(361, 21);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 34);
            this.clear.TabIndex = 4;
            this.clear.Text = "■(&X)";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mytime
            // 
            this.mytime.AutoSize = true;
            this.mytime.Location = new System.Drawing.Point(172, 66);
            this.mytime.Name = "mytime";
            this.mytime.Size = new System.Drawing.Size(71, 15);
            this.mytime.TabIndex = 5;
            this.mytime.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 90);
            this.Controls.Add(this.mytime);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.num);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.speed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "录屏小助手";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button speed;
        private System.Windows.Forms.Button normal;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label mytime;
    }
}

