namespace WindowsFormsApp1
{
    partial class OperationsOfMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsOfMachine));
            this.MachinesKey = new System.Windows.Forms.DataGridView();
            this.Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НазваниеБанка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.OperationsData = new System.Windows.Forms.DataGridView();
            this.ТипОперации1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерБанкомата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СуммаОперации = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MachinesKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsData)).BeginInit();
            this.SuspendLayout();
            // 
            // MachinesKey
            // 
            this.MachinesKey.AllowUserToAddRows = false;
            this.MachinesKey.AllowUserToDeleteRows = false;
            this.MachinesKey.AllowUserToResizeColumns = false;
            this.MachinesKey.AllowUserToResizeRows = false;
            this.MachinesKey.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MachinesKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MachinesKey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hash,
            this.Номер,
            this.Адрес,
            this.НазваниеБанка});
            this.MachinesKey.Location = new System.Drawing.Point(32, 56);
            this.MachinesKey.MultiSelect = false;
            this.MachinesKey.Name = "MachinesKey";
            this.MachinesKey.ReadOnly = true;
            this.MachinesKey.RowHeadersVisible = false;
            this.MachinesKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MachinesKey.Size = new System.Drawing.Size(300, 464);
            this.MachinesKey.TabIndex = 1;
            this.MachinesKey.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MachinesKey_CellClick);
            // 
            // Hash
            // 
            this.Hash.HeaderText = "Хеш адрес";
            this.Hash.Name = "Hash";
            this.Hash.ReadOnly = true;
            this.Hash.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hash.Width = 60;
            // 
            // Номер
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Номер.DefaultCellStyle = dataGridViewCellStyle1;
            this.Номер.HeaderText = "Номер";
            this.Номер.Name = "Номер";
            this.Номер.ReadOnly = true;
            this.Номер.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Номер.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Номер.Width = 50;
            // 
            // Адрес
            // 
            this.Адрес.HeaderText = "Адрес";
            this.Адрес.Name = "Адрес";
            this.Адрес.ReadOnly = true;
            this.Адрес.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Адрес.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Адрес.Width = 97;
            // 
            // НазваниеБанка
            // 
            this.НазваниеБанка.HeaderText = "Название банка";
            this.НазваниеБанка.Name = "НазваниеБанка";
            this.НазваниеБанка.ReadOnly = true;
            this.НазваниеБанка.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.НазваниеБанка.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.НазваниеБанка.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(446, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Операция";
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
            this.OperationsData.Location = new System.Drawing.Point(348, 56);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Банкомат";
            // 
            // OperationsOfMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperationsData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MachinesKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperationsOfMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт \"Операции банкоматов\"";
            ((System.ComponentModel.ISupportInitialize)(this.MachinesKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView MachinesKey;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView OperationsData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn НазваниеБанка;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТипОперации1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерБанкомата;
        private System.Windows.Forms.DataGridViewTextBoxColumn СуммаОперации;
    }
}