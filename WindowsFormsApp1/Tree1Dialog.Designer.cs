namespace WindowsFormsApp1
{
    partial class Tree1Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tree1Dialog));
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.waterMarkTextBox1 = new WindowsFormsApp1.WaterMarkTextBox();
            this.waterMarkTextBox2 = new WindowsFormsApp1.WaterMarkTextBox();
            this.waterMarkTextBox3 = new WindowsFormsApp1.WaterMarkTextBox();
            this.waterMarkTextBox4 = new WindowsFormsApp1.WaterMarkTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Банк-получатель";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Банк-отправитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название операции";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление записи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Процент";
            // 
            // waterMarkTextBox1
            // 
            this.waterMarkTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox1.Location = new System.Drawing.Point(148, 49);
            this.waterMarkTextBox1.Name = "waterMarkTextBox1";
            this.waterMarkTextBox1.Size = new System.Drawing.Size(100, 20);
            this.waterMarkTextBox1.TabIndex = 10;
            this.waterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox1.WaterMarkText = "Название";
            // 
            // waterMarkTextBox2
            // 
            this.waterMarkTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox2.Location = new System.Drawing.Point(148, 75);
            this.waterMarkTextBox2.Name = "waterMarkTextBox2";
            this.waterMarkTextBox2.Size = new System.Drawing.Size(100, 20);
            this.waterMarkTextBox2.TabIndex = 11;
            this.waterMarkTextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox2.WaterMarkText = "НазваниеБанка";
            // 
            // waterMarkTextBox3
            // 
            this.waterMarkTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox3.Location = new System.Drawing.Point(148, 101);
            this.waterMarkTextBox3.Name = "waterMarkTextBox3";
            this.waterMarkTextBox3.Size = new System.Drawing.Size(100, 20);
            this.waterMarkTextBox3.TabIndex = 12;
            this.waterMarkTextBox3.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox3.WaterMarkText = "НазваниеБанка";
            // 
            // waterMarkTextBox4
            // 
            this.waterMarkTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox4.Location = new System.Drawing.Point(148, 127);
            this.waterMarkTextBox4.Name = "waterMarkTextBox4";
            this.waterMarkTextBox4.Size = new System.Drawing.Size(100, 20);
            this.waterMarkTextBox4.TabIndex = 13;
            this.waterMarkTextBox4.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox4.WaterMarkText = "Число [0..100]";
            // 
            // Tree1Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 207);
            this.Controls.Add(this.waterMarkTextBox4);
            this.Controls.Add(this.waterMarkTextBox3);
            this.Controls.Add(this.waterMarkTextBox2);
            this.Controls.Add(this.waterMarkTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tree1Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Процент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public WaterMarkTextBox waterMarkTextBox1;
        public WaterMarkTextBox waterMarkTextBox2;
        public WaterMarkTextBox waterMarkTextBox3;
        public WaterMarkTextBox waterMarkTextBox4;
    }
}