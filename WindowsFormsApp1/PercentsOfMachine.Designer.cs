namespace WindowsFormsApp1
{
    partial class PercentsOfMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PercentsOfMachine));
            this.PercentsData = new System.Windows.Forms.DataGridView();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отправитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Получатель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Процент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.MachinesKey = new System.Windows.Forms.DataGridView();
            this.Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НазваниеБанка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PercentsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachinesKey)).BeginInit();
            this.SuspendLayout();
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
            this.PercentsData.Location = new System.Drawing.Point(345, 56);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Тип.DefaultCellStyle = dataGridViewCellStyle1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(446, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Процент";
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
            this.MachinesKey.Location = new System.Drawing.Point(27, 56);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Номер.DefaultCellStyle = dataGridViewCellStyle2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Банкомат";
            // 
            // PercentsOfMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MachinesKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PercentsData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PercentsOfMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт \"Проценты банкоматов\"";
            ((System.ComponentModel.ISupportInitialize)(this.PercentsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachinesKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView PercentsData;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView MachinesKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn НазваниеБанка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отправитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Получатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Процент;
    }
}