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
            this.bookBtn = new System.Windows.Forms.Button();
            this.firstNameTBox = new System.Windows.Forms.TextBox();
            this.emailTBox = new System.Windows.Forms.TextBox();
            this.lastNameTBox = new System.Windows.Forms.TextBox();
            this.infoTBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBookingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookBtn
            // 
            this.bookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.Location = new System.Drawing.Point(1340, 330);
            this.bookBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(160, 84);
            this.bookBtn.TabIndex = 0;
            this.bookBtn.Text = "Book ";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // firstNameTBox
            // 
            this.firstNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTBox.Location = new System.Drawing.Point(1113, 44);
            this.firstNameTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTBox.Name = "firstNameTBox";
            this.firstNameTBox.Size = new System.Drawing.Size(386, 41);
            this.firstNameTBox.TabIndex = 1;
            // 
            // emailTBox
            // 
            this.emailTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTBox.Location = new System.Drawing.Point(1113, 234);
            this.emailTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTBox.Name = "emailTBox";
            this.emailTBox.Size = new System.Drawing.Size(386, 41);
            this.emailTBox.TabIndex = 3;
            // 
            // lastNameTBox
            // 
            this.lastNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTBox.Location = new System.Drawing.Point(1113, 139);
            this.lastNameTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTBox.Name = "lastNameTBox";
            this.lastNameTBox.Size = new System.Drawing.Size(386, 41);
            this.lastNameTBox.TabIndex = 4;
            // 
            // infoTBox
            // 
            this.infoTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTBox.Location = new System.Drawing.Point(29, 44);
            this.infoTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoTBox.Multiline = true;
            this.infoTBox.Name = "infoTBox";
            this.infoTBox.Size = new System.Drawing.Size(515, 369);
            this.infoTBox.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(952, 329);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 84);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Back";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(894, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(896, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // cancelBookingBtn
            // 
            this.cancelBookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBookingBtn.Location = new System.Drawing.Point(1145, 329);
            this.cancelBookingBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBookingBtn.Name = "cancelBookingBtn";
            this.cancelBookingBtn.Size = new System.Drawing.Size(160, 84);
            this.cancelBookingBtn.TabIndex = 10;
            this.cancelBookingBtn.Text = "Cancel Booking";
            this.cancelBookingBtn.UseVisualStyleBackColor = true;
            this.cancelBookingBtn.Click += new System.EventHandler(this.cancelBookingBtn_Click);
            // 
            // CheckWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 465);
            this.Controls.Add(this.cancelBookingBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.infoTBox);
            this.Controls.Add(this.lastNameTBox);
            this.Controls.Add(this.emailTBox);
            this.Controls.Add(this.firstNameTBox);
            this.Controls.Add(this.bookBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckWindows";
            this.Text = "CheckWindows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.TextBox firstNameTBox;
        private System.Windows.Forms.TextBox emailTBox;
        private System.Windows.Forms.TextBox lastNameTBox;
        private System.Windows.Forms.TextBox infoTBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBookingBtn;
    }
}