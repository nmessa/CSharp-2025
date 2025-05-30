namespace SpinCycle
{
    partial class Form1
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
            this.cboDiameter = new System.Windows.Forms.ComboBox();
            this.cboFG = new System.Windows.Forms.ComboBox();
            this.cboRG = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstRear = new System.Windows.Forms.ListBox();
            this.lstFront = new System.Windows.Forms.ListBox();
            this.radRear = new System.Windows.Forms.RadioButton();
            this.radFront = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProgram = new System.Windows.Forms.Button();
            this.lstProgram = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diameter of Wheel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Front Gears";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Rear Gears";
            // 
            // cboDiameter
            // 
            this.cboDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiameter.FormattingEnabled = true;
            this.cboDiameter.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "20",
            "24",
            "26",
            "27",
            "29"});
            this.cboDiameter.Location = new System.Drawing.Point(308, 35);
            this.cboDiameter.Name = "cboDiameter";
            this.cboDiameter.Size = new System.Drawing.Size(121, 37);
            this.cboDiameter.TabIndex = 3;
            this.cboDiameter.SelectedIndexChanged += new System.EventHandler(this.cboDiameter_SelectedIndexChanged);
            // 
            // cboFG
            // 
            this.cboFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFG.FormattingEnabled = true;
            this.cboFG.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboFG.Location = new System.Drawing.Point(308, 93);
            this.cboFG.Name = "cboFG";
            this.cboFG.Size = new System.Drawing.Size(121, 37);
            this.cboFG.TabIndex = 4;
            this.cboFG.SelectedIndexChanged += new System.EventHandler(this.cboFG_SelectedIndexChanged);
            // 
            // cboRG
            // 
            this.cboRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRG.FormattingEnabled = true;
            this.cboRG.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboRG.Location = new System.Drawing.Point(308, 155);
            this.cboRG.Name = "cboRG";
            this.cboRG.Size = new System.Drawing.Size(121, 37);
            this.cboRG.TabIndex = 5;
            this.cboRG.SelectedIndexChanged += new System.EventHandler(this.cboRG_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lstRear);
            this.groupBox1.Controls.Add(this.lstFront);
            this.groupBox1.Controls.Add(this.radRear);
            this.groupBox1.Controls.Add(this.radFront);
            this.groupBox1.Location = new System.Drawing.Point(30, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 353);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gear Sprocket Info";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(99, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 63);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Gear Info";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstRear
            // 
            this.lstRear.FormattingEnabled = true;
            this.lstRear.Location = new System.Drawing.Point(178, 62);
            this.lstRear.Name = "lstRear";
            this.lstRear.Size = new System.Drawing.Size(120, 186);
            this.lstRear.TabIndex = 3;
            // 
            // lstFront
            // 
            this.lstFront.FormattingEnabled = true;
            this.lstFront.Location = new System.Drawing.Point(29, 62);
            this.lstFront.Name = "lstFront";
            this.lstFront.Size = new System.Drawing.Size(120, 186);
            this.lstFront.TabIndex = 2;
            // 
            // radRear
            // 
            this.radRear.AutoSize = true;
            this.radRear.Location = new System.Drawing.Point(178, 36);
            this.radRear.Name = "radRear";
            this.radRear.Size = new System.Drawing.Size(117, 17);
            this.radRear.TabIndex = 1;
            this.radRear.Text = "Add Rear Gear Info";
            this.radRear.UseVisualStyleBackColor = true;
            // 
            // radFront
            // 
            this.radFront.AutoSize = true;
            this.radFront.Checked = true;
            this.radFront.Location = new System.Drawing.Point(29, 36);
            this.radFront.Name = "radFront";
            this.radFront.Size = new System.Drawing.Size(118, 17);
            this.radFront.TabIndex = 0;
            this.radFront.TabStop = true;
            this.radFront.Text = "Add Front Gear Info";
            this.radFront.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProgram);
            this.groupBox2.Controls.Add(this.lstProgram);
            this.groupBox2.Location = new System.Drawing.Point(425, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 344);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cycle Program";
            // 
            // btnProgram
            // 
            this.btnProgram.Enabled = false;
            this.btnProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgram.Location = new System.Drawing.Point(83, 263);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(127, 63);
            this.btnProgram.TabIndex = 5;
            this.btnProgram.Text = "Add Cycle Instruction";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // lstProgram
            // 
            this.lstProgram.FormattingEnabled = true;
            this.lstProgram.Location = new System.Drawing.Point(21, 27);
            this.lstProgram.Name = "lstProgram";
            this.lstProgram.Size = new System.Drawing.Size(247, 199);
            this.lstProgram.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(529, 35);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(224, 37);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Distance";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(529, 92);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(224, 37);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(529, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(85, 590);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 31);
            this.lblOutput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 639);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboRG);
            this.Controls.Add(this.cboFG);
            this.Controls.Add(this.cboDiameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDiameter;
        private System.Windows.Forms.ComboBox cboFG;
        private System.Windows.Forms.ComboBox cboRG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstRear;
        private System.Windows.Forms.ListBox lstFront;
        private System.Windows.Forms.RadioButton radRear;
        private System.Windows.Forms.RadioButton radFront;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.ListBox lstProgram;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
    }
}

