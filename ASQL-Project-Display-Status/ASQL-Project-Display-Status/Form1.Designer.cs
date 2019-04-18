namespace ASQL_Project_Display_Status
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bezel = new System.Windows.Forms.Label();
            this.bulb = new System.Windows.Forms.Label();
            this.lens = new System.Windows.Forms.Label();
            this.housing = new System.Windows.Forms.Label();
            this.reflector = new System.Windows.Forms.Label();
            this.harness = new System.Windows.Forms.Label();
            this.runbutton = new System.Windows.Forms.Button();
            this.kanbanDataSet = new ASQL_Project_Display_Status.KanbanDataSet();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new ASQL_Project_Display_Status.KanbanDataSetTableAdapters.PartsTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.completed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.failed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kanbanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kanban System Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items Remaining";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bezel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bulb:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lens:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Housing:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reflector:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Harness:";
            // 
            // bezel
            // 
            this.bezel.AutoSize = true;
            this.bezel.Location = new System.Drawing.Point(87, 276);
            this.bezel.Name = "bezel";
            this.bezel.Size = new System.Drawing.Size(0, 13);
            this.bezel.TabIndex = 8;
            // 
            // bulb
            // 
            this.bulb.AutoSize = true;
            this.bulb.Location = new System.Drawing.Point(87, 253);
            this.bulb.Name = "bulb";
            this.bulb.Size = new System.Drawing.Size(0, 13);
            this.bulb.TabIndex = 9;
            // 
            // lens
            // 
            this.lens.AutoSize = true;
            this.lens.Location = new System.Drawing.Point(87, 219);
            this.lens.Name = "lens";
            this.lens.Size = new System.Drawing.Size(0, 13);
            this.lens.TabIndex = 10;
            // 
            // housing
            // 
            this.housing.AutoSize = true;
            this.housing.Location = new System.Drawing.Point(87, 190);
            this.housing.Name = "housing";
            this.housing.Size = new System.Drawing.Size(0, 13);
            this.housing.TabIndex = 11;
            // 
            // reflector
            // 
            this.reflector.AutoSize = true;
            this.reflector.Location = new System.Drawing.Point(87, 160);
            this.reflector.Name = "reflector";
            this.reflector.Size = new System.Drawing.Size(0, 13);
            this.reflector.TabIndex = 12;
            // 
            // harness
            // 
            this.harness.AutoSize = true;
            this.harness.Location = new System.Drawing.Point(87, 130);
            this.harness.Name = "harness";
            this.harness.Size = new System.Drawing.Size(0, 13);
            this.harness.TabIndex = 13;
            // 
            // runbutton
            // 
            this.runbutton.Location = new System.Drawing.Point(43, 341);
            this.runbutton.Name = "runbutton";
            this.runbutton.Size = new System.Drawing.Size(132, 53);
            this.runbutton.TabIndex = 14;
            this.runbutton.Text = "RUN";
            this.runbutton.UseVisualStyleBackColor = true;
            this.runbutton.Click += new System.EventHandler(this.Go);
            // 
            // kanbanDataSet
            // 
            this.kanbanDataSet.DataSetName = "KanbanDataSet";
            this.kanbanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.kanbanDataSet;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Completed Items:";
            // 
            // completed
            // 
            this.completed.AutoSize = true;
            this.completed.Location = new System.Drawing.Point(409, 204);
            this.completed.Name = "completed";
            this.completed.Size = new System.Drawing.Size(41, 13);
            this.completed.TabIndex = 16;
            this.completed.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Failed Items:";
            // 
            // failed
            // 
            this.failed.AutoSize = true;
            this.failed.Location = new System.Drawing.Point(409, 258);
            this.failed.Name = "failed";
            this.failed.Size = new System.Drawing.Size(41, 13);
            this.failed.TabIndex = 18;
            this.failed.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.failed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.completed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.runbutton);
            this.Controls.Add(this.harness);
            this.Controls.Add(this.reflector);
            this.Controls.Add(this.housing);
            this.Controls.Add(this.lens);
            this.Controls.Add(this.bulb);
            this.Controls.Add(this.bezel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "System Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kanbanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label bezel;
        private System.Windows.Forms.Label bulb;
        private System.Windows.Forms.Label lens;
        private System.Windows.Forms.Label housing;
        private System.Windows.Forms.Label reflector;
        private System.Windows.Forms.Label harness;
        private System.Windows.Forms.Button runbutton;
        private KanbanDataSet kanbanDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private KanbanDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label completed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label failed;
    }
}

