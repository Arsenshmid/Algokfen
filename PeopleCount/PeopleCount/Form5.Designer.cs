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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idhouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показанияПоДомуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.счетчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arsenDataSet5 = new PeopleCount.arsenDataSet5();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.счетчикиTableAdapter = new PeopleCount.arsenDataSet5TableAdapters.счетчикиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетчикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhouseDataGridViewTextBoxColumn,
            this.показанияПоДомуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.счетчикиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // idhouseDataGridViewTextBoxColumn
            // 
            this.idhouseDataGridViewTextBoxColumn.DataPropertyName = "id_house";
            this.idhouseDataGridViewTextBoxColumn.HeaderText = "id_house";
            this.idhouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idhouseDataGridViewTextBoxColumn.Name = "idhouseDataGridViewTextBoxColumn";
            this.idhouseDataGridViewTextBoxColumn.Width = 125;
            // 
            // показанияПоДомуDataGridViewTextBoxColumn
            // 
            this.показанияПоДомуDataGridViewTextBoxColumn.DataPropertyName = "показанияПоДому";
            this.показанияПоДомуDataGridViewTextBoxColumn.HeaderText = "показанияПоДому";
            this.показанияПоДомуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.показанияПоДомуDataGridViewTextBoxColumn.Name = "показанияПоДомуDataGridViewTextBoxColumn";
            this.показанияПоДомуDataGridViewTextBoxColumn.Width = 125;
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
            this.label1.Location = new System.Drawing.Point(195, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "показания счетчиков";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(498, 563);
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 672);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleCount";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетчикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private arsenDataSet5 arsenDataSet5;
        private System.Windows.Forms.BindingSource счетчикиBindingSource;
        private arsenDataSet5TableAdapters.счетчикиTableAdapter счетчикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn показанияПоДомуDataGridViewTextBoxColumn;
    }
}