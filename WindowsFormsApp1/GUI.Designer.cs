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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииПоКлиентуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииБанкоматаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процентыОперацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процентыБанкоматаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Hash1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Банк = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ТипОперации1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерБанкомата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СуммаОперации = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
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
            this.создатьToolStripMenuItem,
            this.отчётыToolStripMenuItem});
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
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииПоКлиентуToolStripMenuItem,
            this.операцииБанкоматаToolStripMenuItem,
            this.процентыОперацийToolStripMenuItem,
            this.процентыБанкоматаToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // операцииПоКлиентуToolStripMenuItem
            // 
            this.операцииПоКлиентуToolStripMenuItem.Name = "операцииПоКлиентуToolStripMenuItem";
            this.операцииПоКлиентуToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.операцииПоКлиентуToolStripMenuItem.Text = "Операции клиента";
            // 
            // операцииБанкоматаToolStripMenuItem
            // 
            this.операцииБанкоматаToolStripMenuItem.Name = "операцииБанкоматаToolStripMenuItem";
            this.операцииБанкоматаToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.операцииБанкоматаToolStripMenuItem.Text = "Операции банкомата";
            // 
            // процентыОперацийToolStripMenuItem
            // 
            this.процентыОперацийToolStripMenuItem.Name = "процентыОперацийToolStripMenuItem";
            this.процентыОперацийToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.процентыОперацийToolStripMenuItem.Text = "Проценты операций";
            // 
            // процентыБанкоматаToolStripMenuItem
            // 
            this.процентыБанкоматаToolStripMenuItem.Name = "процентыБанкоматаToolStripMenuItem";
            this.процентыБанкоматаToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.процентыБанкоматаToolStripMenuItem.Text = "Проценты банкомата";
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 140);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 464);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Hash
            // 
            this.Hash.HeaderText = "Хэш функция";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Банкомат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1041, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Процент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(431, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(728, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 13;
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
            this.dataGridView2.Location = new System.Drawing.Point(939, 140);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(300, 464);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
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
            this.dataGridView3.Location = new System.Drawing.Point(327, 140);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(300, 464);
            this.dataGridView3.TabIndex = 10;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Hash1
            // 
            this.Hash1.HeaderText = "Хэш функция";
            this.Hash1.Name = "Hash1";
            this.Hash1.ReadOnly = true;
            this.Hash1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hash1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hash1.Width = 60;
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
            this.dataGridView4.Location = new System.Drawing.Point(633, 140);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(300, 464);
            this.dataGridView4.TabIndex = 14;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(32, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(950, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(338, 610);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(644, 610);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(181, 610);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(483, 610);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 30);
            this.button6.TabIndex = 12;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(1095, 610);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 30);
            this.button7.TabIndex = 20;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(789, 610);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 30);
            this.button8.TabIndex = 16;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(90, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Поиск:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Банкомат",
            "Клиент",
            "Операция",
            "Процент"});
            this.comboBox1.Location = new System.Drawing.Point(495, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(633, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "Найти";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // GUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отправитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Получатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Процент;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТипОперации1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерБанкомата;
        private System.Windows.Forms.DataGridViewTextBoxColumn СуммаОперации;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииПоКлиентуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииБанкоматаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процентыОперацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процентыБанкоматаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn НазваниеБанка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Банк;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button9;
    }
}