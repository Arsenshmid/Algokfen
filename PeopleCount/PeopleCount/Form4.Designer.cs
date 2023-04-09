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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.фактическоеЧислоЖителейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arsenDataSet6 = new PeopleCount.arsenDataSet6();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.фактическоеЧислоЖителейTableAdapter = new PeopleCount.arsenDataSet6TableAdapters.ФактическоеЧислоЖителейTableAdapter();
            this.arsenDataSet10 = new PeopleCount.arsenDataSet10();
            this.новаяТаблицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.новаяТаблицаTableAdapter = new PeopleCount.arsenDataSet10TableAdapters.НоваяТаблицаTableAdapter();
            this.arsenDataSet11 = new PeopleCount.arsenDataSet11();
            this.новаяТаблицаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.новаяТаблицаTableAdapter1 = new PeopleCount.arsenDataSet11TableAdapters.НоваяТаблицаTableAdapter();
            this.arsenDataSet12 = new PeopleCount.arsenDataSet12();
            this.новаяТаблицаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.новаяТаблицаTableAdapter2 = new PeopleCount.arsenDataSet12TableAdapters.НоваяТаблицаTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrstreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrhou1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.официальноечисложителейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактическоечисложителейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выгодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.новаяТаблицаBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.arsenDataSet13 = new PeopleCount.arsenDataSet13();
            this.новаяТаблицаTableAdapter3 = new PeopleCount.arsenDataSet13TableAdapters.НоваяТаблицаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.фактическоеЧислоЖителейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.новаяТаблицаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.новаяТаблицаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.новаяТаблицаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.новаяТаблицаBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "информация о фактическом количестве жителей в домах";
            // 
            // фактическоеЧислоЖителейBindingSource
            // 
            this.фактическоеЧислоЖителейBindingSource.DataMember = "ФактическоеЧислоЖителей";
            this.фактическоеЧислоЖителейBindingSource.DataSource = this.arsenDataSet6;
            // 
            // arsenDataSet6
            // 
            this.arsenDataSet6.DataSetName = "arsenDataSet6";
            this.arsenDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "редактировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(933, 508);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // фактическоеЧислоЖителейTableAdapter
            // 
            this.фактическоеЧислоЖителейTableAdapter.ClearBeforeFill = true;
            // 
            // arsenDataSet10
            // 
            this.arsenDataSet10.DataSetName = "arsenDataSet10";
            this.arsenDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // новаяТаблицаBindingSource
            // 
            this.новаяТаблицаBindingSource.DataMember = "НоваяТаблица";
            this.новаяТаблицаBindingSource.DataSource = this.arsenDataSet10;
            // 
            // новаяТаблицаTableAdapter
            // 
            this.новаяТаблицаTableAdapter.ClearBeforeFill = true;
            // 
            // arsenDataSet11
            // 
            this.arsenDataSet11.DataSetName = "arsenDataSet11";
            this.arsenDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // новаяТаблицаBindingSource1
            // 
            this.новаяТаблицаBindingSource1.DataMember = "НоваяТаблица";
            this.новаяТаблицаBindingSource1.DataSource = this.arsenDataSet11;
            // 
            // новаяТаблицаTableAdapter1
            // 
            this.новаяТаблицаTableAdapter1.ClearBeforeFill = true;
            // 
            // arsenDataSet12
            // 
            this.arsenDataSet12.DataSetName = "arsenDataSet12";
            this.arsenDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // новаяТаблицаBindingSource2
            // 
            this.новаяТаблицаBindingSource2.DataMember = "НоваяТаблица";
            this.новаяТаблицаBindingSource2.DataSource = this.arsenDataSet12;
            // 
            // новаяТаблицаTableAdapter2
            // 
            this.новаяТаблицаTableAdapter2.ClearBeforeFill = true;
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
            this.официальноечисложителейDataGridViewTextBoxColumn,
            this.фактическоечисложителейDataGridViewTextBoxColumn,
            this.выгодаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.новаяТаблицаBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(69, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 429);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // официальноечисложителейDataGridViewTextBoxColumn
            // 
            this.официальноечисложителейDataGridViewTextBoxColumn.DataPropertyName = "официальное_число_жителей";
            this.официальноечисложителейDataGridViewTextBoxColumn.HeaderText = "официальное_число_жителей";
            this.официальноечисложителейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.официальноечисложителейDataGridViewTextBoxColumn.Name = "официальноечисложителейDataGridViewTextBoxColumn";
            this.официальноечисложителейDataGridViewTextBoxColumn.Width = 125;
            // 
            // фактическоечисложителейDataGridViewTextBoxColumn
            // 
            this.фактическоечисложителейDataGridViewTextBoxColumn.DataPropertyName = "фактическое_число_жителей";
            this.фактическоечисложителейDataGridViewTextBoxColumn.HeaderText = "фактическое_число_жителей";
            this.фактическоечисложителейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фактическоечисложителейDataGridViewTextBoxColumn.Name = "фактическоечисложителейDataGridViewTextBoxColumn";
            this.фактическоечисложителейDataGridViewTextBoxColumn.Width = 125;
            // 
            // выгодаDataGridViewTextBoxColumn
            // 
            this.выгодаDataGridViewTextBoxColumn.DataPropertyName = "выгода";
            this.выгодаDataGridViewTextBoxColumn.HeaderText = "выгода";
            this.выгодаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.выгодаDataGridViewTextBoxColumn.Name = "выгодаDataGridViewTextBoxColumn";
            this.выгодаDataGridViewTextBoxColumn.Width = 125;
            // 
            // новаяТаблицаBindingSource3
            // 
            this.новаяТаблицаBindingSource3.DataMember = "НоваяТаблица";
            this.новаяТаблицаBindingSource3.DataSource = this.arsenDataSet13;
            // 
            // arsenDataSet13
            // 
            this.arsenDataSet13.DataSetName = "arsenDataSet13";
            this.arsenDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // новаяТаблицаTableAdapter3
            // 
            this.новаяТаблицаTableAdapter3.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleCount";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.фактическоеЧислоЖителейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.новаяТаблицаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.новаяТаблицаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.новаяТаблицаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.новаяТаблицаBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private arsenDataSet6 arsenDataSet6;
        private System.Windows.Forms.BindingSource фактическоеЧислоЖителейBindingSource;
        private arsenDataSet6TableAdapters.ФактическоеЧислоЖителейTableAdapter фактическоеЧислоЖителейTableAdapter;
        private arsenDataSet10 arsenDataSet10;
        private System.Windows.Forms.BindingSource новаяТаблицаBindingSource;
        private arsenDataSet10TableAdapters.НоваяТаблицаTableAdapter новаяТаблицаTableAdapter;
        private arsenDataSet11 arsenDataSet11;
        private System.Windows.Forms.BindingSource новаяТаблицаBindingSource1;
        private arsenDataSet11TableAdapters.НоваяТаблицаTableAdapter новаяТаблицаTableAdapter1;
        private arsenDataSet12 arsenDataSet12;
        private System.Windows.Forms.BindingSource новаяТаблицаBindingSource2;
        private arsenDataSet12TableAdapters.НоваяТаблицаTableAdapter новаяТаблицаTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private arsenDataSet13 arsenDataSet13;
        private System.Windows.Forms.BindingSource новаяТаблицаBindingSource3;
        private arsenDataSet13TableAdapters.НоваяТаблицаTableAdapter новаяТаблицаTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrstreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrhou1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn официальноечисложителейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактическоечисложителейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn выгодаDataGridViewTextBoxColumn;
    }
}