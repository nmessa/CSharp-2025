namespace Security
{
    partial class frmPass
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
            this.btnAddPass = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // btnAddPass
            // 
            this.btnAddPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPass.Location = new System.Drawing.Point(183, 202);
            this.btnAddPass.Name = "btnAddPass";
            this.btnAddPass.Size = new System.Drawing.Size(140, 64);
            this.btnAddPass.TabIndex = 3;
            this.btnAddPass.Text = "Add Passenger";
            this.btnAddPass.UseVisualStyleBackColor = true;
            this.btnAddPass.Click += new System.EventHandler(this.btnAddPass_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(183, 51);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(265, 31);
            this.txtFirst.TabIndex = 4;
            // 
            // txtMiddle
            // 
            this.txtMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddle.Location = new System.Drawing.Point(183, 100);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(265, 31);
            this.txtMiddle.TabIndex = 5;
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(183, 155);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(265, 31);
            this.txtLast.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add a Passenger";
            // 
            // frmPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnAddPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPass";
            this.Text = "frmPass";
            this.Load += new System.EventHandler(this.frmPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPass;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label4;
    }
}