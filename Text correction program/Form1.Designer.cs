namespace Text_correction_program
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
            this.mainButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(275, 324);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(159, 31);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Исправить";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(90, 68);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(550, 234);
            this.mainTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Программа исправляет орфографические и пунктуальные ошибки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.mainButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Label label1;
    }
}

