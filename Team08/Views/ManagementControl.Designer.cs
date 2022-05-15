namespace Team08
{
    partial class ManagementControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rankShipCapacityBtn = new System.Windows.Forms.Button();
            this.rankShipTypesRevenueBtn = new System.Windows.Forms.Button();
            this.rankDestPlanetsBtn = new System.Windows.Forms.Button();
            this.rankCustByDistanceBtn = new System.Windows.Forms.Button();
            this.planetSearchBtn = new System.Windows.Forms.Button();
            this.shipSearchBtn = new System.Windows.Forms.Button();
            this.custSearchBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.planetNameSearchBox = new System.Windows.Forms.TextBox();
            this.shipSearchBox = new System.Windows.Forms.TextBox();
            this.custNameSearchBox = new System.Windows.Forms.TextBox();
            this.updatePersonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(940, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(712, 557);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rankShipCapacityBtn
            // 
            this.rankShipCapacityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankShipCapacityBtn.Location = new System.Drawing.Point(493, 767);
            this.rankShipCapacityBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rankShipCapacityBtn.Name = "rankShipCapacityBtn";
            this.rankShipCapacityBtn.Size = new System.Drawing.Size(408, 51);
            this.rankShipCapacityBtn.TabIndex = 26;
            this.rankShipCapacityBtn.Text = "Ship By Capacity";
            this.rankShipCapacityBtn.UseVisualStyleBackColor = true;
            this.rankShipCapacityBtn.Click += new System.EventHandler(this.rankShipCapacityBtn_Click);
            // 
            // rankShipTypesRevenueBtn
            // 
            this.rankShipTypesRevenueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankShipTypesRevenueBtn.Location = new System.Drawing.Point(18, 767);
            this.rankShipTypesRevenueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rankShipTypesRevenueBtn.Name = "rankShipTypesRevenueBtn";
            this.rankShipTypesRevenueBtn.Size = new System.Drawing.Size(408, 51);
            this.rankShipTypesRevenueBtn.TabIndex = 25;
            this.rankShipTypesRevenueBtn.Text = "Ship Type By Revenue";
            this.rankShipTypesRevenueBtn.UseVisualStyleBackColor = true;
            // 
            // rankDestPlanetsBtn
            // 
            this.rankDestPlanetsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankDestPlanetsBtn.Location = new System.Drawing.Point(493, 673);
            this.rankDestPlanetsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rankDestPlanetsBtn.Name = "rankDestPlanetsBtn";
            this.rankDestPlanetsBtn.Size = new System.Drawing.Size(408, 51);
            this.rankDestPlanetsBtn.TabIndex = 24;
            this.rankDestPlanetsBtn.Text = "Planets By Popularity";
            this.rankDestPlanetsBtn.UseVisualStyleBackColor = true;
            // 
            // rankCustByDistanceBtn
            // 
            this.rankCustByDistanceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankCustByDistanceBtn.Location = new System.Drawing.Point(18, 673);
            this.rankCustByDistanceBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rankCustByDistanceBtn.Name = "rankCustByDistanceBtn";
            this.rankCustByDistanceBtn.Size = new System.Drawing.Size(408, 51);
            this.rankCustByDistanceBtn.TabIndex = 23;
            this.rankCustByDistanceBtn.Text = "Customers By Distance";
            this.rankCustByDistanceBtn.UseVisualStyleBackColor = true;
            this.rankCustByDistanceBtn.Click += new System.EventHandler(this.rankCustByDistanceBtn_Click);
            // 
            // planetSearchBtn
            // 
            this.planetSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetSearchBtn.Location = new System.Drawing.Point(18, 522);
            this.planetSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planetSearchBtn.Name = "planetSearchBtn";
            this.planetSearchBtn.Size = new System.Drawing.Size(165, 60);
            this.planetSearchBtn.TabIndex = 22;
            this.planetSearchBtn.Text = "Search";
            this.planetSearchBtn.UseVisualStyleBackColor = true;
            this.planetSearchBtn.Click += new System.EventHandler(this.planetSearchBtn_Click);
            // 
            // shipSearchBtn
            // 
            this.shipSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipSearchBtn.Location = new System.Drawing.Point(18, 311);
            this.shipSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipSearchBtn.Name = "shipSearchBtn";
            this.shipSearchBtn.Size = new System.Drawing.Size(165, 60);
            this.shipSearchBtn.TabIndex = 21;
            this.shipSearchBtn.Text = "Search";
            this.shipSearchBtn.UseVisualStyleBackColor = true;
            this.shipSearchBtn.Click += new System.EventHandler(this.shipSearchBtn_Click);
            // 
            // custSearchBtn
            // 
            this.custSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearchBtn.Location = new System.Drawing.Point(16, 110);
            this.custSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.custSearchBtn.Name = "custSearchBtn";
            this.custSearchBtn.Size = new System.Drawing.Size(165, 60);
            this.custSearchBtn.TabIndex = 20;
            this.custSearchBtn.Text = "Search";
            this.custSearchBtn.UseVisualStyleBackColor = true;
            this.custSearchBtn.Click += new System.EventHandler(this.custSearchBtn_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1489, 747);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(163, 71);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // planetNameSearchBox
            // 
            this.planetNameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetNameSearchBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.planetNameSearchBox.Location = new System.Drawing.Point(18, 437);
            this.planetNameSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planetNameSearchBox.Name = "planetNameSearchBox";
            this.planetNameSearchBox.Size = new System.Drawing.Size(541, 35);
            this.planetNameSearchBox.TabIndex = 18;
            this.planetNameSearchBox.Text = "Planet Name";
            // 
            // shipSearchBox
            // 
            this.shipSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipSearchBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.shipSearchBox.Location = new System.Drawing.Point(18, 226);
            this.shipSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipSearchBox.Name = "shipSearchBox";
            this.shipSearchBox.Size = new System.Drawing.Size(541, 35);
            this.shipSearchBox.TabIndex = 17;
            this.shipSearchBox.Text = "Ship Name";
            // 
            // custNameSearchBox
            // 
            this.custNameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameSearchBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.custNameSearchBox.Location = new System.Drawing.Point(16, 25);
            this.custNameSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.custNameSearchBox.Name = "custNameSearchBox";
            this.custNameSearchBox.Size = new System.Drawing.Size(541, 35);
            this.custNameSearchBox.TabIndex = 16;
            this.custNameSearchBox.Text = "FirstName LastName";
            // 
            // updatePersonBtn
            // 
            this.updatePersonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePersonBtn.Location = new System.Drawing.Point(392, 110);
            this.updatePersonBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatePersonBtn.Name = "updatePersonBtn";
            this.updatePersonBtn.Size = new System.Drawing.Size(165, 60);
            this.updatePersonBtn.TabIndex = 28;
            this.updatePersonBtn.Text = "Update";
            this.updatePersonBtn.UseVisualStyleBackColor = true;
            this.updatePersonBtn.Click += new System.EventHandler(this.updatePersonBtn_Click);
            // 
            // ManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updatePersonBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rankShipCapacityBtn);
            this.Controls.Add(this.rankShipTypesRevenueBtn);
            this.Controls.Add(this.rankDestPlanetsBtn);
            this.Controls.Add(this.rankCustByDistanceBtn);
            this.Controls.Add(this.planetSearchBtn);
            this.Controls.Add(this.shipSearchBtn);
            this.Controls.Add(this.custSearchBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.planetNameSearchBox);
            this.Controls.Add(this.shipSearchBox);
            this.Controls.Add(this.custNameSearchBox);
            this.Name = "ManagementControl";
            this.Size = new System.Drawing.Size(1690, 845);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rankShipCapacityBtn;
        private System.Windows.Forms.Button rankShipTypesRevenueBtn;
        private System.Windows.Forms.Button rankDestPlanetsBtn;
        private System.Windows.Forms.Button rankCustByDistanceBtn;
        private System.Windows.Forms.Button planetSearchBtn;
        private System.Windows.Forms.Button shipSearchBtn;
        private System.Windows.Forms.Button custSearchBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox planetNameSearchBox;
        private System.Windows.Forms.TextBox shipSearchBox;
        private System.Windows.Forms.TextBox custNameSearchBox;
        private System.Windows.Forms.Button updatePersonBtn;
    }
}
