﻿namespace PeopleCount
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fulladdressBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.arsenDataSet9 = new PeopleCount.arsenDataSet9();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.arsenDataSet4 = new PeopleCount.arsenDataSet4();
            this.newTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newTableTableAdapter = new PeopleCount.arsenDataSet4TableAdapters.NewTableTableAdapter();
            this.arsenDataSet7 = new PeopleCount.arsenDataSet7();
            this.fulladdressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.full_addressTableAdapter = new PeopleCount.arsenDataSet7TableAdapters.full_addressTableAdapter();
            this.arsenDataSet8 = new PeopleCount.arsenDataSet8();
            this.fulladdressBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.full_addressTableAdapter1 = new PeopleCount.arsenDataSet8TableAdapters.full_addressTableAdapter();
            this.full_addressTableAdapter2 = new PeopleCount.arsenDataSet9TableAdapters.full_addressTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fulladdressBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulladdressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulladdressBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(742, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fulladdressBindingSource2;
            this.comboBox1.DisplayMember = "address";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "address";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fulladdressBindingSource2
            // 
            this.fulladdressBindingSource2.DataMember = "full_address";
            this.fulladdressBindingSource2.DataSource = this.arsenDataSet9;
            // 
            // arsenDataSet9
            // 
            this.arsenDataSet9.DataSetName = "arsenDataSet9";
            this.arsenDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Расчет потенциальной выгоды по жилым домам";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Офиц.число жителей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Факт.число жителей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выгода (руб)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(262, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дом №";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(251, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Сайсарского полигона";
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
            // arsenDataSet7
            // 
            this.arsenDataSet7.DataSetName = "arsenDataSet7";
            this.arsenDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fulladdressBindingSource
            // 
            this.fulladdressBindingSource.DataMember = "full_address";
            this.fulladdressBindingSource.DataSource = this.arsenDataSet7;
            // 
            // full_addressTableAdapter
            // 
            this.full_addressTableAdapter.ClearBeforeFill = true;
            // 
            // arsenDataSet8
            // 
            this.arsenDataSet8.DataSetName = "arsenDataSet8";
            this.arsenDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fulladdressBindingSource1
            // 
            this.fulladdressBindingSource1.DataMember = "full_address";
            this.fulladdressBindingSource1.DataSource = this.arsenDataSet8;
            // 
            // full_addressTableAdapter1
            // 
            this.full_addressTableAdapter1.ClearBeforeFill = true;
            // 
            // full_addressTableAdapter2
            // 
            this.full_addressTableAdapter2.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleCount";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fulladdressBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulladdressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsenDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulladdressBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private arsenDataSet4 arsenDataSet4;
        private System.Windows.Forms.BindingSource newTableBindingSource;
        private arsenDataSet4TableAdapters.NewTableTableAdapter newTableTableAdapter;
        private arsenDataSet7 arsenDataSet7;
        private System.Windows.Forms.BindingSource fulladdressBindingSource;
        private arsenDataSet7TableAdapters.full_addressTableAdapter full_addressTableAdapter;
        private arsenDataSet8 arsenDataSet8;
        private System.Windows.Forms.BindingSource fulladdressBindingSource1;
        private arsenDataSet8TableAdapters.full_addressTableAdapter full_addressTableAdapter1;
        private arsenDataSet9 arsenDataSet9;
        private System.Windows.Forms.BindingSource fulladdressBindingSource2;
        private arsenDataSet9TableAdapters.full_addressTableAdapter full_addressTableAdapter2;
    }
}