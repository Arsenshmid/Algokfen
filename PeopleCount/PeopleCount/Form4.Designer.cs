namespace PeopleCount
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.arsenDataSet6 = new PeopleCount.arsenDataSet6();
            this.фактическоеЧислоЖителейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фактическоеЧислоЖителейTableAdapter = new PeopleCount.arsenDataSet6TableAdapters.ФактическоеЧислоЖителейTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrstreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrhou1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числожителейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фактическоеЧислоЖителейBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "информация о фактическом количестве жителей в домах";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.buildingDataGridViewTextBoxColumn,
            this.addrstreeDataGridViewTextBoxColumn,
            this.addrhou1DataGridViewTextBoxColumn,
            this.числожителейDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.фактическоеЧислоЖителейBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "редактировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(746, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // arsenDataSet6
            // 
            this.arsenDataSet6.DataSetName = "arsenDataSet6";
            this.arsenDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фактическоеЧислоЖителейBindingSource
            // 
            this.фактическоеЧислоЖителейBindingSource.DataMember = "ФактическоеЧислоЖителей";
            this.фактическоеЧислоЖителейBindingSource.DataSource = this.arsenDataSet6;
            // 
            // фактическоеЧислоЖителейTableAdapter
            // 
            this.фактическоеЧислоЖителейTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildingDataGridViewTextBoxColumn
            // 
            this.buildingDataGridViewTextBoxColumn.DataPropertyName = "\"building\"";
            this.buildingDataGridViewTextBoxColumn.HeaderText = "\"building\"";
            this.buildingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingDataGridViewTextBoxColumn.Name = "buildingDataGridViewTextBoxColumn";
            this.buildingDataGridViewTextBoxColumn.Width = 125;
            // 
            // addrstreeDataGridViewTextBoxColumn
            // 
            this.addrstreeDataGridViewTextBoxColumn.DataPropertyName = "\"addr_stree\"";
            this.addrstreeDataGridViewTextBoxColumn.HeaderText = "\"addr_stree\"";
            this.addrstreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addrstreeDataGridViewTextBoxColumn.Name = "addrstreeDataGridViewTextBoxColumn";
            this.addrstreeDataGridViewTextBoxColumn.Width = 125;
            // 
            // addrhou1DataGridViewTextBoxColumn
            // 
            this.addrhou1DataGridViewTextBoxColumn.DataPropertyName = "\"addr_hou_1\"";
            this.addrhou1DataGridViewTextBoxColumn.HeaderText = "\"addr_hou_1\"";
            this.addrhou1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addrhou1DataGridViewTextBoxColumn.Name = "addrhou1DataGridViewTextBoxColumn";
            this.addrhou1DataGridViewTextBoxColumn.Width = 125;
            // 
            // числожителейDataGridViewTextBoxColumn
            // 
            this.числожителейDataGridViewTextBoxColumn.DataPropertyName = "число_жителей";
            this.числожителейDataGridViewTextBoxColumn.HeaderText = "число_жителей";
            this.числожителейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.числожителейDataGridViewTextBoxColumn.Name = "числожителейDataGridViewTextBoxColumn";
            this.числожителейDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фактическоеЧислоЖителейBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private arsenDataSet6 arsenDataSet6;
        private System.Windows.Forms.BindingSource фактическоеЧислоЖителейBindingSource;
        private arsenDataSet6TableAdapters.ФактическоеЧислоЖителейTableAdapter фактическоеЧислоЖителейTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrstreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrhou1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числожителейDataGridViewTextBoxColumn;
    }
}