namespace практика_16
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
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.buttonDo = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(33, 32);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(223, 22);
            this.Input.TabIndex = 0;
            this.Input.Text = "input: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите систему счисления: ";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Checked = true;
            this.rb2.Location = new System.Drawing.Point(39, 121);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(37, 21);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(40, 148);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(37, 21);
            this.rb8.TabIndex = 3;
            this.rb8.TabStop = true;
            this.rb8.Text = "8";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            this.rb16.AutoSize = true;
            this.rb16.Location = new System.Drawing.Point(39, 175);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(45, 21);
            this.rb16.TabIndex = 4;
            this.rb16.TabStop = true;
            this.rb16.Text = "16";
            this.rb16.UseVisualStyleBackColor = true;
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(33, 224);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(91, 38);
            this.buttonDo.TabIndex = 5;
            this.buttonDo.Text = "Do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.ButtonDo_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(36, 297);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(56, 17);
            this.Output.TabIndex = 6;
            this.Output.Text = "output: ";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(33, 390);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(91, 29);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.rb16);
            this.Controls.Add(this.rb8);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb16;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button buttonOK;
    }
}

