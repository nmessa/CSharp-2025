namespace Security
{
    partial class frmLugg
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnAddPass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Add Luggage";
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(188, 155);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(265, 31);
            this.txtLast.TabIndex = 14;
            // 
            // txtMiddle
            // 
            this.txtMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddle.Location = new System.Drawing.Point(188, 100);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(265, 31);
            this.txtMiddle.TabIndex = 13;
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(188, 51);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(265, 31);
            this.txtFirst.TabIndex = 12;
            // 
            // btnAddPass
            // 
            this.btnAddPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPass.Location = new System.Drawing.Point(188, 202);
            this.btnAddPass.Name = "btnAddPass";
            this.btnAddPass.Size = new System.Drawing.Size(140, 64);
            this.btnAddPass.TabIndex = 11;
            this.btnAddPass.Text = "Add Luggage";
            this.btnAddPass.UseVisualStyleBackColor = true;
            this.btnAddPass.Click += new System.EventHandler(this.btnAddPass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // frmLugg
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
            this.Name = "frmLugg";
            this.Text = "frmLugg";
            this.Load += new System.EventHandler(this.frmLugg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnAddPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}