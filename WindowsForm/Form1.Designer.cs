
namespace WindowsForm
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
            this.txtRound = new System.Windows.Forms.TextBox();
            this.txtSquare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(12, 12);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(100, 22);
            this.txtRound.TabIndex = 0;
            // 
            // txtSquare
            // 
            this.txtSquare.Location = new System.Drawing.Point(12, 40);
            this.txtSquare.Name = "txtSquare";
            this.txtSquare.Size = new System.Drawing.Size(100, 22);
            this.txtSquare.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Площадь круга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Площадь квадрата";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рассчитать размещение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(12, 138);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(213, 22);
            this.txtSentence.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите предложение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(379, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Найти процент букв";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 235);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите число";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "Вывести ряд чисел";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSquare);
            this.Controls.Add(this.txtRound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.TextBox txtSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

