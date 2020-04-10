namespace WindowsFormsApp1
{
    partial class GUI
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НазваниеБанка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отправитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Получатель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Процент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ТипОперации1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерБанкомата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СуммаОперации = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Hash1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Банк = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.импортироватьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.создатьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.создатьToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.открытьToolStripMenuItem.Text = "Создать";
            // 
            // импортироватьToolStripMenuItem
            // 
            this.импортироватьToolStripMenuItem.Name = "импортироватьToolStripMenuItem";
            this.импортироватьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.импортироватьToolStripMenuItem.Text = "Импортировать";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hash,
            this.Номер,
            this.Адрес,
            this.НазваниеБанка});
            this.dataGridView1.Location = new System.Drawing.Point(28, 87);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(243, 464);
            this.dataGridView1.TabIndex = 1;
            // 
            // Hash
            // 
            this.Hash.HeaderText = "#";
            this.Hash.Name = "Hash";
            this.Hash.ReadOnly = true;
            this.Hash.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hash.Width = 20;
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
            this.Номер.Width = 55;
            // 
            // Адрес
            // 
            this.Адрес.HeaderText = "Адрес";
            this.Адрес.Name = "Адрес";
            this.Адрес.ReadOnly = true;
            this.Адрес.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Адрес.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Адрес.Width = 81;
            // 
            // НазваниеБанка
            // 
            this.НазваниеБанка.HeaderText = "Название банка";
            this.НазваниеБанка.Name = "НазваниеБанка";
            this.НазваниеБанка.ReadOnly = true;
            this.НазваниеБанка.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.НазваниеБанка.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.НазваниеБанка.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Банкомат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(344, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Процент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(660, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1012, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Операция";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Тип,
            this.Отправитель,
            this.Получатель,
            this.Процент});
            this.dataGridView2.Location = new System.Drawing.Point(526, 87);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(358, 464);
            this.dataGridView2.TabIndex = 9;
            // 
            // Тип
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Тип.DefaultCellStyle = dataGridViewCellStyle2;
            this.Тип.HeaderText = "Тип операции";
            this.Тип.Name = "Тип";
            this.Тип.ReadOnly = true;
            this.Тип.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Тип.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Тип.Width = 75;
            // 
            // Отправитель
            // 
            this.Отправитель.HeaderText = "Отправитель";
            this.Отправитель.Name = "Отправитель";
            this.Отправитель.ReadOnly = true;
            this.Отправитель.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Отправитель.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Получатель
            // 
            this.Получатель.HeaderText = "Получатель";
            this.Получатель.Name = "Получатель";
            this.Получатель.ReadOnly = true;
            this.Получатель.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Получатель.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Процент
            // 
            this.Процент.HeaderText = "Процент";
            this.Процент.Name = "Процент";
            this.Процент.ReadOnly = true;
            this.Процент.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Процент.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Процент.Width = 80;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hash1,
            this.НомерКарточки,
            this.Банк,
            this.ФИО});
            this.dataGridView3.Location = new System.Drawing.Point(277, 87);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(243, 464);
            this.dataGridView3.TabIndex = 10;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ТипОперации1,
            this.НомерКарточки1,
            this.НомерБанкомата,
            this.СуммаОперации});
            this.dataGridView4.Location = new System.Drawing.Point(890, 87);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(358, 464);
            this.dataGridView4.TabIndex = 11;
            // 
            // ТипОперации1
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ТипОперации1.DefaultCellStyle = dataGridViewCellStyle4;
            this.ТипОперации1.HeaderText = "Тип операции";
            this.ТипОперации1.Name = "ТипОперации1";
            this.ТипОперации1.ReadOnly = true;
            this.ТипОперации1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ТипОперации1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ТипОперации1.Width = 75;
            // 
            // НомерКарточки1
            // 
            this.НомерКарточки1.HeaderText = "Номер карточки";
            this.НомерКарточки1.Name = "НомерКарточки1";
            this.НомерКарточки1.ReadOnly = true;
            this.НомерКарточки1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.НомерКарточки1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // НомерБанкомата
            // 
            this.НомерБанкомата.HeaderText = "Номер банкомата";
            this.НомерБанкомата.Name = "НомерБанкомата";
            this.НомерБанкомата.ReadOnly = true;
            this.НомерБанкомата.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.НомерБанкомата.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // СуммаОперации
            // 
            this.СуммаОперации.HeaderText = "Сумма операции";
            this.СуммаОперации.Name = "СуммаОперации";
            this.СуммаОперации.ReadOnly = true;
            this.СуммаОперации.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.СуммаОперации.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.СуммаОперации.Width = 80;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(53, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(614, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Добавить запись";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(305, 557);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить запись";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(987, 557);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Добавить запись";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Hash1
            // 
            this.Hash1.HeaderText = "#";
            this.Hash1.Name = "Hash1";
            this.Hash1.ReadOnly = true;
            this.Hash1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hash1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hash1.Width = 20;
            // 
            // НомерКарточки
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НомерКарточки.DefaultCellStyle = dataGridViewCellStyle3;
            this.НомерКарточки.HeaderText = "Номер карточки";
            this.НомерКарточки.Name = "НомерКарточки";
            this.НомерКарточки.ReadOnly = true;
            this.НомерКарточки.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.НомерКарточки.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.НомерКарточки.Width = 60;
            // 
            // Банк
            // 
            this.Банк.HeaderText = "Банк";
            this.Банк.Name = "Банк";
            this.Банк.ReadOnly = true;
            this.Банк.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Банк.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Банк.Width = 76;
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            this.ФИО.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ФИО.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ФИО.Width = 84;
            // 
            // GUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inkostilation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn НазваниеБанка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отправитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Получатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Процент;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТипОперации1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерБанкомата;
        private System.Windows.Forms.DataGridViewTextBoxColumn СуммаОперации;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Банк;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
    }
}

