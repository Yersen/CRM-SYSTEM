namespace CrmUI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продавецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарToolStripMenuItem,
            this.продавецToolStripMenuItem,
            this.покупательToolStripMenuItem,
            this.чекToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            this.сущностиToolStripMenuItem.Click += new System.EventHandler(this.сущностиToolStripMenuItem_Click);
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.товарToolStripMenuItem.Text = "Товар";
            // 
            // продавецToolStripMenuItem
            // 
            this.продавецToolStripMenuItem.Name = "продавецToolStripMenuItem";
            this.продавецToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.продавецToolStripMenuItem.Text = "Продавец";
            // 
            // покупательToolStripMenuItem
            // 
            this.покупательToolStripMenuItem.Name = "покупательToolStripMenuItem";
            this.покупательToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.покупательToolStripMenuItem.Text = "Покупатель";
            // 
            // чекToolStripMenuItem
            // 
            this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            this.чекToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.чекToolStripMenuItem.Text = "Чек";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чекToolStripMenuItem;
    }
}

