namespace BD
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonKino = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.radioButtonZal = new System.Windows.Forms.RadioButton();
            this.radioButtonSeans = new System.Windows.Forms.RadioButton();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.labelFilm = new System.Windows.Forms.Label();
            this.textBoxFilm = new System.Windows.Forms.TextBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_свободны = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_заняты = new System.Windows.Forms.RadioButton();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.radioButtonInsert_kino = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_kino = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete_kino = new System.Windows.Forms.RadioButton();
            this.labelId_kino = new System.Windows.Forms.Label();
            this.textBoxId_kino = new System.Windows.Forms.TextBox();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.textBoxAdress_kino = new System.Windows.Forms.TextBox();
            this.labelAdress_kino = new System.Windows.Forms.Label();
            this.labelName_kino = new System.Windows.Forms.Label();
            this.textBoxName_kino = new System.Windows.Forms.TextBox();
            this.labelRaion_kino = new System.Windows.Forms.Label();
            this.textBoxRaion_kino = new System.Windows.Forms.TextBox();
            this.labelKategoria_kino = new System.Windows.Forms.Label();
            this.textBoxKategoria_kino = new System.Windows.Forms.TextBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.panelKino = new System.Windows.Forms.Panel();
            this.dataGridViewKino = new System.Windows.Forms.DataGridView();
            this.buttonSelectKino = new System.Windows.Forms.Button();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.tabPageDML.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.panelKino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKino)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(1057, 553);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 421);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 315);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonSeans);
            this.groupBoxSelect.Controls.Add(this.radioButtonZal);
            this.groupBoxSelect.Controls.Add(this.radioButtonKino);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonKino
            // 
            this.radioButtonKino.AutoSize = true;
            this.radioButtonKino.Location = new System.Drawing.Point(59, 42);
            this.radioButtonKino.Name = "radioButtonKino";
            this.radioButtonKino.Size = new System.Drawing.Size(98, 20);
            this.radioButtonKino.TabIndex = 0;
            this.radioButtonKino.TabStop = true;
            this.radioButtonKino.Text = "Кинотеатр";
            this.radioButtonKino.UseVisualStyleBackColor = true;
            this.radioButtonKino.CheckedChanged += new System.EventHandler(this.radioButtonKino_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 421);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // radioButtonZal
            // 
            this.radioButtonZal.AutoSize = true;
            this.radioButtonZal.Location = new System.Drawing.Point(304, 42);
            this.radioButtonZal.Name = "radioButtonZal";
            this.radioButtonZal.Size = new System.Drawing.Size(53, 20);
            this.radioButtonZal.TabIndex = 1;
            this.radioButtonZal.TabStop = true;
            this.radioButtonZal.Text = "Зал";
            this.radioButtonZal.UseVisualStyleBackColor = true;
            this.radioButtonZal.CheckedChanged += new System.EventHandler(this.radioButtonZal_CheckedChanged);
            // 
            // radioButtonSeans
            // 
            this.radioButtonSeans.AutoSize = true;
            this.radioButtonSeans.Location = new System.Drawing.Point(508, 42);
            this.radioButtonSeans.Name = "radioButtonSeans";
            this.radioButtonSeans.Size = new System.Drawing.Size(68, 20);
            this.radioButtonSeans.TabIndex = 2;
            this.radioButtonSeans.TabStop = true;
            this.radioButtonSeans.Text = "Сеанс";
            this.radioButtonSeans.UseVisualStyleBackColor = true;
            this.radioButtonSeans.CheckedChanged += new System.EventHandler(this.radioButtonSeans_CheckedChanged);
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxFilm);
            this.groupBoxFSelect.Controls.Add(this.labelFilm);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 125);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Количество свободных мест";
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Location = new System.Drawing.Point(8, 33);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(127, 16);
            this.labelFilm.TabIndex = 0;
            this.labelFilm.Text = "Название фильма";
            // 
            // textBoxFilm
            // 
            this.textBoxFilm.Location = new System.Drawing.Point(142, 33);
            this.textBoxFilm.Name = "textBoxFilm";
            this.textBoxFilm.Size = new System.Drawing.Size(100, 22);
            this.textBoxFilm.TabIndex = 1;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_заняты);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_свободны);
            this.groupBoxDet.Location = new System.Drawing.Point(510, 14);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(242, 100);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация свободных мест";
            // 
            // radioButtonDet_свободны
            // 
            this.radioButtonDet_свободны.AutoSize = true;
            this.radioButtonDet_свободны.Location = new System.Drawing.Point(25, 22);
            this.radioButtonDet_свободны.Name = "radioButtonDet_свободны";
            this.radioButtonDet_свободны.Size = new System.Drawing.Size(144, 20);
            this.radioButtonDet_свободны.TabIndex = 0;
            this.radioButtonDet_свободны.TabStop = true;
            this.radioButtonDet_свободны.Text = "Свободные места";
            this.radioButtonDet_свободны.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_заняты
            // 
            this.radioButtonDet_заняты.AutoSize = true;
            this.radioButtonDet_заняты.Location = new System.Drawing.Point(25, 48);
            this.radioButtonDet_заняты.Name = "radioButtonDet_заняты";
            this.radioButtonDet_заняты.Size = new System.Drawing.Size(119, 20);
            this.radioButtonDet_заняты.TabIndex = 1;
            this.radioButtonDet_заняты.TabStop = true;
            this.radioButtonDet_заняты.Text = "Места заняты";
            this.radioButtonDet_заняты.UseVisualStyleBackColor = true;
            // 
            // buttonF_select
            // 
            this.buttonF_select.Location = new System.Drawing.Point(273, 91);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(215, 23);
            this.buttonF_select.TabIndex = 3;
            this.buttonF_select.Text = "Количество свободных мест";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 128);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.RowHeadersWidth = 51;
            this.dataGridViewFSelect.RowTemplate.Height = 24;
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 290);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.buttonSelectKino);
            this.tabPageDML.Controls.Add(this.dataGridViewKino);
            this.tabPageDML.Controls.Add(this.panelKino);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 25);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(1049, 524);
            this.tabPageDML.TabIndex = 2;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_kino
            // 
            this.radioButtonInsert_kino.AutoSize = true;
            this.radioButtonInsert_kino.Location = new System.Drawing.Point(42, 40);
            this.radioButtonInsert_kino.Name = "radioButtonInsert_kino";
            this.radioButtonInsert_kino.Size = new System.Drawing.Size(242, 20);
            this.radioButtonInsert_kino.TabIndex = 0;
            this.radioButtonInsert_kino.TabStop = true;
            this.radioButtonInsert_kino.Text = "Добавить данные по кинотеатру";
            this.radioButtonInsert_kino.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate_kino
            // 
            this.radioButtonUpdate_kino.AutoSize = true;
            this.radioButtonUpdate_kino.Location = new System.Drawing.Point(305, 40);
            this.radioButtonUpdate_kino.Name = "radioButtonUpdate_kino";
            this.radioButtonUpdate_kino.Size = new System.Drawing.Size(366, 20);
            this.radioButtonUpdate_kino.TabIndex = 1;
            this.radioButtonUpdate_kino.TabStop = true;
            this.radioButtonUpdate_kino.Text = "Изменить данные по кинотеатру с заданным кодом";
            this.radioButtonUpdate_kino.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelete_kino
            // 
            this.radioButtonDelete_kino.AutoSize = true;
            this.radioButtonDelete_kino.Location = new System.Drawing.Point(679, 40);
            this.radioButtonDelete_kino.Name = "radioButtonDelete_kino";
            this.radioButtonDelete_kino.Size = new System.Drawing.Size(356, 20);
            this.radioButtonDelete_kino.TabIndex = 2;
            this.radioButtonDelete_kino.TabStop = true;
            this.radioButtonDelete_kino.Text = "Удалить данные по кинотеатру с заданным кодом";
            this.radioButtonDelete_kino.UseVisualStyleBackColor = true;
            // 
            // labelId_kino
            // 
            this.labelId_kino.AutoSize = true;
            this.labelId_kino.Location = new System.Drawing.Point(54, 86);
            this.labelId_kino.Name = "labelId_kino";
            this.labelId_kino.Size = new System.Drawing.Size(90, 16);
            this.labelId_kino.TabIndex = 3;
            this.labelId_kino.Text = "Id кинотеатр";
            // 
            // textBoxId_kino
            // 
            this.textBoxId_kino.Location = new System.Drawing.Point(150, 86);
            this.textBoxId_kino.Name = "textBoxId_kino";
            this.textBoxId_kino.Size = new System.Drawing.Size(100, 22);
            this.textBoxId_kino.TabIndex = 4;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_kino);
            this.groupBoxDML.Controls.Add(this.labelId_kino);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_kino);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_kino);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_kino);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(1043, 128);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // textBoxAdress_kino
            // 
            this.textBoxAdress_kino.Location = new System.Drawing.Point(108, 39);
            this.textBoxAdress_kino.Name = "textBoxAdress_kino";
            this.textBoxAdress_kino.Size = new System.Drawing.Size(134, 22);
            this.textBoxAdress_kino.TabIndex = 1;
            // 
            // labelAdress_kino
            // 
            this.labelAdress_kino.AutoSize = true;
            this.labelAdress_kino.Location = new System.Drawing.Point(36, 44);
            this.labelAdress_kino.Name = "labelAdress_kino";
            this.labelAdress_kino.Size = new System.Drawing.Size(47, 16);
            this.labelAdress_kino.TabIndex = 2;
            this.labelAdress_kino.Text = "Адрес";
            // 
            // labelName_kino
            // 
            this.labelName_kino.AutoSize = true;
            this.labelName_kino.Location = new System.Drawing.Point(36, 108);
            this.labelName_kino.Name = "labelName_kino";
            this.labelName_kino.Size = new System.Drawing.Size(73, 16);
            this.labelName_kino.TabIndex = 4;
            this.labelName_kino.Text = "Название";
            // 
            // textBoxName_kino
            // 
            this.textBoxName_kino.Location = new System.Drawing.Point(115, 105);
            this.textBoxName_kino.Name = "textBoxName_kino";
            this.textBoxName_kino.Size = new System.Drawing.Size(127, 22);
            this.textBoxName_kino.TabIndex = 3;
            // 
            // labelRaion_kino
            // 
            this.labelRaion_kino.AutoSize = true;
            this.labelRaion_kino.Location = new System.Drawing.Point(457, 43);
            this.labelRaion_kino.Name = "labelRaion_kino";
            this.labelRaion_kino.Size = new System.Drawing.Size(48, 16);
            this.labelRaion_kino.TabIndex = 6;
            this.labelRaion_kino.Text = "Район";
            // 
            // textBoxRaion_kino
            // 
            this.textBoxRaion_kino.Location = new System.Drawing.Point(529, 38);
            this.textBoxRaion_kino.Name = "textBoxRaion_kino";
            this.textBoxRaion_kino.Size = new System.Drawing.Size(123, 22);
            this.textBoxRaion_kino.TabIndex = 5;
            // 
            // labelKategoria_kino
            // 
            this.labelKategoria_kino.AutoSize = true;
            this.labelKategoria_kino.Location = new System.Drawing.Point(459, 111);
            this.labelKategoria_kino.Name = "labelKategoria_kino";
            this.labelKategoria_kino.Size = new System.Drawing.Size(75, 16);
            this.labelKategoria_kino.TabIndex = 8;
            this.labelKategoria_kino.Text = "Категория";
            // 
            // textBoxKategoria_kino
            // 
            this.textBoxKategoria_kino.Location = new System.Drawing.Point(549, 108);
            this.textBoxKategoria_kino.Name = "textBoxKategoria_kino";
            this.textBoxKategoria_kino.Size = new System.Drawing.Size(121, 22);
            this.textBoxKategoria_kino.TabIndex = 7;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(439, 84);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(137, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // panelKino
            // 
            this.panelKino.Controls.Add(this.textBoxRaion_kino);
            this.panelKino.Controls.Add(this.labelKategoria_kino);
            this.panelKino.Controls.Add(this.textBoxAdress_kino);
            this.panelKino.Controls.Add(this.textBoxKategoria_kino);
            this.panelKino.Controls.Add(this.labelAdress_kino);
            this.panelKino.Controls.Add(this.labelRaion_kino);
            this.panelKino.Controls.Add(this.textBoxName_kino);
            this.panelKino.Controls.Add(this.labelName_kino);
            this.panelKino.Location = new System.Drawing.Point(6, 137);
            this.panelKino.Name = "panelKino";
            this.panelKino.Size = new System.Drawing.Size(1032, 172);
            this.panelKino.TabIndex = 9;
            // 
            // dataGridViewKino
            // 
            this.dataGridViewKino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKino.Location = new System.Drawing.Point(8, 366);
            this.dataGridViewKino.Name = "dataGridViewKino";
            this.dataGridViewKino.RowHeadersWidth = 51;
            this.dataGridViewKino.RowTemplate.Height = 24;
            this.dataGridViewKino.Size = new System.Drawing.Size(1030, 150);
            this.dataGridViewKino.TabIndex = 10;
            // 
            // buttonSelectKino
            // 
            this.buttonSelectKino.Location = new System.Drawing.Point(409, 327);
            this.buttonSelectKino.Name = "buttonSelectKino";
            this.buttonSelectKino.Size = new System.Drawing.Size(216, 23);
            this.buttonSelectKino.TabIndex = 11;
            this.buttonSelectKino.Text = "Показать список кинотеатров";
            this.buttonSelectKino.UseVisualStyleBackColor = true;
            this.buttonSelectKino.Click += new System.EventHandler(this.buttonSelectKino_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 553);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.tabPageDML.ResumeLayout(false);
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.panelKino.ResumeLayout(false);
            this.panelKino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonKino;
        private System.Windows.Forms.RadioButton radioButtonZal;
        private System.Windows.Forms.RadioButton radioButtonSeans;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_заняты;
        private System.Windows.Forms.RadioButton radioButtonDet_свободны;
        private System.Windows.Forms.TextBox textBoxFilm;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.Button buttonSelectKino;
        private System.Windows.Forms.DataGridView dataGridViewKino;
        private System.Windows.Forms.Panel panelKino;
        private System.Windows.Forms.TextBox textBoxRaion_kino;
        private System.Windows.Forms.Label labelKategoria_kino;
        private System.Windows.Forms.TextBox textBoxAdress_kino;
        private System.Windows.Forms.TextBox textBoxKategoria_kino;
        private System.Windows.Forms.Label labelAdress_kino;
        private System.Windows.Forms.Label labelRaion_kino;
        private System.Windows.Forms.TextBox textBoxName_kino;
        private System.Windows.Forms.Label labelName_kino;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.TextBox textBoxId_kino;
        private System.Windows.Forms.Label labelId_kino;
        private System.Windows.Forms.RadioButton radioButtonDelete_kino;
        private System.Windows.Forms.RadioButton radioButtonUpdate_kino;
        private System.Windows.Forms.RadioButton radioButtonInsert_kino;
    }
}