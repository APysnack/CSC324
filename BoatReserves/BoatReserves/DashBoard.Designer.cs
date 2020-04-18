namespace BoatReserves
{
    partial class DashBoard
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
            this.addSailorRadioButton = new System.Windows.Forms.RadioButton();
            this.addBoatRadioButton = new System.Windows.Forms.RadioButton();
            this.addReservationRadioButton = new System.Windows.Forms.RadioButton();
            this.proceedButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.viewReservationRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // addSailorRadioButton
            // 
            this.addSailorRadioButton.AutoSize = true;
            this.addSailorRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSailorRadioButton.Location = new System.Drawing.Point(73, 24);
            this.addSailorRadioButton.Name = "addSailorRadioButton";
            this.addSailorRadioButton.Size = new System.Drawing.Size(125, 20);
            this.addSailorRadioButton.TabIndex = 0;
            this.addSailorRadioButton.TabStop = true;
            this.addSailorRadioButton.Text = "Add New Sailor";
            this.addSailorRadioButton.UseVisualStyleBackColor = true;
            // 
            // addBoatRadioButton
            // 
            this.addBoatRadioButton.AutoSize = true;
            this.addBoatRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBoatRadioButton.Location = new System.Drawing.Point(73, 56);
            this.addBoatRadioButton.Name = "addBoatRadioButton";
            this.addBoatRadioButton.Size = new System.Drawing.Size(116, 20);
            this.addBoatRadioButton.TabIndex = 1;
            this.addBoatRadioButton.TabStop = true;
            this.addBoatRadioButton.Text = "Add New Boat";
            this.addBoatRadioButton.UseVisualStyleBackColor = true;
            // 
            // addReservationRadioButton
            // 
            this.addReservationRadioButton.AutoSize = true;
            this.addReservationRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReservationRadioButton.Location = new System.Drawing.Point(73, 86);
            this.addReservationRadioButton.Name = "addReservationRadioButton";
            this.addReservationRadioButton.Size = new System.Drawing.Size(162, 20);
            this.addReservationRadioButton.TabIndex = 2;
            this.addReservationRadioButton.TabStop = true;
            this.addReservationRadioButton.Text = "Add New Reservation";
            this.addReservationRadioButton.UseVisualStyleBackColor = true;
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(71, 159);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(126, 37);
            this.proceedButton.TabIndex = 3;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(239, 159);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 37);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // viewReservationRadioButton
            // 
            this.viewReservationRadioButton.AutoSize = true;
            this.viewReservationRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReservationRadioButton.Location = new System.Drawing.Point(73, 119);
            this.viewReservationRadioButton.Name = "viewReservationRadioButton";
            this.viewReservationRadioButton.Size = new System.Drawing.Size(143, 20);
            this.viewReservationRadioButton.TabIndex = 5;
            this.viewReservationRadioButton.TabStop = true;
            this.viewReservationRadioButton.Text = "View Reservations";
            this.viewReservationRadioButton.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 240);
            this.Controls.Add(this.viewReservationRadioButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.addReservationRadioButton);
            this.Controls.Add(this.addBoatRadioButton);
            this.Controls.Add(this.addSailorRadioButton);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton addSailorRadioButton;
        private System.Windows.Forms.RadioButton addBoatRadioButton;
        private System.Windows.Forms.RadioButton addReservationRadioButton;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton viewReservationRadioButton;
    }
}