namespace scada_bitirme
{
    partial class LogsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGrid_logs = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_musluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart_logs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_logs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_logs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_logs
            // 
            this.dataGrid_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_logs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.log_turu,
            this.log_value,
            this.log_musluk,
            this.update_date});
            this.dataGrid_logs.Location = new System.Drawing.Point(585, 12);
            this.dataGrid_logs.Name = "dataGrid_logs";
            this.dataGrid_logs.Size = new System.Drawing.Size(586, 426);
            this.dataGrid_logs.TabIndex = 0;
            // 
            // username
            // 
            this.username.DataPropertyName = "log_username";
            this.username.HeaderText = "Kullanıcı Adı";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // log_turu
            // 
            this.log_turu.DataPropertyName = "log_turu";
            this.log_turu.HeaderText = "Kazan/Kuyu Adı";
            this.log_turu.Name = "log_turu";
            this.log_turu.ReadOnly = true;
            // 
            // log_value
            // 
            this.log_value.DataPropertyName = "log_value";
            this.log_value.HeaderText = "Su Değeri";
            this.log_value.Name = "log_value";
            this.log_value.ReadOnly = true;
            // 
            // log_musluk
            // 
            this.log_musluk.DataPropertyName = "log_musluk";
            this.log_musluk.HeaderText = "Musluk";
            this.log_musluk.Name = "log_musluk";
            this.log_musluk.ReadOnly = true;
            // 
            // update_date
            // 
            this.update_date.DataPropertyName = "update_date";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.update_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.update_date.HeaderText = "Tarih";
            this.update_date.Name = "update_date";
            this.update_date.ReadOnly = true;
            this.update_date.Width = 120;
            // 
            // chart_logs
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_logs.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_logs.Legends.Add(legend1);
            this.chart_logs.Location = new System.Drawing.Point(12, 12);
            this.chart_logs.Name = "chart_logs";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Kazan2";
            this.chart_logs.Series.Add(series1);
            this.chart_logs.Size = new System.Drawing.Size(567, 426);
            this.chart_logs.TabIndex = 1;
            this.chart_logs.Text = "chart_logs";
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 460);
            this.Controls.Add(this.chart_logs);
            this.Controls.Add(this.dataGrid_logs);
            this.Name = "LogsForm";
            this.Text = "LogsForm";
            this.Load += new System.EventHandler(this.LogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_logs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_logs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_logs;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_musluk;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_logs;
    }
}