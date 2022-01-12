
namespace Tickets
{
    partial class FormRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxWho = new System.Windows.Forms.GroupBox();
            this.radioButtonVendor = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxWho.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистация";
            // 
            // groupBoxWho
            // 
            this.groupBoxWho.Controls.Add(this.radioButtonVendor);
            this.groupBoxWho.Controls.Add(this.radioButtonCustomer);
            this.groupBoxWho.Location = new System.Drawing.Point(12, 62);
            this.groupBoxWho.Name = "groupBoxWho";
            this.groupBoxWho.Size = new System.Drawing.Size(320, 90);
            this.groupBoxWho.TabIndex = 1;
            this.groupBoxWho.TabStop = false;
            this.groupBoxWho.Text = "Кто вы?";
            // 
            // radioButtonVendor
            // 
            this.radioButtonVendor.AutoSize = true;
            this.radioButtonVendor.Location = new System.Drawing.Point(16, 53);
            this.radioButtonVendor.Name = "radioButtonVendor";
            this.radioButtonVendor.Size = new System.Drawing.Size(91, 21);
            this.radioButtonVendor.TabIndex = 1;
            this.radioButtonVendor.Text = "Продавец";
            this.radioButtonVendor.UseVisualStyleBackColor = true;
            this.radioButtonVendor.CheckedChanged += new System.EventHandler(this.radioButtonVendor_CheckedChanged);
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Checked = true;
            this.radioButtonCustomer.Location = new System.Drawing.Point(16, 25);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(104, 21);
            this.radioButtonCustomer.TabIndex = 0;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "Покупатель";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            this.radioButtonCustomer.CheckedChanged += new System.EventHandler(this.radioButtonCustomer_CheckedChanged);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Location = new System.Drawing.Point(12, 500);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(319, 38);
            this.buttonRegistration.TabIndex = 12;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(20, 453);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(305, 23);
            this.textBoxEmail.TabIndex = 22;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(25, 428);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(138, 17);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Электронная почта";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(20, 385);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(305, 23);
            this.textBoxSurname.TabIndex = 20;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(25, 360);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(70, 17);
            this.labelSurname.TabIndex = 19;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(20, 320);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(305, 23);
            this.textBoxName.TabIndex = 18;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 295);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 17);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Имя";
            // 
            // textBoxPas
            // 
            this.textBoxPas.Location = new System.Drawing.Point(20, 256);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(305, 23);
            this.textBoxPas.TabIndex = 16;
            this.textBoxPas.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(25, 231);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(57, 17);
            this.labelPass.TabIndex = 15;
            this.labelPass.Text = "Пароль";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(20, 192);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(305, 23);
            this.textBoxLog.TabIndex = 14;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(25, 167);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(47, 17);
            this.labelLog.TabIndex = 13;
            this.labelLog.Text = "Логин";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(12, 551);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(319, 38);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.groupBoxWho);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistration";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Регистрация";
            this.groupBoxWho.ResumeLayout(false);
            this.groupBoxWho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxWho;
        private System.Windows.Forms.RadioButton radioButtonVendor;
        private System.Windows.Forms.RadioButton radioButtonCustomer;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonExit;
    }
}

