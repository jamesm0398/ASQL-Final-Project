namespace ASQL_Project_Workstation
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
            this.run1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numOrders = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doneLabel = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bezelLeft = new System.Windows.Forms.Label();
            this.bulbLeft = new System.Windows.Forms.Label();
            this.lensLeft = new System.Windows.Forms.Label();
            this.housingLeft = new System.Windows.Forms.Label();
            this.reflectorLeft = new System.Windows.Forms.Label();
            this.harnessLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kanban Workstation Simulator";
            // 
            // run1
            // 
            this.run1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.run1.Location = new System.Drawing.Point(108, 99);
            this.run1.Name = "run1";
            this.run1.Size = new System.Drawing.Size(115, 53);
            this.run1.TabIndex = 4;
            this.run1.Text = "RUN";
            this.run1.UseVisualStyleBackColor = false;
            this.run1.Click += new System.EventHandler(this.run1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Orders:";
            // 
            // numOrders
            // 
            this.numOrders.Location = new System.Drawing.Point(651, 99);
            this.numOrders.Name = "numOrders";
            this.numOrders.Size = new System.Drawing.Size(64, 20);
            this.numOrders.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Parts Remaining";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Harness:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bezel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Bulb:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Lens:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Housing:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Reflector:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Run a new workstation";
            // 
            // doneLabel
            // 
            this.doneLabel.AutoSize = true;
            this.doneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneLabel.ForeColor = System.Drawing.Color.Green;
            this.doneLabel.Location = new System.Drawing.Point(556, 257);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(0, 13);
            this.doneLabel.TabIndex = 26;
            // 
            // stop
            // 
            this.stop.ForeColor = System.Drawing.Color.Black;
            this.stop.Location = new System.Drawing.Point(108, 186);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(115, 40);
            this.stop.TabIndex = 27;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Stop the workstation";
            // 
            // bezelLeft
            // 
            this.bezelLeft.AutoSize = true;
            this.bezelLeft.Location = new System.Drawing.Point(282, 371);
            this.bezelLeft.Name = "bezelLeft";
            this.bezelLeft.Size = new System.Drawing.Size(0, 13);
            this.bezelLeft.TabIndex = 19;
            // 
            // bulbLeft
            // 
            this.bulbLeft.AutoSize = true;
            this.bulbLeft.Location = new System.Drawing.Point(282, 342);
            this.bulbLeft.Name = "bulbLeft";
            this.bulbLeft.Size = new System.Drawing.Size(0, 13);
            this.bulbLeft.TabIndex = 20;
            // 
            // lensLeft
            // 
            this.lensLeft.AutoSize = true;
            this.lensLeft.Location = new System.Drawing.Point(282, 315);
            this.lensLeft.Name = "lensLeft";
            this.lensLeft.Size = new System.Drawing.Size(0, 13);
            this.lensLeft.TabIndex = 21;
            // 
            // housingLeft
            // 
            this.housingLeft.AutoSize = true;
            this.housingLeft.Location = new System.Drawing.Point(127, 371);
            this.housingLeft.Name = "housingLeft";
            this.housingLeft.Size = new System.Drawing.Size(0, 13);
            this.housingLeft.TabIndex = 22;
            // 
            // reflectorLeft
            // 
            this.reflectorLeft.AutoSize = true;
            this.reflectorLeft.Location = new System.Drawing.Point(127, 342);
            this.reflectorLeft.Name = "reflectorLeft";
            this.reflectorLeft.Size = new System.Drawing.Size(0, 13);
            this.reflectorLeft.TabIndex = 23;
            // 
            // harnessLeft
            // 
            this.harnessLeft.AutoSize = true;
            this.harnessLeft.Location = new System.Drawing.Point(127, 315);
            this.harnessLeft.Name = "harnessLeft";
            this.harnessLeft.Size = new System.Drawing.Size(0, 13);
            this.harnessLeft.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.doneLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.harnessLeft);
            this.Controls.Add(this.reflectorLeft);
            this.Controls.Add(this.housingLeft);
            this.Controls.Add(this.lensLeft);
            this.Controls.Add(this.bulbLeft);
            this.Controls.Add(this.bezelLeft);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numOrders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.run1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button run1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label doneLabel;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bezelLeft;
        private System.Windows.Forms.Label bulbLeft;
        private System.Windows.Forms.Label lensLeft;
        private System.Windows.Forms.Label housingLeft;
        private System.Windows.Forms.Label reflectorLeft;
        private System.Windows.Forms.Label harnessLeft;
    }
}

