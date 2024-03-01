namespace ClientDB4._0
{
    partial class ClientControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.labelNameService = new System.Windows.Forms.Label();
            this.Countfile = new System.Windows.Forms.Label();
            this.buttonopenfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNameService
            // 
            this.labelNameService.AutoSize = true;
            this.labelNameService.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelNameService.Location = new System.Drawing.Point(22, 10);
            this.labelNameService.Name = "labelNameService";
            this.labelNameService.Size = new System.Drawing.Size(41, 16);
            this.labelNameService.TabIndex = 0;
            this.labelNameService.Text = "label1";
            // 
            // Countfile
            // 
            this.Countfile.AutoSize = true;
            this.Countfile.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Countfile.Location = new System.Drawing.Point(22, 43);
            this.Countfile.Name = "Countfile";
            this.Countfile.Size = new System.Drawing.Size(41, 16);
            this.Countfile.TabIndex = 1;
            this.Countfile.Text = "label2";
            this.Countfile.Click += new System.EventHandler(this.Countfile_Click);
            // 
            // buttonopenfile
            // 
            this.buttonopenfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.buttonopenfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonopenfile.Location = new System.Drawing.Point(321, 0);
            this.buttonopenfile.Name = "buttonopenfile";
            this.buttonopenfile.Size = new System.Drawing.Size(75, 96);
            this.buttonopenfile.TabIndex = 3;
            this.buttonopenfile.Text = ">";
            this.buttonopenfile.UseVisualStyleBackColor = false;
            this.buttonopenfile.Click += new System.EventHandler(this.buttonopenfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonopenfile);
            this.Controls.Add(this.Countfile);
            this.Controls.Add(this.labelNameService);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(396, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameService;
        private System.Windows.Forms.Label Countfile;
        private System.Windows.Forms.Button buttonopenfile;
        private System.Windows.Forms.Label label1;
    }
}
