namespace ITEnterprDataBase
{
    partial class PassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassForm));
            this.label1 = new System.Windows.Forms.Label();
            this.passInputField = new System.Windows.Forms.TextBox();
            this.passInputButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chekDBConnect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(320, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть пароль:";
            // 
            // passInputField
            // 
            this.passInputField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passInputField.Location = new System.Drawing.Point(326, 274);
            this.passInputField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passInputField.MaxLength = 8;
            this.passInputField.Multiline = true;
            this.passInputField.Name = "passInputField";
            this.passInputField.PasswordChar = '*';
            this.passInputField.Size = new System.Drawing.Size(246, 61);
            this.passInputField.TabIndex = 1;
            this.passInputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passInputText_KeyPass);
            // 
            // passInputButton
            // 
            this.passInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passInputButton.Location = new System.Drawing.Point(384, 362);
            this.passInputButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passInputButton.Name = "passInputButton";
            this.passInputButton.Size = new System.Drawing.Size(126, 45);
            this.passInputButton.TabIndex = 2;
            this.passInputButton.Text = "Вхід";
            this.passInputButton.UseVisualStyleBackColor = true;
            this.passInputButton.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITEnterprDataBase.Properties.Resources.legko_test;
            this.pictureBox1.Location = new System.Drawing.Point(708, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // chekDBConnect
            // 
            this.chekDBConnect.Location = new System.Drawing.Point(326, 617);
            this.chekDBConnect.Name = "chekDBConnect";
            this.chekDBConnect.Size = new System.Drawing.Size(246, 53);
            this.chekDBConnect.TabIndex = 4;
            this.chekDBConnect.Text = "Перевірка з\'єднання з БД";
            this.chekDBConnect.UseVisualStyleBackColor = true;
            this.chekDBConnect.Click += new System.EventHandler(this.ChekDBConnect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(732, 617);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 58);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Вихід";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(876, 709);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chekDBConnect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passInputButton);
            this.Controls.Add(this.passInputField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "PassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід в БД IT Підприємство";
            this.Load += new System.EventHandler(this.PassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passInputField;
        private System.Windows.Forms.Button passInputButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button chekDBConnect;
        private System.Windows.Forms.Button btnClose;
    }
}

