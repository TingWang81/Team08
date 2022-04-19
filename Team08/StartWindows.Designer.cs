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
            this.uxTimer = new System.Windows.Forms.Timer(this.components);
            this.management_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTimer
            // 
            this.uxTimer.Tick += new System.EventHandler(this.uxTimer_Tick);
            // 
            // management_button
            // 
            this.management_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.management_button.Location = new System.Drawing.Point(38, 1008);
            this.management_button.Name = "management_button";
            this.management_button.Size = new System.Drawing.Size(200, 100);
            this.management_button.TabIndex = 0;
            this.management_button.Text = "Managers Window";
            this.management_button.UseVisualStyleBackColor = true;
            // 
            // StartWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1978, 1144);
            this.Controls.Add(this.management_button);
            this.Name = "StartWindows";
            this.Text = "Solar Flights";
            this.Load += new System.EventHandler(this.StartWindows_Load);
            this.Click += new System.EventHandler(this.StartWindows_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer uxTimer;
        private System.Windows.Forms.Button management_button;
    }
}

