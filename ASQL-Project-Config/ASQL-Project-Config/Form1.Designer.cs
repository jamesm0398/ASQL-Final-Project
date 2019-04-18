namespace ASQL_Project_Config
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timescale = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.harness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reflector = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.housing = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lens = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bulb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bezel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.station1Box = new System.Windows.Forms.ComboBox();
            this.station2Box = new System.Windows.Forms.ComboBox();
            this.station3Box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(179, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(385, 35);
            this.title.TabIndex = 0;
            this.title.Text = "Kanban System Configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timescale:";
            // 
            // timescale
            // 
            this.timescale.Location = new System.Drawing.Point(142, 95);
            this.timescale.Name = "timescale";
            this.timescale.Size = new System.Drawing.Size(42, 20);
            this.timescale.TabIndex = 4;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(311, 337);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(132, 49);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save Changes";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(e.g. enter 2 for double time, 3 for triple time, etc.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bin Capacities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harness:";
            // 
            // harness
            // 
            this.harness.Location = new System.Drawing.Point(123, 243);
            this.harness.Name = "harness";
            this.harness.Size = new System.Drawing.Size(45, 20);
            this.harness.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reflector:";
            // 
            // reflector
            // 
            this.reflector.Location = new System.Drawing.Point(123, 282);
            this.reflector.Name = "reflector";
            this.reflector.Size = new System.Drawing.Size(45, 20);
            this.reflector.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Housing";
            // 
            // housing
            // 
            this.housing.Location = new System.Drawing.Point(123, 318);
            this.housing.Name = "housing";
            this.housing.Size = new System.Drawing.Size(45, 20);
            this.housing.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lens:";
            // 
            // lens
            // 
            this.lens.Location = new System.Drawing.Point(123, 352);
            this.lens.Name = "lens";
            this.lens.Size = new System.Drawing.Size(45, 20);
            this.lens.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bulb:";
            // 
            // bulb
            // 
            this.bulb.Location = new System.Drawing.Point(123, 385);
            this.bulb.Name = "bulb";
            this.bulb.Size = new System.Drawing.Size(45, 20);
            this.bulb.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Bezel:";
            // 
            // bezel
            // 
            this.bezel.Location = new System.Drawing.Point(123, 425);
            this.bezel.Name = "bezel";
            this.bezel.Size = new System.Drawing.Size(45, 20);
            this.bezel.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(270, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Workers Experience Level";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(273, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Station 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(359, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Station 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(454, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Station 3";
            // 
            // station1Box
            // 
            this.station1Box.FormattingEnabled = true;
            this.station1Box.Location = new System.Drawing.Point(276, 276);
            this.station1Box.Name = "station1Box";
            this.station1Box.Size = new System.Drawing.Size(69, 21);
            this.station1Box.TabIndex = 25;
            // 
            // station2Box
            // 
            this.station2Box.FormattingEnabled = true;
            this.station2Box.Location = new System.Drawing.Point(362, 276);
            this.station2Box.Name = "station2Box";
            this.station2Box.Size = new System.Drawing.Size(69, 21);
            this.station2Box.TabIndex = 26;
            // 
            // station3Box
            // 
            this.station3Box.FormattingEnabled = true;
            this.station3Box.Location = new System.Drawing.Point(457, 277);
            this.station3Box.Name = "station3Box";
            this.station3Box.Size = new System.Drawing.Size(69, 21);
            this.station3Box.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.station3Box);
            this.Controls.Add(this.station2Box);
            this.Controls.Add(this.station1Box);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bezel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bulb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lens);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.housing);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reflector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.harness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.timescale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Kanban System Configuration Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timescale;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox harness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reflector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox housing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lens;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bulb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bezel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox station1Box;
        private System.Windows.Forms.ComboBox station2Box;
        private System.Windows.Forms.ComboBox station3Box;
    }
}

