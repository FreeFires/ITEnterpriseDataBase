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
            this.passInputText = new System.Windows.Forms.TextBox();
            this.passInputButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chekDBConnect = new System.Windows.Forms.Button();
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
            // passInputText
            // 
            this.passInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passInputText.Location = new System.Drawing.Point(326, 274);
            this.passInputText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passInputText.Multiline = true;
            this.passInputText.Name = "passInputText";
            this.passInputText.PasswordChar = '*';
            this.passInputText.Size = new System.Drawing.Size(246, 61);
            this.passInputText.TabIndex = 1;
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
            // PassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(876, 709);
            this.Controls.Add(this.chekDBConnect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passInputButton);
            this.Controls.Add(this.passInputText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PassForm";
            this.Text = "Вхід в БД IT Підприємство";
            this.Load += new System.EventHandler(this.PassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passInputText;
        private System.Windows.Forms.Button passInputButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button chekDBConnect;
    }
}

