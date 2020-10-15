namespace pract_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UseFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.maxOutCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.randomNumbers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amountNumbers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.summNumbers = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxOutCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UseFunction,
            this.AboutUs,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UseFunction
            // 
            this.UseFunction.Name = "UseFunction";
            this.UseFunction.Size = new System.Drawing.Size(136, 20);
            this.UseFunction.Text = "Выполнить функцию";
            this.UseFunction.Click += new System.EventHandler(this.UseFunction_Click);
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(94, 20);
            this.AboutUs.Text = "О программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 20);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // maxOutCount
            // 
            this.maxOutCount.Location = new System.Drawing.Point(43, 49);
            this.maxOutCount.Name = "maxOutCount";
            this.maxOutCount.Size = new System.Drawing.Size(212, 20);
            this.maxOutCount.TabIndex = 1;
            this.maxOutCount.ValueChanged += new System.EventHandler(this.maxOutCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Максимальный ответ";
            // 
            // randomNumbers
            // 
            this.randomNumbers.Location = new System.Drawing.Point(43, 88);
            this.randomNumbers.Name = "randomNumbers";
            this.randomNumbers.ReadOnly = true;
            this.randomNumbers.Size = new System.Drawing.Size(215, 20);
            this.randomNumbers.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Сгенерированные числа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество сгенерированных чисел";
            // 
            // amountNumbers
            // 
            this.amountNumbers.Location = new System.Drawing.Point(43, 139);
            this.amountNumbers.Name = "amountNumbers";
            this.amountNumbers.ReadOnly = true;
            this.amountNumbers.Size = new System.Drawing.Size(215, 20);
            this.amountNumbers.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Значение суммы сгенерированных чисел";
            // 
            // summNumbers
            // 
            this.summNumbers.Location = new System.Drawing.Point(43, 188);
            this.summNumbers.Name = "summNumbers";
            this.summNumbers.ReadOnly = true;
            this.summNumbers.Size = new System.Drawing.Size(215, 20);
            this.summNumbers.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 221);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.summNumbers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountNumbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.randomNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxOutCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 260);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxOutCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UseFunction;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.NumericUpDown maxOutCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox randomNumbers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amountNumbers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox summNumbers;
    }
}

