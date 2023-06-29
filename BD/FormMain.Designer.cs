
namespace BD
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информация_О_КинотеатреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Информация_О_ЗалеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Информация_О_СеансеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Информация_О_ФильмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ВыходToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.О_ПрограммеToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Информация_О_КинотеатреToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Информация_О_ЗалеToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Информация_О_СеансеToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Информация_О_ФильмеToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ЗапросыToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1067, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информация_О_КинотеатреToolStripMenuItem,
            this.Информация_О_ЗалеToolStripMenuItem,
            this.Информация_О_СеансеToolStripMenuItem,
            this.Информация_О_ФильмеToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // информация_О_КинотеатреToolStripMenuItem
            // 
            this.информация_О_КинотеатреToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("информация_О_КинотеатреToolStripMenuItem.Image")));
            this.информация_О_КинотеатреToolStripMenuItem.Name = "информация_О_КинотеатреToolStripMenuItem";
            this.информация_О_КинотеатреToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.информация_О_КинотеатреToolStripMenuItem.Text = "Информация о кинотеатре";
            this.информация_О_КинотеатреToolStripMenuItem.Click += new System.EventHandler(this.Информация_О_КинотеатреToolStripMenuItem_Click);
            // 
            // Информация_О_ЗалеToolStripMenuItem
            // 
            this.Информация_О_ЗалеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Информация_О_ЗалеToolStripMenuItem.Image")));
            this.Информация_О_ЗалеToolStripMenuItem.Name = "Информация_О_ЗалеToolStripMenuItem";
            this.Информация_О_ЗалеToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.Информация_О_ЗалеToolStripMenuItem.Text = "Информация о зале";
            this.Информация_О_ЗалеToolStripMenuItem.Click += new System.EventHandler(this.Информация_О_ЗалеToolStripMenuItem_Click);
            // 
            // Информация_О_СеансеToolStripMenuItem
            // 
            this.Информация_О_СеансеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Информация_О_СеансеToolStripMenuItem.Image")));
            this.Информация_О_СеансеToolStripMenuItem.Name = "Информация_О_СеансеToolStripMenuItem";
            this.Информация_О_СеансеToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.Информация_О_СеансеToolStripMenuItem.Text = "Информация о сеансе";
            this.Информация_О_СеансеToolStripMenuItem.Click += new System.EventHandler(this.Информация_О_СеансеToolStripMenuItem_Click);
            // 
            // Информация_О_ФильмеToolStripMenuItem
            // 
            this.Информация_О_ФильмеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Информация_О_ФильмеToolStripMenuItem.Image")));
            this.Информация_О_ФильмеToolStripMenuItem.Name = "Информация_О_ФильмеToolStripMenuItem";
            this.Информация_О_ФильмеToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.Информация_О_ФильмеToolStripMenuItem.Text = "Информация о фильме";
            this.Информация_О_ФильмеToolStripMenuItem.Click += new System.EventHandler(this.Информация_О_ФильмеToolStripMenuItem_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(191, 56);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem1.Image")));
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem1.Image")));
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.оПрограммеToolStripMenuItem1.Text = "О программе ...";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ВыходToolStripButton,
            this.О_ПрограммеToolStripButton,
            this.Информация_О_КинотеатреToolStripButton,
            this.Информация_О_ЗалеToolStripButton,
            this.Информация_О_СеансеToolStripButton,
            this.Информация_О_ФильмеToolStripButton,
            this.ЗапросыToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ВыходToolStripButton
            // 
            this.ВыходToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ВыходToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ВыходToolStripButton.Image")));
            this.ВыходToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ВыходToolStripButton.Name = "ВыходToolStripButton";
            this.ВыходToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.ВыходToolStripButton.Text = "Выход";
            this.ВыходToolStripButton.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // О_ПрограммеToolStripButton
            // 
            this.О_ПрограммеToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.О_ПрограммеToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("О_ПрограммеToolStripButton.Image")));
            this.О_ПрограммеToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.О_ПрограммеToolStripButton.Name = "О_ПрограммеToolStripButton";
            this.О_ПрограммеToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.О_ПрограммеToolStripButton.Text = "О Программе";
            this.О_ПрограммеToolStripButton.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Информация_О_КинотеатреToolStripButton
            // 
            this.Информация_О_КинотеатреToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Информация_О_КинотеатреToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Информация_О_КинотеатреToolStripButton.Image")));
            this.Информация_О_КинотеатреToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Информация_О_КинотеатреToolStripButton.Name = "Информация_О_КинотеатреToolStripButton";
            this.Информация_О_КинотеатреToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.Информация_О_КинотеатреToolStripButton.Text = "Информация о кинотеатре";
            this.Информация_О_КинотеатреToolStripButton.Click += new System.EventHandler(this.Информация_О_КинотеатреToolStripMenuItem_Click);
            // 
            // Информация_О_ЗалеToolStripButton
            // 
            this.Информация_О_ЗалеToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Информация_О_ЗалеToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Информация_О_ЗалеToolStripButton.Image")));
            this.Информация_О_ЗалеToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Информация_О_ЗалеToolStripButton.Name = "Информация_О_ЗалеToolStripButton";
            this.Информация_О_ЗалеToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.Информация_О_ЗалеToolStripButton.Text = "Информация о зале";
            this.Информация_О_ЗалеToolStripButton.Click += new System.EventHandler(this.Информация_О_ЗалеToolStripMenuItem_Click);
            // 
            // Информация_О_СеансеToolStripButton
            // 
            this.Информация_О_СеансеToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Информация_О_СеансеToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Информация_О_СеансеToolStripButton.Image")));
            this.Информация_О_СеансеToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Информация_О_СеансеToolStripButton.Name = "Информация_О_СеансеToolStripButton";
            this.Информация_О_СеансеToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.Информация_О_СеансеToolStripButton.Text = "Информация о сеансе";
            this.Информация_О_СеансеToolStripButton.Click += new System.EventHandler(this.Информация_О_СеансеToolStripMenuItem_Click);
            // 
            // Информация_О_ФильмеToolStripButton
            // 
            this.Информация_О_ФильмеToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Информация_О_ФильмеToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Информация_О_ФильмеToolStripButton.Image")));
            this.Информация_О_ФильмеToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Информация_О_ФильмеToolStripButton.Name = "Информация_О_ФильмеToolStripButton";
            this.Информация_О_ФильмеToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.Информация_О_ФильмеToolStripButton.Text = "Информация о фильме";
            this.Информация_О_ФильмеToolStripButton.Click += new System.EventHandler(this.Информация_О_ФильмеToolStripMenuItem_Click);
            // 
            // ЗапросыToolStripButton
            // 
            this.ЗапросыToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ЗапросыToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ЗапросыToolStripButton.Image")));
            this.ЗапросыToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ЗапросыToolStripButton.Name = "ЗапросыToolStripButton";
            this.ЗапросыToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.ЗапросыToolStripButton.Text = "Запросы";
            this.ЗапросыToolStripButton.Click += new System.EventHandler(this.ЗапросыToolStripButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripMain);
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Программа для справочной службы кинотеатров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информация_О_КинотеатреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Информация_О_ЗалеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Информация_О_СеансеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ВыходToolStripButton;
        private System.Windows.Forms.ToolStripButton О_ПрограммеToolStripButton;
        private System.Windows.Forms.ToolStripButton Информация_О_КинотеатреToolStripButton;
        private System.Windows.Forms.ToolStripButton Информация_О_ЗалеToolStripButton;
        private System.Windows.Forms.ToolStripButton Информация_О_СеансеToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem Информация_О_ФильмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Информация_О_ФильмеToolStripButton;
        private System.Windows.Forms.ToolStripButton ЗапросыToolStripButton;
    }
}

