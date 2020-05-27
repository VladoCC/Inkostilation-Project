namespace WindowsFormsApp1
{
    partial class OperationsOfClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsOfClient));
            this.ClientsKey = new System.Windows.Forms.DataGridView();
            this.Hash1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Банк = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationsData = new System.Windows.Forms.DataGridView();
            this.ТипОперации1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерБанкомата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СуммаОперации = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsData)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsKey
            // 
            this.ClientsKey.AllowUserToAddRows = false;
            this.ClientsKey.AllowUserToDeleteRows = false;
            this.ClientsKey.AllowUserToResizeColumns = false;
            this.ClientsKey.AllowUserToResizeRows = false;
            this.ClientsKey.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientsKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsKey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hash1,
            this.НомерКарточки,
            this.Банк,
            this.ФИО});
            this.ClientsKey.Location = new System.Drawing.Point(27, 52);
            this.ClientsKey.MultiSelect = false;
            this.ClientsKey.Name = "ClientsKey";
            this.ClientsKey.ReadOnly = true;
            this.ClientsKey.RowHeadersVisible = false;
            this.ClientsKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsKey.Size = new System.Drawing.Size(300, 464);
            this.ClientsKey.TabIndex = 1;
            this.ClientsKey.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsKey_CellClick);
            // 
            // Hash1
            // 
            this.Hash1.HeaderText = "Хеш адрес";
            this.Hash1.Name = "Hash1";
            this.Hash1.ReadOnly = true;
            this.Hash1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hash1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hash1.Width = 60;
            // 
            // НомерКарточки
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НомерКарточки.DefaultCellStyle = dataGridViewCellStyle1;
            this.НомерКарточки.HeaderText = "Номер карточки";
            this.НомерКарточки.Name = "НомерКарточки";
            this.НомерКарточки.ReadOnly = true;
            this.НомерКарточки.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.НомерКарточки.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.НомерКарточки.Width = 65;
            // 
            // Банк
            // 
            this.Банк.HeaderText = "Банк";
            this.Банк.Name = "Банк";
            this.Банк.ReadOnly = true;
            this.Банк.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Банк.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Банк.Width = 80;
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            this.ФИО.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ФИО.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ФИО.Width = 92;
            // 
            // OperationsData
            // 
            this.OperationsData.AllowUserToAddRows = false;
            this.OperationsData.AllowUserToDeleteRows = false;
            this.OperationsData.AllowUserToResizeColumns = false;
            this.OperationsData.AllowUserToResizeRows = false;
            this.OperationsData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.OperationsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ТипОперации1,
            this.НомерКарточки1,
            this.НомерБанкомата,
            this.СуммаОперации});
            this.OperationsData.Location = new System.Drawing.Point(348, 52);
            this.OperationsData.MultiSelect = false;
            this.OperationsData.Name = "OperationsData";
            this.OperationsData.ReadOnly = true;
            this.OperationsData.RowHeadersVisible = false;
            this.OperationsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperationsData.Size = new System.Drawing.Size(300, 464);
            this.OperationsData.TabIndex = 3;
            // 
            // ТипОперации1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ТипОперации1.DefaultCellStyle = dataGridViewCellStyle2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(123, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(433, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Операция";
            // 
            // OperationsOfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OperationsData);
            this.Controls.Add(this.ClientsKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperationsOfClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт \"Операции клиентов\"";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ClientsKey;
        public System.Windows.Forms.DataGridView OperationsData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Банк;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТипОперации1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерБанкомата;
        private System.Windows.Forms.DataGridViewTextBoxColumn СуммаОперации;
    }
}