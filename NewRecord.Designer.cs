namespace FinalyDemoEx
{
    partial class NewRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.NR_CLOSE_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NR_SAVE_BTN = new System.Windows.Forms.Button();
            this.NR_COUNT_TB = new System.Windows.Forms.TextBox();
            this.NR_TYPEOF_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление новой записи";
            // 
            // NR_CLOSE_BTN
            // 
            this.NR_CLOSE_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NR_CLOSE_BTN.ForeColor = System.Drawing.Color.White;
            this.NR_CLOSE_BTN.Location = new System.Drawing.Point(339, 421);
            this.NR_CLOSE_BTN.Name = "NR_CLOSE_BTN";
            this.NR_CLOSE_BTN.Size = new System.Drawing.Size(101, 41);
            this.NR_CLOSE_BTN.TabIndex = 1;
            this.NR_CLOSE_BTN.Text = "Назад";
            this.NR_CLOSE_BTN.UseVisualStyleBackColor = false;
            this.NR_CLOSE_BTN.Click += new System.EventHandler(this.NR_CLOSE_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(95, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество";
            // 
            // NR_SAVE_BTN
            // 
            this.NR_SAVE_BTN.Location = new System.Drawing.Point(101, 328);
            this.NR_SAVE_BTN.Name = "NR_SAVE_BTN";
            this.NR_SAVE_BTN.Size = new System.Drawing.Size(247, 51);
            this.NR_SAVE_BTN.TabIndex = 4;
            this.NR_SAVE_BTN.Text = "Сохранить";
            this.NR_SAVE_BTN.UseVisualStyleBackColor = true;
            this.NR_SAVE_BTN.Click += new System.EventHandler(this.NR_SAVE_BTN_Click);
            // 
            // NR_COUNT_TB
            // 
            this.NR_COUNT_TB.Location = new System.Drawing.Point(98, 245);
            this.NR_COUNT_TB.Multiline = true;
            this.NR_COUNT_TB.Name = "NR_COUNT_TB";
            this.NR_COUNT_TB.Size = new System.Drawing.Size(247, 50);
            this.NR_COUNT_TB.TabIndex = 5;
            // 
            // NR_TYPEOF_TB
            // 
            this.NR_TYPEOF_TB.Location = new System.Drawing.Point(98, 152);
            this.NR_TYPEOF_TB.Multiline = true;
            this.NR_TYPEOF_TB.Name = "NR_TYPEOF_TB";
            this.NR_TYPEOF_TB.Size = new System.Drawing.Size(247, 50);
            this.NR_TYPEOF_TB.TabIndex = 6;
            // 
            // NewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 474);
            this.Controls.Add(this.NR_TYPEOF_TB);
            this.Controls.Add(this.NR_COUNT_TB);
            this.Controls.Add(this.NR_SAVE_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NR_CLOSE_BTN);
            this.Controls.Add(this.label1);
            this.Name = "NewRecord";
            this.Text = "NewRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NR_CLOSE_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NR_SAVE_BTN;
        private System.Windows.Forms.TextBox NR_COUNT_TB;
        private System.Windows.Forms.TextBox NR_TYPEOF_TB;
    }
}