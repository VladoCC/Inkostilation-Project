namespace WindowsFormsApp1
{
    partial class operationFound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(operationFound));
            this.operationResults = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ТипОперации1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерБанкомата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СуммаОперации = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.operationResults)).BeginInit();
            this.SuspendLayout();
            // 
            // operationResults
            // 
            this.operationResults.AllowUserToAddRows = false;
            this.operationResults.AllowUserToDeleteRows = false;
            this.operationResults.AllowUserToResizeColumns = false;
            this.operationResults.AllowUserToResizeRows = false;
            this.operationResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.operationResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ТипОперации1,
            this.НомерКарточки1,
            this.НомерБанкомата,
            this.СуммаОперации});
            this.operationResults.Location = new System.Drawing.Point(26, 43);
            this.operationResults.MultiSelect = false;
            this.operationResults.Name = "operationResults";
            this.operationResults.ReadOnly = true;
            this.operationResults.RowHeadersVisible = false;
            this.operationResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operationResults.Size = new System.Drawing.Size(300, 464);
            this.operationResults.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(111, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Операция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число сравнений:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(205, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "/число/";
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
            // operationFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.operationResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "operationFound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска операций";
            ((System.ComponentModel.ISupportInitialize)(this.operationResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView operationResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТипОперации1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерБанкомата;
        private System.Windows.Forms.DataGridViewTextBoxColumn СуммаОперации;
    }
}