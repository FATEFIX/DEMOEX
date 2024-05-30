namespace FinalyDemoEx
{
    partial class MainForm
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
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.ChangeBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.TYPEOF_TB = new System.Windows.Forms.TextBox();
            this.COUNT_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(606, 170);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(182, 60);
            this.DeleteBTN.TabIndex = 0;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.Location = new System.Drawing.Point(606, 91);
            this.ChangeBTN.Name = "ChangeBTN";
            this.ChangeBTN.Size = new System.Drawing.Size(182, 60);
            this.ChangeBTN.TabIndex = 1;
            this.ChangeBTN.Text = "Изменить";
            this.ChangeBTN.UseVisualStyleBackColor = true;
            this.ChangeBTN.Click += new System.EventHandler(this.ChangeBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(606, 12);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(182, 60);
            this.AddBTN.TabIndex = 2;
            this.AddBTN.Text = "Добавить";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 261);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_TB
            // 
            this.ID_TB.Location = new System.Drawing.Point(82, 343);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.Size = new System.Drawing.Size(173, 20);
            this.ID_TB.TabIndex = 4;
            this.ID_TB.TextChanged += new System.EventHandler(this.ID_TB_TextChanged);
            // 
            // TYPEOF_TB
            // 
            this.TYPEOF_TB.Location = new System.Drawing.Point(82, 370);
            this.TYPEOF_TB.Name = "TYPEOF_TB";
            this.TYPEOF_TB.Size = new System.Drawing.Size(173, 20);
            this.TYPEOF_TB.TabIndex = 5;
            // 
            // COUNT_TB
            // 
            this.COUNT_TB.Location = new System.Drawing.Point(82, 396);
            this.COUNT_TB.Name = "COUNT_TB";
            this.COUNT_TB.Size = new System.Drawing.Size(173, 20);
            this.COUNT_TB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество";
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(606, 250);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(182, 60);
            this.UpdateBTN.TabIndex = 10;
            this.UpdateBTN.Text = "Обновить";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // Search_TB
            // 
            this.Search_TB.Location = new System.Drawing.Point(82, 303);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(265, 20);
            this.Search_TB.TabIndex = 11;
            this.Search_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поиск";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COUNT_TB);
            this.Controls.Add(this.TYPEOF_TB);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.ChangeBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button ChangeBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.TextBox TYPEOF_TB;
        private System.Windows.Forms.TextBox COUNT_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.TextBox Search_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}