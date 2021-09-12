
namespace LineChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myDbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new LineChart.myDataSet();
            this.myDbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.myDbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chartDataDataSet1 = new LineChart.ChartDataDataSet1();
            this.myDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartDataDataSet = new LineChart.ChartDataDataSet();
            this.Load1 = new System.Windows.Forms.Button();
            this.myDbTableAdapter = new LineChart.ChartDataDataSetTableAdapters.MyDbTableAdapter();
            this.myDbTableAdapter1 = new LineChart.ChartDataDataSet1TableAdapters.MyDbTableAdapter();
            this.myDbTableAdapter2 = new LineChart.myDataSetTableAdapters.MyDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gray;
            this.chart1.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBorderColor = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.Name = "year";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelBorderColor = System.Drawing.Color.Red;
            series2.LabelForeColor = System.Drawing.Color.Gray;
            series2.Legend = "Legend1";
            series2.Name = "Month";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.LabelBorderColor = System.Drawing.Color.Red;
            series3.LabelForeColor = System.Drawing.Color.Gray;
            series3.Legend = "Legend1";
            series3.Name = "value";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1082, 450);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.myDbBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(0, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 215);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Width = 125;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 125;
            // 
            // myDbBindingSource3
            // 
            this.myDbBindingSource3.DataMember = "MyDb";
            this.myDbBindingSource3.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDbBindingSource2
            // 
            this.myDbBindingSource2.DataMember = "MyDb";
            this.myDbBindingSource2.DataSource = this.myDataSet;
            // 
            // myDbBindingSource1
            // 
            this.myDbBindingSource1.DataMember = "MyDb";
            this.myDbBindingSource1.DataSource = this.chartDataDataSet1;
            // 
            // chartDataDataSet1
            // 
            this.chartDataDataSet1.DataSetName = "ChartDataDataSet1";
            this.chartDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDbBindingSource
            // 
            this.myDbBindingSource.DataMember = "MyDb";
            this.myDbBindingSource.DataSource = this.chartDataDataSet;
            // 
            // chartDataDataSet
            // 
            this.chartDataDataSet.DataSetName = "ChartDataDataSet";
            this.chartDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Load1
            // 
            this.Load1.Location = new System.Drawing.Point(850, 677);
            this.Load1.Name = "Load1";
            this.Load1.Size = new System.Drawing.Size(157, 51);
            this.Load1.TabIndex = 2;
            this.Load1.Text = "Load1";
            this.Load1.UseVisualStyleBackColor = true;
            this.Load1.Click += new System.EventHandler(this.Load_Click);
            // 
            // myDbTableAdapter
            // 
            this.myDbTableAdapter.ClearBeforeFill = true;
            // 
            // myDbTableAdapter1
            // 
            this.myDbTableAdapter1.ClearBeforeFill = true;
            // 
            // myDbTableAdapter2
            // 
            this.myDbTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 797);
            this.Controls.Add(this.Load1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ChartDataDataSet chartDataDataSet;
        private System.Windows.Forms.BindingSource myDbBindingSource;
        private ChartDataDataSetTableAdapters.MyDbTableAdapter myDbTableAdapter;
        private ChartDataDataSet1 chartDataDataSet1;
        private System.Windows.Forms.BindingSource myDbBindingSource1;
        private ChartDataDataSet1TableAdapters.MyDbTableAdapter myDbTableAdapter1;
        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource myDbBindingSource2;
        private myDataSetTableAdapters.MyDbTableAdapter myDbTableAdapter2;
        public System.Windows.Forms.Button Load1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource myDbBindingSource3;
    }
}

