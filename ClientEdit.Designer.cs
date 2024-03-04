namespace ClientDB4._0
{
    partial class ClientEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEdit));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.textBoxPatrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerReg = new System.Windows.Forms.DateTimePicker();
            this.checkBoxgreen = new System.Windows.Forms.CheckBox();
            this.checkBoxred = new System.Windows.Forms.CheckBox();
            this.checkBoxyellow = new System.Windows.Forms.CheckBox();
            this.checkBoxblack = new System.Windows.Forms.CheckBox();
            this.btnSaveTags = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCancel.Location = new System.Drawing.Point(297, 564);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 65);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Location = new System.Drawing.Point(51, 564);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 65);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.buttonBrowse.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.buttonBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBrowse.Location = new System.Drawing.Point(609, 564);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(110, 65);
            this.buttonBrowse.TabIndex = 22;
            this.buttonBrowse.Text = "Добавить фото";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.radioButtonFemale.Location = new System.Drawing.Point(128, 514);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(77, 20);
            this.radioButtonFemale.TabIndex = 20;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.radioButtonMale.Location = new System.Drawing.Point(51, 514);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(77, 20);
            this.radioButtonMale.TabIndex = 19;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(565, 466);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(205, 23);
            this.dateTimePickerBirthday.TabIndex = 49;
            this.dateTimePickerBirthday.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_ValueChanged_1);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtPhone.Location = new System.Drawing.Point(51, 446);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(337, 23);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(51, 488);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 23);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtLastName.Location = new System.Drawing.Point(51, 355);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(337, 23);
            this.txtLastName.TabIndex = 14;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtFirstName.Location = new System.Drawing.Point(51, 310);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(337, 23);
            this.txtFirstName.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(48, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Фамилия";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(48, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(48, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(48, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 206);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.update.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.update.Location = new System.Drawing.Point(872, 564);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(107, 65);
            this.update.TabIndex = 32;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.delete.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delete.Location = new System.Drawing.Point(172, 564);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 65);
            this.delete.TabIndex = 33;
            this.delete.Text = "Удалить пользователя";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // textBoxPatrom
            // 
            this.textBoxPatrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.textBoxPatrom.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxPatrom.Location = new System.Drawing.Point(51, 402);
            this.textBoxPatrom.Name = "textBoxPatrom";
            this.textBoxPatrom.Size = new System.Drawing.Size(337, 23);
            this.textBoxPatrom.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(48, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.Location = new System.Drawing.Point(619, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "День рождения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.Location = new System.Drawing.Point(266, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Регистрация";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateTimePickerReg
            // 
            this.dateTimePickerReg.Location = new System.Drawing.Point(217, 538);
            this.dateTimePickerReg.Name = "dateTimePickerReg";
            this.dateTimePickerReg.Size = new System.Drawing.Size(182, 20);
            this.dateTimePickerReg.TabIndex = 55;
            // 
            // checkBoxgreen
            // 
            this.checkBoxgreen.AutoSize = true;
            this.checkBoxgreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBoxgreen.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.checkBoxgreen.ForeColor = System.Drawing.Color.Black;
            this.checkBoxgreen.Location = new System.Drawing.Point(824, 65);
            this.checkBoxgreen.Name = "checkBoxgreen";
            this.checkBoxgreen.Size = new System.Drawing.Size(97, 20);
            this.checkBoxgreen.TabIndex = 56;
            this.checkBoxgreen.Text = "Постоянный";
            this.checkBoxgreen.UseVisualStyleBackColor = false;
            this.checkBoxgreen.CheckedChanged += new System.EventHandler(this.checkBoxgreen_CheckedChanged);
            // 
            // checkBoxred
            // 
            this.checkBoxred.AutoSize = true;
            this.checkBoxred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxred.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.checkBoxred.ForeColor = System.Drawing.Color.Black;
            this.checkBoxred.Location = new System.Drawing.Point(824, 91);
            this.checkBoxred.Name = "checkBoxred";
            this.checkBoxred.Size = new System.Drawing.Size(111, 20);
            this.checkBoxred.TabIndex = 57;
            this.checkBoxred.Text = "Непостоянный";
            this.checkBoxred.UseVisualStyleBackColor = false;
            this.checkBoxred.CheckedChanged += new System.EventHandler(this.checkBoxred_CheckedChanged);
            // 
            // checkBoxyellow
            // 
            this.checkBoxyellow.AutoSize = true;
            this.checkBoxyellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBoxyellow.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.checkBoxyellow.ForeColor = System.Drawing.Color.Black;
            this.checkBoxyellow.Location = new System.Drawing.Point(824, 117);
            this.checkBoxyellow.Name = "checkBoxyellow";
            this.checkBoxyellow.Size = new System.Drawing.Size(122, 20);
            this.checkBoxyellow.TabIndex = 58;
            this.checkBoxyellow.Text = "Редко посещает";
            this.checkBoxyellow.UseVisualStyleBackColor = false;
            this.checkBoxyellow.CheckedChanged += new System.EventHandler(this.checkBoxyellow_CheckedChanged);
            // 
            // checkBoxblack
            // 
            this.checkBoxblack.AutoSize = true;
            this.checkBoxblack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBoxblack.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.checkBoxblack.Location = new System.Drawing.Point(824, 143);
            this.checkBoxblack.Name = "checkBoxblack";
            this.checkBoxblack.Size = new System.Drawing.Size(176, 20);
            this.checkBoxblack.TabIndex = 59;
            this.checkBoxblack.Text = "Записался, но не пришел";
            this.checkBoxblack.UseVisualStyleBackColor = false;
            this.checkBoxblack.CheckedChanged += new System.EventHandler(this.checkBoxblack_CheckedChanged);
            // 
            // btnSaveTags
            // 
            this.btnSaveTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.btnSaveTags.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnSaveTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveTags.Location = new System.Drawing.Point(834, 182);
            this.btnSaveTags.Name = "btnSaveTags";
            this.btnSaveTags.Size = new System.Drawing.Size(105, 34);
            this.btnSaveTags.TabIndex = 60;
            this.btnSaveTags.Text = "Сохранить тег";
            this.btnSaveTags.UseVisualStyleBackColor = false;
            this.btnSaveTags.Click += new System.EventHandler(this.btnSaveTags_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(821, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Теги";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(565, 257);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(205, 168);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPhoto.TabIndex = 48;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.pictureBoxPhoto_Click);
            // 
            // ClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 649);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveTags);
            this.Controls.Add(this.checkBoxblack);
            this.Controls.Add(this.checkBoxyellow);
            this.Controls.Add(this.checkBoxred);
            this.Controls.Add(this.checkBoxgreen);
            this.Controls.Add(this.dateTimePickerReg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatrom);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientEdit";
            this.Text = "Редактирование клиентов";
            this.Load += new System.EventHandler(this.ClientEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBoxPatrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerReg;
        private System.Windows.Forms.CheckBox checkBoxgreen;
        private System.Windows.Forms.CheckBox checkBoxred;
        private System.Windows.Forms.CheckBox checkBoxyellow;
        private System.Windows.Forms.CheckBox checkBoxblack;
        private System.Windows.Forms.Button btnSaveTags;
        private System.Windows.Forms.Label label6;
    }
}