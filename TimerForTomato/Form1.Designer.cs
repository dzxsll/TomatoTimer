namespace TimerForTomato
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
            this.WorkTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BreakTime = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.TomatoCircle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkTime
            // 
            this.WorkTime.Location = new System.Drawing.Point(146, 43);
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.Size = new System.Drawing.Size(100, 21);
            this.WorkTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "工作计时器时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "休息计时器时间：";
            // 
            // BreakTime
            // 
            this.BreakTime.Location = new System.Drawing.Point(146, 88);
            this.BreakTime.Name = "BreakTime";
            this.BreakTime.Size = new System.Drawing.Size(100, 21);
            this.BreakTime.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(40, 197);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 21);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "开始计时";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TomatoCircle
            // 
            this.TomatoCircle.Location = new System.Drawing.Point(146, 133);
            this.TomatoCircle.Name = "TomatoCircle";
            this.TomatoCircle.Size = new System.Drawing.Size(100, 21);
            this.TomatoCircle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "番茄周期次数：";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(146, 197);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 21);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "关闭";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TomatoCircle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BreakTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkTime);
            this.Name = "Form1";
            this.Text = "番茄计时器";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WorkTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BreakTime;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox TomatoCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseButton;
    }
}

