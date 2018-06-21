namespace Dic
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
            this.textBoxAddEn = new System.Windows.Forms.TextBox();
            this.textBoxAddRus = new System.Windows.Forms.TextBox();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelRussian = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemoveEn = new System.Windows.Forms.Button();
            this.buttonRemoveRus = new System.Windows.Forms.Button();
            this.comboBoxEn = new System.Windows.Forms.ComboBox();
            this.comboBoxRus = new System.Windows.Forms.ComboBox();
            this.listBoxRus = new System.Windows.Forms.ListBox();
            this.listBoxEn = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxAddEn
            // 
            this.textBoxAddEn.Location = new System.Drawing.Point(139, 55);
            this.textBoxAddEn.Name = "textBoxAddEn";
            this.textBoxAddEn.Size = new System.Drawing.Size(143, 22);
            this.textBoxAddEn.TabIndex = 0;
            // 
            // textBoxAddRus
            // 
            this.textBoxAddRus.Location = new System.Drawing.Point(369, 55);
            this.textBoxAddRus.Name = "textBoxAddRus";
            this.textBoxAddRus.Size = new System.Drawing.Size(143, 22);
            this.textBoxAddRus.TabIndex = 1;
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Location = new System.Drawing.Point(9, 34);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(54, 17);
            this.labelEnglish.TabIndex = 4;
            this.labelEnglish.Text = "English";
            // 
            // labelRussian
            // 
            this.labelRussian.AutoSize = true;
            this.labelRussian.Location = new System.Drawing.Point(366, 34);
            this.labelRussian.Name = "labelRussian";
            this.labelRussian.Size = new System.Drawing.Size(59, 17);
            this.labelRussian.TabIndex = 5;
            this.labelRussian.Text = "Russian";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(288, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemoveEn
            // 
            this.buttonRemoveEn.Location = new System.Drawing.Point(437, 333);
            this.buttonRemoveEn.Name = "buttonRemoveEn";
            this.buttonRemoveEn.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveEn.TabIndex = 7;
            this.buttonRemoveEn.Text = "Remove";
            this.buttonRemoveEn.UseVisualStyleBackColor = true;
            this.buttonRemoveEn.Click += new System.EventHandler(this.buttonRemoveEn_Click);
            // 
            // buttonRemoveRus
            // 
            this.buttonRemoveRus.Location = new System.Drawing.Point(207, 333);
            this.buttonRemoveRus.Name = "buttonRemoveRus";
            this.buttonRemoveRus.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveRus.TabIndex = 8;
            this.buttonRemoveRus.Text = "Remove";
            this.buttonRemoveRus.UseVisualStyleBackColor = true;
            this.buttonRemoveRus.Click += new System.EventHandler(this.buttonRemoveRus_Click);
            // 
            // comboBoxEn
            // 
            this.comboBoxEn.FormattingEnabled = true;
            this.comboBoxEn.Location = new System.Drawing.Point(12, 53);
            this.comboBoxEn.Name = "comboBoxEn";
            this.comboBoxEn.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEn.TabIndex = 9;
            this.comboBoxEn.SelectedIndexChanged += new System.EventHandler(this.comboBoxEn_SelectedIndexChanged);
            // 
            // comboBoxRus
            // 
            this.comboBoxRus.FormattingEnabled = true;
            this.comboBoxRus.Location = new System.Drawing.Point(518, 53);
            this.comboBoxRus.Name = "comboBoxRus";
            this.comboBoxRus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRus.TabIndex = 10;
            this.comboBoxRus.SelectedIndexChanged += new System.EventHandler(this.comboBoxRus_SelectedIndexChanged);
            // 
            // listBoxRus
            // 
            this.listBoxRus.FormattingEnabled = true;
            this.listBoxRus.ItemHeight = 16;
            this.listBoxRus.Location = new System.Drawing.Point(139, 83);
            this.listBoxRus.Name = "listBoxRus";
            this.listBoxRus.Size = new System.Drawing.Size(143, 244);
            this.listBoxRus.TabIndex = 11;
            // 
            // listBoxEn
            // 
            this.listBoxEn.FormattingEnabled = true;
            this.listBoxEn.ItemHeight = 16;
            this.listBoxEn.Location = new System.Drawing.Point(369, 83);
            this.listBoxEn.Name = "listBoxEn";
            this.listBoxEn.Size = new System.Drawing.Size(143, 244);
            this.listBoxEn.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxEn);
            this.Controls.Add(this.listBoxRus);
            this.Controls.Add(this.comboBoxRus);
            this.Controls.Add(this.comboBoxEn);
            this.Controls.Add(this.buttonRemoveRus);
            this.Controls.Add(this.buttonRemoveEn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelRussian);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.textBoxAddRus);
            this.Controls.Add(this.textBoxAddEn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddEn;
        private System.Windows.Forms.TextBox textBoxAddRus;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelRussian;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemoveEn;
        private System.Windows.Forms.Button buttonRemoveRus;
        private System.Windows.Forms.ComboBox comboBoxEn;
        private System.Windows.Forms.ComboBox comboBoxRus;
        private System.Windows.Forms.ListBox listBoxRus;
        private System.Windows.Forms.ListBox listBoxEn;
    }
}

