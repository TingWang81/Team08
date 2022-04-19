namespace Team08
{
    partial class ManagementWindow
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
            this.custNameSearchBox = new System.Windows.Forms.TextBox();
            this.shipSearchBox = new System.Windows.Forms.TextBox();
            this.planetNameSearchBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.custSearchBtn = new System.Windows.Forms.Button();
            this.shipSearchBtn = new System.Windows.Forms.Button();
            this.planetSearchBtn = new System.Windows.Forms.Button();
            this.rankCustByDistanceBtn = new System.Windows.Forms.Button();
            this.rankDestPlanetsBtn = new System.Windows.Forms.Button();
            this.rankShipTypesRevenueBtn = new System.Windows.Forms.Button();
            this.rankLabel = new System.Windows.Forms.Label();
            this.rankShipCapacityBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custNameSearchBox
            // 
            this.custNameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameSearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.custNameSearchBox.Location = new System.Drawing.Point(23, 21);
            this.custNameSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.custNameSearchBox.Name = "custNameSearchBox";
            this.custNameSearchBox.Size = new System.Drawing.Size(481, 35);
            this.custNameSearchBox.TabIndex = 1;
            this.custNameSearchBox.Text = "Cust. LastName FirstName";
            // 
            // shipSearchBox
            // 
            this.shipSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipSearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.shipSearchBox.Location = new System.Drawing.Point(614, 21);
            this.shipSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipSearchBox.Name = "shipSearchBox";
            this.shipSearchBox.Size = new System.Drawing.Size(481, 35);
            this.shipSearchBox.TabIndex = 3;
            this.shipSearchBox.Text = "Ship Name";
            // 
            // planetNameSearchBox
            // 
            this.planetNameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetNameSearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.planetNameSearchBox.Location = new System.Drawing.Point(1213, 21);
            this.planetNameSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planetNameSearchBox.Name = "planetNameSearchBox";
            this.planetNameSearchBox.Size = new System.Drawing.Size(481, 35);
            this.planetNameSearchBox.TabIndex = 5;
            this.planetNameSearchBox.Text = "Planet Name";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1549, 332);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(145, 56);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // custSearchBtn
            // 
            this.custSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearchBtn.Location = new System.Drawing.Point(23, 89);
            this.custSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.custSearchBtn.Name = "custSearchBtn";
            this.custSearchBtn.Size = new System.Drawing.Size(146, 48);
            this.custSearchBtn.TabIndex = 7;
            this.custSearchBtn.Text = "Search";
            this.custSearchBtn.UseVisualStyleBackColor = true;
            this.custSearchBtn.Click += new System.EventHandler(this.custSearchBtn_Click);
            // 
            // shipSearchBtn
            // 
            this.shipSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipSearchBtn.Location = new System.Drawing.Point(614, 89);
            this.shipSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipSearchBtn.Name = "shipSearchBtn";
            this.shipSearchBtn.Size = new System.Drawing.Size(146, 48);
            this.shipSearchBtn.TabIndex = 8;
            this.shipSearchBtn.Text = "Search";
            this.shipSearchBtn.UseVisualStyleBackColor = true;
            // 
            // planetSearchBtn
            // 
            this.planetSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetSearchBtn.Location = new System.Drawing.Point(1213, 89);
            this.planetSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planetSearchBtn.Name = "planetSearchBtn";
            this.planetSearchBtn.Size = new System.Drawing.Size(146, 48);
            this.planetSearchBtn.TabIndex = 9;
            this.planetSearchBtn.Text = "Search";
            this.planetSearchBtn.UseVisualStyleBackColor = true;
            // 
            // rankCustByDistanceBtn
            // 
            this.rankCustByDistanceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankCustByDistanceBtn.Location = new System.Drawing.Point(35, 272);
            this.rankCustByDistanceBtn.Name = "rankCustByDistanceBtn";
            this.rankCustByDistanceBtn.Size = new System.Drawing.Size(362, 41);
            this.rankCustByDistanceBtn.TabIndex = 10;
            this.rankCustByDistanceBtn.Text = "Customers By Distance";
            this.rankCustByDistanceBtn.UseVisualStyleBackColor = true;
            // 
            // rankDestPlanetsBtn
            // 
            this.rankDestPlanetsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankDestPlanetsBtn.Location = new System.Drawing.Point(457, 272);
            this.rankDestPlanetsBtn.Name = "rankDestPlanetsBtn";
            this.rankDestPlanetsBtn.Size = new System.Drawing.Size(362, 41);
            this.rankDestPlanetsBtn.TabIndex = 11;
            this.rankDestPlanetsBtn.Text = "Planets By Popularity";
            this.rankDestPlanetsBtn.UseVisualStyleBackColor = true;
            // 
            // rankShipTypesRevenueBtn
            // 
            this.rankShipTypesRevenueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankShipTypesRevenueBtn.Location = new System.Drawing.Point(35, 347);
            this.rankShipTypesRevenueBtn.Name = "rankShipTypesRevenueBtn";
            this.rankShipTypesRevenueBtn.Size = new System.Drawing.Size(362, 41);
            this.rankShipTypesRevenueBtn.TabIndex = 12;
            this.rankShipTypesRevenueBtn.Text = "Ship Type By Revenue";
            this.rankShipTypesRevenueBtn.UseVisualStyleBackColor = true;
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankLabel.Location = new System.Drawing.Point(28, 221);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(191, 37);
            this.rankLabel.TabIndex = 13;
            this.rankLabel.Text = "Quick Rank:";
            // 
            // rankShipCapacityBtn
            // 
            this.rankShipCapacityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankShipCapacityBtn.Location = new System.Drawing.Point(457, 347);
            this.rankShipCapacityBtn.Name = "rankShipCapacityBtn";
            this.rankShipCapacityBtn.Size = new System.Drawing.Size(362, 41);
            this.rankShipCapacityBtn.TabIndex = 14;
            this.rankShipCapacityBtn.Text = "Ship By Capacity";
            this.rankShipCapacityBtn.UseVisualStyleBackColor = true;
            // 
            // ManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1714, 415);
            this.Controls.Add(this.rankShipCapacityBtn);
            this.Controls.Add(this.rankLabel);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagementWindow";
            this.Text = "Management Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox custNameSearchBox;
        private System.Windows.Forms.TextBox shipSearchBox;
        private System.Windows.Forms.TextBox planetNameSearchBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button custSearchBtn;
        private System.Windows.Forms.Button shipSearchBtn;
        private System.Windows.Forms.Button planetSearchBtn;
        private System.Windows.Forms.Button rankCustByDistanceBtn;
        private System.Windows.Forms.Button rankDestPlanetsBtn;
        private System.Windows.Forms.Button rankShipTypesRevenueBtn;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Button rankShipCapacityBtn;
    }
}