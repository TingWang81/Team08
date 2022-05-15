namespace Team08
{
    partial class BookingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelBookingBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.infoTBox = new System.Windows.Forms.TextBox();
            this.lastNameTBox = new System.Windows.Forms.TextBox();
            this.emailTBox = new System.Windows.Forms.TextBox();
            this.firstNameTBox = new System.Windows.Forms.TextBox();
            this.bookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelBookingBtn
            // 
            this.cancelBookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBookingBtn.Location = new System.Drawing.Point(1187, 495);
            this.cancelBookingBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBookingBtn.Name = "cancelBookingBtn";
            this.cancelBookingBtn.Size = new System.Drawing.Size(160, 84);
            this.cancelBookingBtn.TabIndex = 20;
            this.cancelBookingBtn.Text = "Cancel Booking";
            this.cancelBookingBtn.UseVisualStyleBackColor = true;
            this.cancelBookingBtn.Click += new System.EventHandler(this.cancelBookingBtn_Click);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(960, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(960, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(958, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(964, 495);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 84);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Back";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // infoTBox
            // 
            this.infoTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTBox.Location = new System.Drawing.Point(93, 71);
            this.infoTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoTBox.Multiline = true;
            this.infoTBox.Name = "infoTBox";
            this.infoTBox.Size = new System.Drawing.Size(515, 707);
            this.infoTBox.TabIndex = 15;
            // 
            // lastNameTBox
            // 
            this.lastNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTBox.Location = new System.Drawing.Point(1177, 218);
            this.lastNameTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTBox.Name = "lastNameTBox";
            this.lastNameTBox.Size = new System.Drawing.Size(386, 41);
            this.lastNameTBox.TabIndex = 14;
            // 
            // emailTBox
            // 
            this.emailTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTBox.Location = new System.Drawing.Point(1177, 364);
            this.emailTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTBox.Name = "emailTBox";
            this.emailTBox.Size = new System.Drawing.Size(386, 41);
            this.emailTBox.TabIndex = 13;
            // 
            // firstNameTBox
            // 
            this.firstNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTBox.Location = new System.Drawing.Point(1177, 71);
            this.firstNameTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTBox.Name = "firstNameTBox";
            this.firstNameTBox.Size = new System.Drawing.Size(386, 41);
            this.firstNameTBox.TabIndex = 12;
            // 
            // bookBtn
            // 
            this.bookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.Location = new System.Drawing.Point(1403, 495);
            this.bookBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(160, 84);
            this.bookBtn.TabIndex = 11;
            this.bookBtn.Text = "Book ";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // BookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "BookingControl";
            this.Size = new System.Drawing.Size(1690, 845);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBookingBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox infoTBox;
        private System.Windows.Forms.TextBox lastNameTBox;
        private System.Windows.Forms.TextBox emailTBox;
        private System.Windows.Forms.TextBox firstNameTBox;
        private System.Windows.Forms.Button bookBtn;
    }
}
