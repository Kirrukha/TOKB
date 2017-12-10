namespace WindowsFormsApp1
{
    partial class LogForm
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
            this.btnLog = new System.Windows.Forms.Button();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.lblPas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(58, 72);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(111, 23);
            this.btnLog.TabIndex = 1;
            this.btnLog.Text = "Логин";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(22, 25);
            this.txtPas.Name = "txtPas";
            this.txtPas.PasswordChar = '*';
            this.txtPas.Size = new System.Drawing.Size(195, 20);
            this.txtPas.TabIndex = 2;
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.Location = new System.Drawing.Point(20, 9);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(91, 13);
            this.lblPas.TabIndex = 5;
            this.lblPas.Text = "Введите пароль:";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 107);
            this.Controls.Add(this.lblPas);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.btnLog);
            this.Name = "LogForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Label lblPas;
    }
}

