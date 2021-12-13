
namespace BMRCalculatorBaryshev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.man = new System.Windows.Forms.PictureBox();
            this.woman = new System.Windows.Forms.PictureBox();
            this.labelrost = new System.Windows.Forms.Label();
            this.rost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ves = new System.Windows.Forms.TextBox();
            this.labelves = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vozrast = new System.Windows.Forms.TextBox();
            this.labelvozrast = new System.Windows.Forms.Label();
            this.rasschet = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rezult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woman)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(84, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARATHON SKILLS 2021";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(3, 17);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 37);
            this.back.TabIndex = 0;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(269, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "BMR калькулятор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Информация о том что такео BMR \r\nкалькуляртор и как расчитываются результаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(505, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 72);
            this.label4.TabIndex = 3;
            this.label4.Text = "Информация о показателях калорий \r\nпоказывается здесь\r\n\r\n\r\n";
            // 
            // man
            // 
            this.man.Image = ((System.Drawing.Image)(resources.GetObject("man.Image")));
            this.man.Location = new System.Drawing.Point(15, 205);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(94, 139);
            this.man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.man.TabIndex = 4;
            this.man.TabStop = false;
            // 
            // woman
            // 
            this.woman.Image = ((System.Drawing.Image)(resources.GetObject("woman.Image")));
            this.woman.Location = new System.Drawing.Point(134, 205);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(94, 139);
            this.woman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woman.TabIndex = 5;
            this.woman.TabStop = false;
            // 
            // labelrost
            // 
            this.labelrost.AutoSize = true;
            this.labelrost.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelrost.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelrost.Location = new System.Drawing.Point(43, 386);
            this.labelrost.Name = "labelrost";
            this.labelrost.Size = new System.Drawing.Size(61, 23);
            this.labelrost.TabIndex = 6;
            this.labelrost.Text = "Рост:";
            // 
            // rost
            // 
            this.rost.Location = new System.Drawing.Point(110, 386);
            this.rost.Multiline = true;
            this.rost.Name = "rost";
            this.rost.Size = new System.Drawing.Size(66, 25);
            this.rost.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(182, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "см";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(182, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "кг";
            // 
            // ves
            // 
            this.ves.Location = new System.Drawing.Point(110, 422);
            this.ves.Multiline = true;
            this.ves.Name = "ves";
            this.ves.Size = new System.Drawing.Size(66, 25);
            this.ves.TabIndex = 10;
            // 
            // labelves
            // 
            this.labelves.AutoSize = true;
            this.labelves.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelves.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelves.Location = new System.Drawing.Point(51, 422);
            this.labelves.Name = "labelves";
            this.labelves.Size = new System.Drawing.Size(53, 23);
            this.labelves.TabIndex = 9;
            this.labelves.Text = "Вес:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(182, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "лет";
            // 
            // vozrast
            // 
            this.vozrast.Location = new System.Drawing.Point(110, 462);
            this.vozrast.Multiline = true;
            this.vozrast.Name = "vozrast";
            this.vozrast.Size = new System.Drawing.Size(66, 25);
            this.vozrast.TabIndex = 13;
            // 
            // labelvozrast
            // 
            this.labelvozrast.AutoSize = true;
            this.labelvozrast.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelvozrast.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelvozrast.Location = new System.Drawing.Point(8, 462);
            this.labelvozrast.Name = "labelvozrast";
            this.labelvozrast.Size = new System.Drawing.Size(96, 23);
            this.labelvozrast.TabIndex = 12;
            this.labelvozrast.Text = "Возраст:";
            // 
            // rasschet
            // 
            this.rasschet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rasschet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rasschet.Location = new System.Drawing.Point(12, 506);
            this.rasschet.Name = "rasschet";
            this.rasschet.Size = new System.Drawing.Size(130, 38);
            this.rasschet.TabIndex = 15;
            this.rasschet.Text = "Рассчитать";
            this.rasschet.UseVisualStyleBackColor = true;
            this.rasschet.Click += new System.EventHandler(this.rasschet_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(157, 506);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(130, 38);
            this.clear.TabIndex = 16;
            this.clear.Text = "Отмена";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(612, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 54);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ваш BMR\r\n\r\n\r\n";
            // 
            // rezult
            // 
            this.rezult.AutoSize = true;
            this.rezult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rezult.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rezult.Location = new System.Drawing.Point(612, 234);
            this.rezult.Name = "rezult";
            this.rezult.Size = new System.Drawing.Size(83, 54);
            this.rezult.TabIndex = 18;
            this.rezult.Text = "Ваш BMR\r\n\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(580, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 36);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ежедневно тратится \r\nкалорий:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(579, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Сидячий:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(681, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = ".\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(681, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = ".\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(681, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 29);
            this.label13.TabIndex = 23;
            this.label13.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(681, 478);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 29);
            this.label14.TabIndex = 24;
            this.label14.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(681, 521);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 29);
            this.label15.TabIndex = 25;
            this.label15.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(442, 393);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(240, 23);
            this.label16.TabIndex = 26;
            this.label16.Text = "Маленькая активность:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(466, 440);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 23);
            this.label17.TabIndex = 27;
            this.label17.Text = "Средняя активность:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(466, 483);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(223, 23);
            this.label18.TabIndex = 28;
            this.label18.Text = "Сильная активность: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(407, 526);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(275, 23);
            this.label19.TabIndex = 29;
            this.label19.Text = "Максимальная активность:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 605);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rezult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.rasschet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vozrast);
            this.Controls.Add(this.labelvozrast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ves);
            this.Controls.Add(this.labelves);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rost);
            this.Controls.Add(this.labelrost);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox man;
        private System.Windows.Forms.PictureBox woman;
        private System.Windows.Forms.Label labelrost;
        private System.Windows.Forms.TextBox rost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ves;
        private System.Windows.Forms.Label labelves;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vozrast;
        private System.Windows.Forms.Label labelvozrast;
        private System.Windows.Forms.Button rasschet;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rezult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

