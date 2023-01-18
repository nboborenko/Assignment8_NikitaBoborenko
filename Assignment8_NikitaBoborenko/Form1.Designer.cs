namespace Assignment8_NikitaBoborenko
{
    partial class Form1
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(80, 77);
            this.input_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(76, 20);
            this.input_textBox.TabIndex = 0;
            this.input_textBox.Text = "2";
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(80, 145);
            this.find_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(56, 19);
            this.find_btn.TabIndex = 1;
            this.find_btn.Text = "Find word";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input word to find it in the list";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(80, 111);
            this.output_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(239, 13);
            this.output_label.TabIndex = 3;
            this.output_label.Text = "Word was found/not found in the first/second file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.input_textBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label output_label;
    }
}

