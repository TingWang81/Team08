namespace Team08
{
    partial class DestinationPlanetControl
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
            this.management_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // management_button
            // 
            this.management_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.management_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.management_button.Location = new System.Drawing.Point(1459, 710);
            this.management_button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.management_button.Name = "management_button";
            this.management_button.Size = new System.Drawing.Size(199, 100);
            this.management_button.TabIndex = 1;
            this.management_button.Text = "Managers Window";
            this.management_button.UseVisualStyleBackColor = false;
            this.management_button.Click += new System.EventHandler(this.management_button_Click);
            // 
            // DestinationPlanetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.management_button);
            this.Name = "DestinationPlanetControl";
            this.Size = new System.Drawing.Size(1690, 845);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button management_button;
    }
}
