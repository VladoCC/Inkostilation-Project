namespace WindowsFormsApp1
{
    partial class ClientFound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFound));
            this.ClientResults = new System.Windows.Forms.DataGridView();
            this.Hash1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКарточки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Банк = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientResults)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientResults
            // 
            this.ClientResults.AllowUserToAddRows = false;
            this.ClientResults.AllowUserToDeleteRows = false;
            this.ClientResults.AllowUserToResizeColumns = false;
            this.ClientResults.AllowUserToResizeRows = false;
            this.ClientResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hash1,
            this.НомерКарточки,
            this.Банк,
            this.ФИО});
            this.ClientResults.Location = new System.Drawing.Point(22, 50);
            this.ClientResults.MultiSelect = false;
            this.ClientResults.Name = "ClientResults";
            this.ClientResults.ReadOnly = true;
            this.ClientResults.RowHeadersVisible = false;
            this.ClientResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientResults.Size = new System.Drawing.Size(300, 464);
            this.ClientResults.TabIndex = 7;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(125, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Клиент";
            // 
            // ClientFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientFound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.ClientResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ClientResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКарточки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Банк;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.Label label3;
    }
}