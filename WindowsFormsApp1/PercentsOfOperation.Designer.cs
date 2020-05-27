namespace WindowsFormsApp1
{
    partial class PercentsOfOperation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PercentsOfOperation));
            this.OperationsKey = new System.Windows.Forms.DataGridView();
            this.ТипОперации1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерБанкомата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СуммаОперации = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentsData = new System.Windows.Forms.DataGridView();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отправитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Получатель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Процент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentsData)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsKey
            // 
            this.OperationsKey.AllowUserToAddRows = false;
            this.OperationsKey.AllowUserToDeleteRows = false;
            this.OperationsKey.AllowUserToResizeColumns = false;
            this.OperationsKey.AllowUserToResizeRows = false;
            this.OperationsKey.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.OperationsKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsKey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ТипОперации1,
            this.НомерКарточки1,
            this.НомерБанкомата,
            this.СуммаОперации});
            this.OperationsKey.Location = new System.Drawing.Point(27, 56);
            this.OperationsKey.MultiSelect = false;
            this.OperationsKey.Name = "OperationsKey";
            this.OperationsKey.ReadOnly = true;
            this.OperationsKey.RowHeadersVisible = false;
            this.OperationsKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperationsKey.Size = new System.Drawing.Size(300, 464);
            this.OperationsKey.TabIndex = 1;
            this.OperationsKey.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OperationsKey_CellClick);
            // 
            // ТипОперации1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ТипОперации1.DefaultCellStyle = dataGridViewCellStyle1;
            this.ТипОперации1.HeaderText = "Название операции";
            this.ТипОперации1.Name = "ТипОперации1";
            this.ТипОперации1.ReadOnly = true;
            this.ТипОперации1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ТипОперации1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ТипОперации1.Width = 70;
            // 
            // НомерКарточки1
            // 
            this.НомерКарточки1.HeaderText = "Номер карточки";
            this.НомерКарточки1.Name = "НомерКарточки1";
            this.НомерКарточки1.ReadOnly = true;
            this.НомерКарточки1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.НомерКарточки1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.НомерКарточки1.Width = 85;
            // 
            // НомерБанкомата
            // 
            this.НомерБанкомата.HeaderText = "Номер банкомата";
            this.НомерБанкомата.Name = "НомерБанкомата";
            this.НомерБанкомата.ReadOnly = true;
            this.НомерБанкомата.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.НомерБанкомата.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.НомерБанкомата.Width = 75;
            // 
            // СуммаОперации
            // 
            this.СуммаОперации.HeaderText = "Сумма операции";
            this.СуммаОперации.Name = "СуммаОперации";
            this.СуммаОперации.ReadOnly = true;
            this.СуммаОперации.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.СуммаОперации.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.СуммаОперации.Width = 67;
            // 
            // PercentsData
            // 
            this.PercentsData.AllowUserToAddRows = false;
            this.PercentsData.AllowUserToDeleteRows = false;
            this.PercentsData.AllowUserToResizeColumns = false;
            this.PercentsData.AllowUserToResizeRows = false;
            this.PercentsData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PercentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PercentsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Тип,
            this.Отправитель,
            this.Получатель,
            this.Процент});
            this.PercentsData.Location = new System.Drawing.Point(346, 56);
            this.PercentsData.MultiSelect = false;
            this.PercentsData.Name = "PercentsData";
            this.PercentsData.ReadOnly = true;
            this.PercentsData.RowHeadersVisible = false;
            this.PercentsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PercentsData.Size = new System.Drawing.Size(300, 464);
            this.PercentsData.TabIndex = 3;
            // 
            // Тип
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Тип.DefaultCellStyle = dataGridViewCellStyle2;
            this.Тип.HeaderText = "Название операции";
            this.Тип.Name = "Тип";
            this.Тип.ReadOnly = true;
            this.Тип.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Тип.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Тип.Width = 65;
            // 
            // Отправитель
            // 
            this.Отправитель.HeaderText = "Отправитель";
            this.Отправитель.Name = "Отправитель";
            this.Отправитель.ReadOnly = true;
            this.Отправитель.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Отправитель.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Отправитель.Width = 80;
            // 
            // Получатель
            // 
            this.Получатель.HeaderText = "Получатель";
            this.Получатель.Name = "Получатель";
            this.Получатель.ReadOnly = true;
            this.Получатель.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Получатель.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Получатель.Width = 85;
            // 
            // Процент
            // 
            this.Процент.HeaderText = "Процент";
            this.Процент.Name = "Процент";
            this.Процент.ReadOnly = true;
            this.Процент.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Процент.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Процент.Width = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(111, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Операция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(442, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Процент";
            // 
            // PercentsOfOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PercentsData);
            this.Controls.Add(this.OperationsKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PercentsOfOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт \"Проценты операций\"";
            ((System.ComponentModel.ISupportInitialize)(this.OperationsKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView OperationsKey;
        public System.Windows.Forms.DataGridView PercentsData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТипОперации1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерБанкомата;
        private System.Windows.Forms.DataGridViewTextBoxColumn СуммаОперации;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отправитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Получатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Процент;
    }
}