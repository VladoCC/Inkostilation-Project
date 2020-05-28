namespace WindowsFormsApp1
{
    partial class HashMap1Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashMap1Dialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.waterMarkTextBox1 = new WindowsFormsApp1.WaterMarkTextBox();
            this.waterMarkTextBox2 = new WindowsFormsApp1.WaterMarkTextBox();
            this.waterMarkTextBox3 = new WindowsFormsApp1.WaterMarkTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление записи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Адрес";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Название банка";
            // 
            // waterMarkTextBox1
            // 
            this.waterMarkTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox1.Location = new System.Drawing.Point(129, 63);
            this.waterMarkTextBox1.Name = "waterMarkTextBox1";
            this.waterMarkTextBox1.Size = new System.Drawing.Size(100, 20);
            this.waterMarkTextBox1.TabIndex = 2;
            this.waterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox1.WaterMarkText = "Число [1..500]";
            // 
            // waterMarkTextBox2
            // 
            this.waterMarkTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox2.Location = new System.Drawing.Point(129, 89);
            this.waterMarkTextBox2.Name = "waterMarkTextBox2";
            this.waterMarkTextBox2.Size = new System.Drawing.Size(100, 20);
            this.waterMarkTextBox2.TabIndex = 4;
            this.waterMarkTextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox2.WaterMarkText = "Адрес";
            // 
            // waterMarkTextBox3
            // 
            this.waterMarkTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox3.Location = new System.Drawing.Point(129, 116);
            this.waterMarkTextBox3.Name = "waterMarkTextBox3";
            this.waterMarkTextBox3.Size = new System.Drawing.Size(100, 20);
            this.waterMarkTextBox3.TabIndex = 6;
            this.waterMarkTextBox3.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox3.WaterMarkText = "НазваниеБанка";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HashMap1Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 207);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.waterMarkTextBox3);
            this.Controls.Add(this.waterMarkTextBox2);
            this.Controls.Add(this.waterMarkTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HashMap1Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банкомат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        public WaterMarkTextBox waterMarkTextBox1;
        public WaterMarkTextBox waterMarkTextBox2;
        public WaterMarkTextBox waterMarkTextBox3;
        private System.Windows.Forms.Button button2;
    }
}