namespace XML_Serialization
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
            this.Serialize = new System.Windows.Forms.Button();
            this.DeSerialize = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.First_Name_t = new System.Windows.Forms.TextBox();
            this.Last_Name_t = new System.Windows.Forms.TextBox();
            this.Mail_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Age_t = new System.Windows.Forms.TextBox();
            this.Gender_t = new System.Windows.Forms.TextBox();
            this.Country_t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Serialize
            // 
            this.Serialize.Location = new System.Drawing.Point(28, 174);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(156, 40);
            this.Serialize.TabIndex = 0;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // DeSerialize
            // 
            this.DeSerialize.Location = new System.Drawing.Point(262, 172);
            this.DeSerialize.Name = "DeSerialize";
            this.DeSerialize.Size = new System.Drawing.Size(156, 42);
            this.DeSerialize.TabIndex = 1;
            this.DeSerialize.Text = "DeSerialize";
            this.DeSerialize.UseVisualStyleBackColor = true;
            this.DeSerialize.Click += new System.EventHandler(this.DeSerialize_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 12);
            this.textBox1.MinimumSize = new System.Drawing.Size(300, 300);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 411);
            this.textBox1.TabIndex = 2;
            // 
            // First_Name_t
            // 
            this.First_Name_t.Location = new System.Drawing.Point(84, 25);
            this.First_Name_t.Name = "First_Name_t";
            this.First_Name_t.Size = new System.Drawing.Size(100, 20);
            this.First_Name_t.TabIndex = 4;
            // 
            // Last_Name_t
            // 
            this.Last_Name_t.Location = new System.Drawing.Point(84, 67);
            this.Last_Name_t.Name = "Last_Name_t";
            this.Last_Name_t.Size = new System.Drawing.Size(100, 20);
            this.Last_Name_t.TabIndex = 5;
            // 
            // Mail_t
            // 
            this.Mail_t.Location = new System.Drawing.Point(84, 120);
            this.Mail_t.Name = "Mail_t";
            this.Mail_t.Size = new System.Drawing.Size(100, 20);
            this.Mail_t.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // Age_t
            // 
            this.Age_t.Location = new System.Drawing.Point(307, 25);
            this.Age_t.Name = "Age_t";
            this.Age_t.Size = new System.Drawing.Size(100, 20);
            this.Age_t.TabIndex = 9;
            // 
            // Gender_t
            // 
            this.Gender_t.Location = new System.Drawing.Point(307, 66);
            this.Gender_t.Name = "Gender_t";
            this.Gender_t.Size = new System.Drawing.Size(100, 20);
            this.Gender_t.TabIndex = 10;
            // 
            // Country_t
            // 
            this.Country_t.Location = new System.Drawing.Point(307, 120);
            this.Country_t.Name = "Country_t";
            this.Country_t.Size = new System.Drawing.Size(100, 20);
            this.Country_t.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Country";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(153, 251);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(157, 47);
            this.Remove.TabIndex = 16;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 462);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Country_t);
            this.Controls.Add(this.Gender_t);
            this.Controls.Add(this.Age_t);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mail_t);
            this.Controls.Add(this.Last_Name_t);
            this.Controls.Add(this.First_Name_t);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeSerialize);
            this.Controls.Add(this.Serialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button DeSerialize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox First_Name_t;
        private System.Windows.Forms.TextBox Last_Name_t;
        private System.Windows.Forms.TextBox Mail_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Age_t;
        private System.Windows.Forms.TextBox Gender_t;
        private System.Windows.Forms.TextBox Country_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Remove;
    }
}

