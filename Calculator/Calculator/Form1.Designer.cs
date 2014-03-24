namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlusOper = new System.Windows.Forms.Button();
            this.MultyOper = new System.Windows.Forms.Button();
            this.MinusOper = new System.Windows.Forms.Button();
            this.DivOper = new System.Windows.Forms.Button();
            this.ResultField = new System.Windows.Forms.TextBox();
            this.SecondField = new System.Windows.Forms.TextBox();
            this.FirstField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PlusOper
            // 
            this.PlusOper.Location = new System.Drawing.Point(30, 316);
            this.PlusOper.Name = "PlusOper";
            this.PlusOper.Size = new System.Drawing.Size(75, 23);
            this.PlusOper.TabIndex = 0;
            this.PlusOper.Text = "+";
            this.PlusOper.UseVisualStyleBackColor = true;
            this.PlusOper.Click += new System.EventHandler(this.PlusOper_Click);
            // 
            // MultyOper
            // 
            this.MultyOper.Location = new System.Drawing.Point(192, 316);
            this.MultyOper.Name = "MultyOper";
            this.MultyOper.Size = new System.Drawing.Size(75, 23);
            this.MultyOper.TabIndex = 1;
            this.MultyOper.Text = "*";
            this.MultyOper.UseVisualStyleBackColor = true;
            // 
            // MinusOper
            // 
            this.MinusOper.Location = new System.Drawing.Point(111, 316);
            this.MinusOper.Name = "MinusOper";
            this.MinusOper.Size = new System.Drawing.Size(75, 23);
            this.MinusOper.TabIndex = 2;
            this.MinusOper.Text = "-";
            this.MinusOper.UseVisualStyleBackColor = true;
            this.MinusOper.Click += new System.EventHandler(this.MinusOper_Click);
            // 
            // DivOper
            // 
            this.DivOper.Location = new System.Drawing.Point(273, 316);
            this.DivOper.Name = "DivOper";
            this.DivOper.Size = new System.Drawing.Size(75, 23);
            this.DivOper.TabIndex = 3;
            this.DivOper.Text = "/";
            this.DivOper.UseVisualStyleBackColor = true;
            // 
            // ResultField
            // 
            this.ResultField.Location = new System.Drawing.Point(242, 151);
            this.ResultField.Name = "ResultField";
            this.ResultField.Size = new System.Drawing.Size(100, 20);
            this.ResultField.TabIndex = 4;
            // 
            // SecondField
            // 
            this.SecondField.Location = new System.Drawing.Point(136, 151);
            this.SecondField.Name = "SecondField";
            this.SecondField.Size = new System.Drawing.Size(100, 20);
            this.SecondField.TabIndex = 5;
            // 
            // FirstField
            // 
            this.FirstField.Location = new System.Drawing.Point(30, 151);
            this.FirstField.Name = "FirstField";
            this.FirstField.Size = new System.Drawing.Size(100, 20);
            this.FirstField.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 494);
            this.Controls.Add(this.FirstField);
            this.Controls.Add(this.SecondField);
            this.Controls.Add(this.ResultField);
            this.Controls.Add(this.DivOper);
            this.Controls.Add(this.MinusOper);
            this.Controls.Add(this.MultyOper);
            this.Controls.Add(this.PlusOper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusOper;
        private System.Windows.Forms.Button MultyOper;
        private System.Windows.Forms.Button MinusOper;
        private System.Windows.Forms.Button DivOper;
        private System.Windows.Forms.TextBox ResultField;
        private System.Windows.Forms.TextBox SecondField;
        private System.Windows.Forms.TextBox FirstField;
    }
}

