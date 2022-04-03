namespace Team08
{
    partial class StartWindows
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
            this.uxCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxlabel2 = new System.Windows.Forms.Label();
            this.uxTimer = new System.Windows.Forms.Timer(this.components);
            this.uxExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxCheck
            // 
            this.uxCheck.Location = new System.Drawing.Point(79, 222);
            this.uxCheck.Name = "uxCheck";
            this.uxCheck.Size = new System.Drawing.Size(223, 98);
            this.uxCheck.TabIndex = 0;
            this.uxCheck.Text = "CheckFlight";
            this.uxCheck.UseVisualStyleBackColor = true;
            this.uxCheck.Click += new System.EventHandler(this.uxCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "SpaceObject";
            // 
            // uxlabel2
            // 
            this.uxlabel2.AutoSize = true;
            this.uxlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxlabel2.Location = new System.Drawing.Point(243, 104);
            this.uxlabel2.Name = "uxlabel2";
            this.uxlabel2.Size = new System.Drawing.Size(163, 59);
            this.uxlabel2.TabIndex = 2;
            this.uxlabel2.Text = "label1";
            // 
            // uxTimer
            // 
            this.uxTimer.Tick += new System.EventHandler(this.uxTimer_Tick);
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(471, 222);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(223, 98);
            this.uxExit.TabIndex = 3;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // StartWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxlabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxCheck);
            this.Name = "StartWindows";
            this.Text = "StartWindows";
            this.Load += new System.EventHandler(this.StartWindows_Load);
            this.Click += new System.EventHandler(this.StartWindows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxlabel2;
        private System.Windows.Forms.Timer uxTimer;
        private System.Windows.Forms.Button uxExit;
    }
}

