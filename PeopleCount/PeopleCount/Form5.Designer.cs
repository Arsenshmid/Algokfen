namespace PeopleCount
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.счетчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arsenDataSet5 = new PeopleCount.arsenDataSet5();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.счетчикиTableAdapter = new PeopleCount.arsenDataSet5TableAdapters.счетчикиTableAdapter();
            this.arsenDataSet14 = new PeopleCount.arsenDataSet14();
            this.счетчикиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.счетчикиTableAdapter1 = new PeopleCount.arsenDataSet14TableAdapters.счетчикиTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arsenDataSet15 = new PeopleCount.arsenDataSet15();
            this.счетчикиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.счетчикиTableAdapter2 = new PeopleCount.arsenDataSet15TableAdapters.счетчикиTableAdapter();
            this.idhouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показанияПоДомуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.счетчикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетчикиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетчикиBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // счетчикиBindingSource
            // 
            this.счетчикиBindingSource.DataMember = "счетчики";
            this.счетчикиBindingSource.DataSource = this.arsenDataSet5;
            // 
            // arsenDataSet5
            // 
            this.arsenDataSet5.DataSetName = "arsenDataSet5";
            this.arsenDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(322, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "показания счетчиков";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(730, 606);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // счетчикиTableAdapter
            // 
            this.счетчикиTableAdapter.ClearBeforeFill = true;
            // 
            // arsenDataSet14
            // 
            this.arsenDataSet14.DataSetName = "arsenDataSet14";
            this.arsenDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счетчикиBindingSource1
            // 
            this.счетчикиBindingSource1.DataMember = "счетчики";
            this.счетчикиBindingSource1.DataSource = this.arsenDataSet14;
            // 
            // счетчикиTableAdapter1
            // 
            this.счетчикиTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhouseDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.показанияПоДомуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.счетчикиBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(67, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 521);
            this.dataGridView1.TabIndex = 5;
            // 
            // arsenDataSet15
            // 
            this.arsenDataSet15.DataSetName = "arsenDataSet15";
            this.arsenDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счетчикиBindingSource2
            // 
            this.счетчикиBindingSource2.DataMember = "счетчики";
            this.счетчикиBindingSource2.DataSource = this.arsenDataSet15;
            // 
            // счетчикиTableAdapter2
            // 
            this.счетчикиTableAdapter2.ClearBeforeFill = true;
            // 
            // idhouseDataGridViewTextBoxColumn
            // 
            this.idhouseDataGridViewTextBoxColumn.DataPropertyName = "id_house";
            this.idhouseDataGridViewTextBoxColumn.HeaderText = "id_house";
            this.idhouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idhouseDataGridViewTextBoxColumn.Name = "idhouseDataGridViewTextBoxColumn";
            this.idhouseDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // показанияПоДомуDataGridViewTextBoxColumn
            // 
            this.показанияПоДомуDataGridViewTextBoxColumn.DataPropertyName = "показанияПоДому";
            this.показанияПоДомуDataGridViewTextBoxColumn.HeaderText = "показанияПоДому";
            this.показанияПоДомуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.показанияПоДомуDataGridViewTextBoxColumn.Name = "показанияПоДомуDataGridViewTextBoxColumn";
            this.показанияПоДомуDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 672);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleCount";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.счетчикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетчикиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетчикиBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private arsenDataSet5 arsenDataSet5;
        private System.Windows.Forms.BindingSource счетчикиBindingSource;
        private arsenDataSet5TableAdapters.счетчикиTableAdapter счетчикиTableAdapter;
        private arsenDataSet14 arsenDataSet14;
        private System.Windows.Forms.BindingSource счетчикиBindingSource1;
        private arsenDataSet14TableAdapters.счетчикиTableAdapter счетчикиTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private arsenDataSet15 arsenDataSet15;
        private System.Windows.Forms.BindingSource счетчикиBindingSource2;
        private arsenDataSet15TableAdapters.счетчикиTableAdapter счетчикиTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn показанияПоДомуDataGridViewTextBoxColumn;
    }
}