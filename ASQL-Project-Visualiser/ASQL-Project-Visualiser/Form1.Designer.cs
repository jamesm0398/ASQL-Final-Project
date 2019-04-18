namespace ASQL_Project_Visualiser
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.KanbanGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.run = new System.Windows.Forms.Button();
            this.harness = new System.Windows.Forms.Label();
            this.bezel = new System.Windows.Forms.Label();
            this.bulb = new System.Windows.Forms.Label();
            this.lens = new System.Windows.Forms.Label();
            this.reflector = new System.Windows.Forms.Label();
            this.housing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KanbanGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kanban Visualisation";
            // 
            // KanbanGraph
            // 
            chartArea1.AxisX.Title = "Part";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Amount";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.KanbanGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.KanbanGraph.Legends.Add(legend1);
            this.KanbanGraph.Location = new System.Drawing.Point(166, 92);
            this.KanbanGraph.Name = "KanbanGraph";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.KanbanGraph.Series.Add(series1);
            this.KanbanGraph.Size = new System.Drawing.Size(553, 304);
            this.KanbanGraph.TabIndex = 1;
            this.KanbanGraph.Text = "chart1";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(12, 121);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 2;
            this.run.Text = "RUN";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // harness
            // 
            this.harness.AutoSize = true;
            this.harness.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harness.ForeColor = System.Drawing.Color.Red;
            this.harness.Location = new System.Drawing.Point(12, 163);
            this.harness.Name = "harness";
            this.harness.Size = new System.Drawing.Size(0, 22);
            this.harness.TabIndex = 3;
            // 
            // bezel
            // 
            this.bezel.AutoSize = true;
            this.bezel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezel.ForeColor = System.Drawing.Color.Red;
            this.bezel.Location = new System.Drawing.Point(12, 342);
            this.bezel.Name = "bezel";
            this.bezel.Size = new System.Drawing.Size(0, 22);
            this.bezel.TabIndex = 4;
            // 
            // bulb
            // 
            this.bulb.AutoSize = true;
            this.bulb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulb.ForeColor = System.Drawing.Color.Red;
            this.bulb.Location = new System.Drawing.Point(12, 307);
            this.bulb.Name = "bulb";
            this.bulb.Size = new System.Drawing.Size(0, 22);
            this.bulb.TabIndex = 5;
            // 
            // lens
            // 
            this.lens.AutoSize = true;
            this.lens.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lens.ForeColor = System.Drawing.Color.Red;
            this.lens.Location = new System.Drawing.Point(12, 271);
            this.lens.Name = "lens";
            this.lens.Size = new System.Drawing.Size(0, 22);
            this.lens.TabIndex = 6;
            // 
            // reflector
            // 
            this.reflector.AutoSize = true;
            this.reflector.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflector.ForeColor = System.Drawing.Color.Red;
            this.reflector.Location = new System.Drawing.Point(12, 235);
            this.reflector.Name = "reflector";
            this.reflector.Size = new System.Drawing.Size(0, 22);
            this.reflector.TabIndex = 7;
            // 
            // housing
            // 
            this.housing.AutoSize = true;
            this.housing.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housing.ForeColor = System.Drawing.Color.Red;
            this.housing.Location = new System.Drawing.Point(12, 199);
            this.housing.Name = "housing";
            this.housing.Size = new System.Drawing.Size(0, 22);
            this.housing.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.housing);
            this.Controls.Add(this.reflector);
            this.Controls.Add(this.lens);
            this.Controls.Add(this.bulb);
            this.Controls.Add(this.bezel);
            this.Controls.Add(this.harness);
            this.Controls.Add(this.run);
            this.Controls.Add(this.KanbanGraph);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Visualisation";
            ((System.ComponentModel.ISupportInitialize)(this.KanbanGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart KanbanGraph;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label harness;
        private System.Windows.Forms.Label bezel;
        private System.Windows.Forms.Label bulb;
        private System.Windows.Forms.Label lens;
        private System.Windows.Forms.Label reflector;
        private System.Windows.Forms.Label housing;
    }
}

