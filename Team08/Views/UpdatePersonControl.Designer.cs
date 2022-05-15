namespace Team08.Views
{
    partial class UpdatePersonControl
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
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.updatePersonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.firstNameTxtBox.Location = new System.Drawing.Point(541, 100);
            this.firstNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(541, 35);
            this.firstNameTxtBox.TabIndex = 17;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.emailTxtBox.Location = new System.Drawing.Point(541, 473);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(541, 35);
            this.emailTxtBox.TabIndex = 18;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lastNameTxtBox.Location = new System.Drawing.Point(541, 286);
            this.lastNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(541, 35);
            this.lastNameTxtBox.TabIndex = 19;
            // 
            // updatePersonBtn
            // 
            this.updatePersonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePersonBtn.Location = new System.Drawing.Point(708, 650);
            this.updatePersonBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatePersonBtn.Name = "updatePersonBtn";
            this.updatePersonBtn.Size = new System.Drawing.Size(191, 80);
            this.updatePersonBtn.TabIndex = 29;
            this.updatePersonBtn.Text = "Update";
            this.updatePersonBtn.UseVisualStyleBackColor = true;
            this.updatePersonBtn.Click += new System.EventHandler(this.updatePersonBtn_Click);
            // 
            // UpdatePersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updatePersonBtn);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Name = "UpdatePersonControl";
            this.Size = new System.Drawing.Size(1690, 845);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Button updatePersonBtn;
    }
}
