namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pavilionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numpavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costmeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coeffcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavilionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numpavDataGridViewTextBoxColumn,
            this.iDmallDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.squareDataGridViewTextBoxColumn,
            this.costmeterDataGridViewTextBoxColumn,
            this.coeffcostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pavilionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(101, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pavilionBindingSource
            // 
            this.pavilionBindingSource.DataSource = typeof(WindowsFormsApp1.model.Pavilion);
            // 
            // numpavDataGridViewTextBoxColumn
            // 
            this.numpavDataGridViewTextBoxColumn.DataPropertyName = "Num_pav";
            this.numpavDataGridViewTextBoxColumn.HeaderText = "Num_pav";
            this.numpavDataGridViewTextBoxColumn.Name = "numpavDataGridViewTextBoxColumn";
            // 
            // iDmallDataGridViewTextBoxColumn
            // 
            this.iDmallDataGridViewTextBoxColumn.DataPropertyName = "ID_mall";
            this.iDmallDataGridViewTextBoxColumn.HeaderText = "ID_mall";
            this.iDmallDataGridViewTextBoxColumn.Name = "iDmallDataGridViewTextBoxColumn";
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // squareDataGridViewTextBoxColumn
            // 
            this.squareDataGridViewTextBoxColumn.DataPropertyName = "Square";
            this.squareDataGridViewTextBoxColumn.HeaderText = "Square";
            this.squareDataGridViewTextBoxColumn.Name = "squareDataGridViewTextBoxColumn";
            // 
            // costmeterDataGridViewTextBoxColumn
            // 
            this.costmeterDataGridViewTextBoxColumn.DataPropertyName = "Cost_meter";
            this.costmeterDataGridViewTextBoxColumn.HeaderText = "Cost_meter";
            this.costmeterDataGridViewTextBoxColumn.Name = "costmeterDataGridViewTextBoxColumn";
            // 
            // coeffcostDataGridViewTextBoxColumn
            // 
            this.coeffcostDataGridViewTextBoxColumn.DataPropertyName = "Coeff_cost";
            this.coeffcostDataGridViewTextBoxColumn.HeaderText = "Coeff_cost";
            this.coeffcostDataGridViewTextBoxColumn.Name = "coeffcostDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИЛЬТРАЦИЯ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 154);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "СТАТУС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "СОРТИРОВКА";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(270, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "ПО УБЫВАНИЮ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavilionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numpavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costmeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coeffcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pavilionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

