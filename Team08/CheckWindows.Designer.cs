namespace Team08
{
    partial class CheckWindows
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
            this.uxBack_Check = new System.Windows.Forms.Button();
            this.uxBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxBack_Check
            // 
            this.uxBack_Check.Location = new System.Drawing.Point(28, 279);
            this.uxBack_Check.Name = "uxBack_Check";
            this.uxBack_Check.Size = new System.Drawing.Size(223, 98);
            this.uxBack_Check.TabIndex = 1;
            this.uxBack_Check.Text = "Back to Menu";
            this.uxBack_Check.UseVisualStyleBackColor = true;
            this.uxBack_Check.Click += new System.EventHandler(this.uxBack_Check_Click);
            // 
            // uxBooking
            // 
            this.uxBooking.Location = new System.Drawing.Point(315, 279);
            this.uxBooking.Name = "uxBooking";
            this.uxBooking.Size = new System.Drawing.Size(223, 98);
            this.uxBooking.TabIndex = 2;
            this.uxBooking.Text = "Booking";
            this.uxBooking.UseVisualStyleBackColor = true;
            this.uxBooking.Click += new System.EventHandler(this.uxBooking_Click);
            // 
            // CheckWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxBooking);
            this.Controls.Add(this.uxBack_Check);
            this.Name = "CheckWindows";
            this.Text = "CheckWindows";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxBack_Check;
        private System.Windows.Forms.Button uxBooking;
    }
}