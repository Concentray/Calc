﻿namespace Calculator
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
            this.pow = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.lg = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.MultyOper.Click += new System.EventHandler(this.MultyOper_Click);
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
            this.DivOper.Click += new System.EventHandler(this.DivOper_Click);
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
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(29, 376);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(75, 23);
            this.pow.TabIndex = 7;
            this.pow.Text = "x^y";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.Pow_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(110, 376);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(75, 23);
            this.power.TabIndex = 8;
            this.power.Text = "x^(1/y)";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(192, 376);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(75, 23);
            this.sqr.TabIndex = 9;
            this.sqr.Text = "x^2";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.sqr_Click);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(273, 376);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(75, 23);
            this.Cube.TabIndex = 10;
            this.Cube.Text = "x^3";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.Cube_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(30, 427);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 23);
            this.sqrt.TabIndex = 11;
            this.sqrt.Text = "x^(1/2)";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // lg
            // 
            this.lg.Location = new System.Drawing.Point(111, 427);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(75, 23);
            this.lg.TabIndex = 12;
            this.lg.Text = "lg";
            this.lg.UseVisualStyleBackColor = true;
            this.lg.Click += new System.EventHandler(this.lg_Click);
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(30, 266);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(75, 23);
            this.Percent.TabIndex = 13;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(111, 266);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 14;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(192, 266);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 15;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(272, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 494);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.power);
            this.Controls.Add(this.pow);
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
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button lg;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

