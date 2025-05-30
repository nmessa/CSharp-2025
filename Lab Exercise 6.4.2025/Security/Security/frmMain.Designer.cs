namespace Security
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPassengers = new System.Windows.Forms.ListBox();
            this.lstLuggage = new System.Windows.Forms.ListBox();
            this.btnAddPass = new System.Windows.Forms.Button();
            this.btnAddLuggage = new System.Windows.Forms.Button();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airline Security Check";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passengers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Luggage";
            // 
            // lstPassengers
            // 
            this.lstPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPassengers.FormattingEnabled = true;
            this.lstPassengers.ItemHeight = 25;
            this.lstPassengers.Location = new System.Drawing.Point(52, 122);
            this.lstPassengers.Name = "lstPassengers";
            this.lstPassengers.Size = new System.Drawing.Size(282, 304);
            this.lstPassengers.TabIndex = 3;
            // 
            // lstLuggage
            // 
            this.lstLuggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLuggage.FormattingEnabled = true;
            this.lstLuggage.ItemHeight = 25;
            this.lstLuggage.Location = new System.Drawing.Point(467, 122);
            this.lstLuggage.Name = "lstLuggage";
            this.lstLuggage.Size = new System.Drawing.Size(282, 304);
            this.lstLuggage.TabIndex = 4;
            // 
            // btnAddPass
            // 
            this.btnAddPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPass.Location = new System.Drawing.Point(123, 457);
            this.btnAddPass.Name = "btnAddPass";
            this.btnAddPass.Size = new System.Drawing.Size(136, 68);
            this.btnAddPass.TabIndex = 5;
            this.btnAddPass.Text = "Add Passenger";
            this.btnAddPass.UseVisualStyleBackColor = true;
            this.btnAddPass.Click += new System.EventHandler(this.btnAddPass_Click);
            // 
            // btnAddLuggage
            // 
            this.btnAddLuggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLuggage.Location = new System.Drawing.Point(538, 457);
            this.btnAddLuggage.Name = "btnAddLuggage";
            this.btnAddLuggage.Size = new System.Drawing.Size(136, 68);
            this.btnAddLuggage.TabIndex = 6;
            this.btnAddLuggage.Text = "Add Luggage";
            this.btnAddLuggage.UseVisualStyleBackColor = true;
            this.btnAddLuggage.Click += new System.EventHandler(this.btnAddLuggage_Click);
            // 
            // btnSecurity
            // 
            this.btnSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurity.Location = new System.Drawing.Point(334, 457);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(136, 68);
            this.btnSecurity.TabIndex = 7;
            this.btnSecurity.Text = "Check Security";
            this.btnSecurity.UseVisualStyleBackColor = true;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 537);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.btnAddLuggage);
            this.Controls.Add(this.btnAddPass);
            this.Controls.Add(this.lstLuggage);
            this.Controls.Add(this.lstPassengers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPassengers;
        private System.Windows.Forms.ListBox lstLuggage;
        private System.Windows.Forms.Button btnAddPass;
        private System.Windows.Forms.Button btnAddLuggage;
        private System.Windows.Forms.Button btnSecurity;
    }
}

