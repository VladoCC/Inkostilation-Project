namespace WindowsFormsApp1
{
    partial class percentFound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(percentFound));
            this.percentResults = new System.Windows.Forms.DataGridView();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отправитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Получатель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Процент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.percentResults)).BeginInit();
            this.SuspendLayout();
            // 
            // percentResults
            // 
            this.percentResults.AllowUserToAddRows = false;
            this.percentResults.AllowUserToDeleteRows = false;
            this.percentResults.AllowUserToResizeColumns = false;
            this.percentResults.AllowUserToResizeRows = false;
            this.percentResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.percentResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.percentResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Тип,
            this.Отправитель,
            this.Получатель,
            this.Процент});
            this.percentResults.Location = new System.Drawing.Point(25, 43);
            this.percentResults.MultiSelect = false;
            this.percentResults.Name = "percentResults";
            this.percentResults.ReadOnly = true;
            this.percentResults.RowHeadersVisible = false;
            this.percentResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.percentResults.Size = new System.Drawing.Size(300, 464);
            this.percentResults.TabIndex = 1;
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
            this.label2.Location = new System.Drawing.Point(117, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Процент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число сравнений:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(204, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "/число/";
            // 
            // percentFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.percentResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "percentFound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска процентов";
            ((System.ComponentModel.ISupportInitialize)(this.percentResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView percentResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отправитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Получатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Процент;
    }
}