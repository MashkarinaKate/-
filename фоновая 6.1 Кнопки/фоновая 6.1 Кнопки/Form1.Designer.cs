namespace фоновая_6._1_Кнопки
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
            this.buttonА = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonА
            // 
            this.buttonА.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonА.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonА.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonА.Location = new System.Drawing.Point(43, 12);
            this.buttonА.Name = "buttonА";
            this.buttonА.Size = new System.Drawing.Size(139, 59);
            this.buttonА.TabIndex = 0;
            this.buttonА.Text = "А";
            this.buttonА.UseVisualStyleBackColor = false;
            this.buttonА.Click += new System.EventHandler(this.ButtonА_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonB.Location = new System.Drawing.Point(43, 119);
            this.buttonB.Name = "buttonB";
            this.buttonB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonB.Size = new System.Drawing.Size(134, 60);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.ButtonB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(220, 203);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonА);
            this.Name = "Form1";
            this.Text = "Передвижения кнопок";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonА;
        private System.Windows.Forms.Button buttonB;
    }
}

