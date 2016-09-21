namespace AttributeChangerWF
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label_Path = new System.Windows.Forms.Label();
            this.button_Directory = new System.Windows.Forms.Button();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.groupBox_Attributes = new System.Windows.Forms.GroupBox();
            this.checkBox_Archives = new System.Windows.Forms.CheckBox();
            this.checkBox_System = new System.Windows.Forms.CheckBox();
            this.checkBox_Hidden = new System.Windows.Forms.CheckBox();
            this.checkBox_ReadOnly = new System.Windows.Forms.CheckBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBox_Attributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(482, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_OpenFile,
            this.ToolStripMenuItem_OpenDirectory,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(57, 24);
            this.ToolStripMenuItem_File.Text = "Файл";
            // 
            // ToolStripMenuItem_OpenFile
            // 
            this.ToolStripMenuItem_OpenFile.Name = "ToolStripMenuItem_OpenFile";
            this.ToolStripMenuItem_OpenFile.Size = new System.Drawing.Size(189, 26);
            this.ToolStripMenuItem_OpenFile.Text = "Відкрити файл";
            this.ToolStripMenuItem_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // ToolStripMenuItem_OpenDirectory
            // 
            this.ToolStripMenuItem_OpenDirectory.Name = "ToolStripMenuItem_OpenDirectory";
            this.ToolStripMenuItem_OpenDirectory.Size = new System.Drawing.Size(189, 26);
            this.ToolStripMenuItem_OpenDirectory.Text = "Відкрити папку";
            this.ToolStripMenuItem_OpenDirectory.Click += new System.EventHandler(this.button_Directory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(189, 26);
            this.ToolStripMenuItem_Exit.Text = "Вихід";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Path.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Path.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_Path.Location = new System.Drawing.Point(12, 80);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(458, 27);
            this.textBox_Path.TabIndex = 1;
            this.textBox_Path.TabStop = false;
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(21, 50);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(45, 17);
            this.label_Path.TabIndex = 2;
            this.label_Path.Text = "Шлях:";
            // 
            // button_Directory
            // 
            this.button_Directory.Location = new System.Drawing.Point(12, 130);
            this.button_Directory.Name = "button_Directory";
            this.button_Directory.Size = new System.Drawing.Size(225, 35);
            this.button_Directory.TabIndex = 3;
            this.button_Directory.Text = "Відкрити каталог";
            this.button_Directory.UseVisualStyleBackColor = true;
            this.button_Directory.Click += new System.EventHandler(this.button_Directory_Click);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(245, 130);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(225, 35);
            this.button_OpenFile.TabIndex = 4;
            this.button_OpenFile.Text = "Відкрити файл";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // groupBox_Attributes
            // 
            this.groupBox_Attributes.Controls.Add(this.checkBox_Archives);
            this.groupBox_Attributes.Controls.Add(this.checkBox_System);
            this.groupBox_Attributes.Controls.Add(this.checkBox_Hidden);
            this.groupBox_Attributes.Controls.Add(this.checkBox_ReadOnly);
            this.groupBox_Attributes.Location = new System.Drawing.Point(12, 239);
            this.groupBox_Attributes.Name = "groupBox_Attributes";
            this.groupBox_Attributes.Size = new System.Drawing.Size(458, 276);
            this.groupBox_Attributes.TabIndex = 5;
            this.groupBox_Attributes.TabStop = false;
            this.groupBox_Attributes.Text = "Атрибути";
            // 
            // checkBox_Archives
            // 
            this.checkBox_Archives.AutoSize = true;
            this.checkBox_Archives.Enabled = false;
            this.checkBox_Archives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Archives.Location = new System.Drawing.Point(12, 55);
            this.checkBox_Archives.Name = "checkBox_Archives";
            this.checkBox_Archives.Size = new System.Drawing.Size(105, 24);
            this.checkBox_Archives.TabIndex = 1;
            this.checkBox_Archives.Text = "Архівний";
            this.checkBox_Archives.UseVisualStyleBackColor = true;
            // 
            // checkBox_System
            // 
            this.checkBox_System.AutoSize = true;
            this.checkBox_System.Enabled = false;
            this.checkBox_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_System.Location = new System.Drawing.Point(12, 205);
            this.checkBox_System.Name = "checkBox_System";
            this.checkBox_System.Size = new System.Drawing.Size(124, 24);
            this.checkBox_System.TabIndex = 4;
            this.checkBox_System.Text = "Системний";
            this.checkBox_System.UseVisualStyleBackColor = true;
            // 
            // checkBox_Hidden
            // 
            this.checkBox_Hidden.AutoSize = true;
            this.checkBox_Hidden.Enabled = false;
            this.checkBox_Hidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Hidden.Location = new System.Drawing.Point(12, 155);
            this.checkBox_Hidden.Name = "checkBox_Hidden";
            this.checkBox_Hidden.Size = new System.Drawing.Size(132, 24);
            this.checkBox_Hidden.TabIndex = 3;
            this.checkBox_Hidden.Text = "Прихований";
            this.checkBox_Hidden.UseVisualStyleBackColor = true;
            // 
            // checkBox_ReadOnly
            // 
            this.checkBox_ReadOnly.AutoSize = true;
            this.checkBox_ReadOnly.Enabled = false;
            this.checkBox_ReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ReadOnly.Location = new System.Drawing.Point(12, 105);
            this.checkBox_ReadOnly.Name = "checkBox_ReadOnly";
            this.checkBox_ReadOnly.Size = new System.Drawing.Size(196, 24);
            this.checkBox_ReadOnly.TabIndex = 2;
            this.checkBox_ReadOnly.Text = "Тільки для читання";
            this.checkBox_ReadOnly.UseVisualStyleBackColor = true;
            // 
            // button_Apply
            // 
            this.button_Apply.Enabled = false;
            this.button_Apply.Location = new System.Drawing.Point(12, 570);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(225, 35);
            this.button_Apply.TabIndex = 6;
            this.button_Apply.Text = "Застосувати";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancle
            // 
            this.button_Cancle.Enabled = false;
            this.button_Cancle.Location = new System.Drawing.Point(245, 570);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(225, 35);
            this.button_Cancle.TabIndex = 6;
            this.button_Cancle.Text = "Відміна";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.groupBox_Attributes);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.button_Directory);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Attribute Changer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_Attributes.ResumeLayout(false);
            this.groupBox_Attributes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenDirectory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Button button_Directory;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.GroupBox groupBox_Attributes;
        private System.Windows.Forms.CheckBox checkBox_ReadOnly;
        private System.Windows.Forms.CheckBox checkBox_Archives;
        private System.Windows.Forms.CheckBox checkBox_System;
        private System.Windows.Forms.CheckBox checkBox_Hidden;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Cancle;
    }
}

