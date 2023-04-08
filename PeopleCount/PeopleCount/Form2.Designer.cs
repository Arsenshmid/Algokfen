namespace PeopleCount
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.arsenDataSet = new PeopleCount.arsenDataSet();
            this.saisarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saisarTableAdapter = new PeopleCount.arsenDataSetTableAdapters.saisarTableAdapter();
            this.arsenDataSet2 = new PeopleCount.arsenDataSet2();
            this.newSaisarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newSaisarTableAdapter = new PeopleCount.arsenDataSet2TableAdapters.NewSaisarTableAdapter();
            this.arsenDataSet3 = new PeopleCount.arsenDataSet3();
            this.newSaisarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newSaisarTableAdapter1 = new PeopleCount.arsenDataSet3TableAdapters.NewSaisarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arsenDataSet4 = new PeopleCount.arsenDataSet4();
            this.newTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newTableTableAdapter = new PeopleCount.arsenDataSet4TableAdapters.NewTableTableAdapter();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrstreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrhou1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числожителейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saisarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSaisarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSaisarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(717, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "редактировать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(717, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "официальные данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(717, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "показания счтчиков";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(717, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 66);
            this.button6.TabIndex = 6;
            this.button6.Text = "выгрузка в Excel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // arsenDataSet
            // 
            this.arsenDataSet.DataSetName = "arsenDataSet";
            this.arsenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saisarBindingSource
            // 
            this.saisarBindingSource.DataMember = "saisar";
            this.saisarBindingSource.DataSource = this.arsenDataSet;
            // 
            // saisarTableAdapter
            // 
            this.saisarTableAdapter.ClearBeforeFill = true;
            // 
            // arsenDataSet2
            // 
            this.arsenDataSet2.DataSetName = "arsenDataSet2";
            this.arsenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newSaisarBindingSource
            // 
            this.newSaisarBindingSource.DataMember = "NewSaisar";
            this.newSaisarBindingSource.DataSource = this.arsenDataSet2;
            // 
            // newSaisarTableAdapter
            // 
            this.newSaisarTableAdapter.ClearBeforeFill = true;
            // 
            // arsenDataSet3
            // 
            this.arsenDataSet3.DataSetName = "arsenDataSet3";
            this.arsenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newSaisarBindingSource1
            // 
            this.newSaisarBindingSource1.DataMember = "NewSaisar";
            this.newSaisarBindingSource1.DataSource = this.arsenDataSet3;
            // 
            // newSaisarTableAdapter1
            // 
            this.newSaisarTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingDataGridViewTextBoxColumn,
            this.addrstreeDataGridViewTextBoxColumn,
            this.addrhou1DataGridViewTextBoxColumn,
            this.числожителейDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 335);
            this.dataGridView1.TabIndex = 7;
            // 
            // arsenDataSet4
            // 
            this.arsenDataSet4.DataSetName = "arsenDataSet4";
            this.arsenDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newTableBindingSource
            // 
            this.newTableBindingSource.DataMember = "NewTable";
            this.newTableBindingSource.DataSource = this.arsenDataSet4;
            // 
            // newTableTableAdapter
            // 
            this.newTableTableAdapter.ClearBeforeFill = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация по Сайсарскому округу";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saisarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSaisarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSaisarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private arsenDataSet arsenDataSet;
        private System.Windows.Forms.BindingSource saisarBindingSource;
        private arsenDataSetTableAdapters.saisarTableAdapter saisarTableAdapter;
        private arsenDataSet2 arsenDataSet2;
        private System.Windows.Forms.BindingSource newSaisarBindingSource;
        private arsenDataSet2TableAdapters.NewSaisarTableAdapter newSaisarTableAdapter;
        private arsenDataSet3 arsenDataSet3;
        private System.Windows.Forms.BindingSource newSaisarBindingSource1;
        private arsenDataSet3TableAdapters.NewSaisarTableAdapter newSaisarTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private arsenDataSet4 arsenDataSet4;
        private System.Windows.Forms.BindingSource newTableBindingSource;
        private arsenDataSet4TableAdapters.NewTableTableAdapter newTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrstreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrhou1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числожителейDataGridViewTextBoxColumn;
    }
}