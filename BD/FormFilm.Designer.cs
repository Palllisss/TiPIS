namespace BD
{
    partial class FormFilm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_фильмаLabel;
            System.Windows.Forms.Label id_кинотеатраLabel;
            System.Windows.Forms.Label наградыLabel;
            System.Windows.Forms.Label операторLabel;
            System.Windows.Forms.Label режиссерLabel;
            System.Windows.Forms.Label актерыLabel;
            System.Windows.Forms.Label кадр_из_фильмаLabel;
            System.Windows.Forms.Label длительностьLabel;
            System.Windows.Forms.Label прокатная_стоимостьLabel;
            System.Windows.Forms.Label странаLabel;
            System.Windows.Forms.Label год_производстваLabel;
            System.Windows.Forms.Label жанрLabel;
            System.Windows.Forms.Label название_фильмаLabel;
            System.Windows.Forms.Label id_названияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilm));
            this.фильмBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.фильмBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочная_служба_кинотеатровDataSet = new BD.Справочная_служба_кинотеатровDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.фильмBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_фильмаTextBox = new System.Windows.Forms.TextBox();
            this.id_кинотеатраTextBox = new System.Windows.Forms.TextBox();
            this.наградыCheckBox = new System.Windows.Forms.CheckBox();
            this.операторTextBox = new System.Windows.Forms.TextBox();
            this.режиссерTextBox = new System.Windows.Forms.TextBox();
            this.актерыTextBox = new System.Windows.Forms.TextBox();
            this.фотоPictureBox = new System.Windows.Forms.PictureBox();
            this.длительностьTextBox = new System.Windows.Forms.TextBox();
            this.прокатная_стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.странаTextBox = new System.Windows.Forms.TextBox();
            this.год_производстваDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.жанрTextBox = new System.Windows.Forms.TextBox();
            this.название_фильмаTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.buttonKino = new System.Windows.Forms.Button();
            this.id_названияTextBox = new System.Windows.Forms.TextBox();
            this.фильмTableAdapter = new BD.Справочная_служба_кинотеатровDataSetTableAdapters.ФильмTableAdapter();
            this.tableAdapterManager = new BD.Справочная_служба_кинотеатровDataSetTableAdapters.TableAdapterManager();
            this.кинотеатрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрTableAdapter = new BD.Справочная_служба_кинотеатровDataSetTableAdapters.КинотеатрTableAdapter();
            id_фильмаLabel = new System.Windows.Forms.Label();
            id_кинотеатраLabel = new System.Windows.Forms.Label();
            наградыLabel = new System.Windows.Forms.Label();
            операторLabel = new System.Windows.Forms.Label();
            режиссерLabel = new System.Windows.Forms.Label();
            актерыLabel = new System.Windows.Forms.Label();
            кадр_из_фильмаLabel = new System.Windows.Forms.Label();
            длительностьLabel = new System.Windows.Forms.Label();
            прокатная_стоимостьLabel = new System.Windows.Forms.Label();
            странаLabel = new System.Windows.Forms.Label();
            год_производстваLabel = new System.Windows.Forms.Label();
            жанрLabel = new System.Windows.Forms.Label();
            название_фильмаLabel = new System.Windows.Forms.Label();
            id_названияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingNavigator)).BeginInit();
            this.фильмBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочная_служба_кинотеатровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_фильмаLabel
            // 
            id_фильмаLabel.AutoSize = true;
            id_фильмаLabel.Location = new System.Drawing.Point(12, 41);
            id_фильмаLabel.Name = "id_фильмаLabel";
            id_фильмаLabel.Size = new System.Drawing.Size(75, 16);
            id_фильмаLabel.TabIndex = 1;
            id_фильмаLabel.Text = "Id фильма:";
            // 
            // id_кинотеатраLabel
            // 
            id_кинотеатраLabel.AutoSize = true;
            id_кинотеатраLabel.Location = new System.Drawing.Point(12, 69);
            id_кинотеатраLabel.Name = "id_кинотеатраLabel";
            id_кинотеатраLabel.Size = new System.Drawing.Size(101, 16);
            id_кинотеатраLabel.TabIndex = 3;
            id_кинотеатраLabel.Text = "Id кинотеатра:";
            // 
            // наградыLabel
            // 
            наградыLabel.AutoSize = true;
            наградыLabel.Location = new System.Drawing.Point(389, 128);
            наградыLabel.Name = "наградыLabel";
            наградыLabel.Size = new System.Drawing.Size(67, 16);
            наградыLabel.TabIndex = 5;
            наградыLabel.Text = "Награды:";
            // 
            // операторLabel
            // 
            операторLabel.AutoSize = true;
            операторLabel.Location = new System.Drawing.Point(12, 97);
            операторLabel.Name = "операторLabel";
            операторLabel.Size = new System.Drawing.Size(75, 16);
            операторLabel.TabIndex = 7;
            операторLabel.Text = "Оператор:";
            // 
            // режиссерLabel
            // 
            режиссерLabel.AutoSize = true;
            режиссерLabel.Location = new System.Drawing.Point(12, 125);
            режиссерLabel.Name = "режиссерLabel";
            режиссерLabel.Size = new System.Drawing.Size(74, 16);
            режиссерLabel.TabIndex = 9;
            режиссерLabel.Text = "Режиссер:";
            // 
            // актерыLabel
            // 
            актерыLabel.AutoSize = true;
            актерыLabel.Location = new System.Drawing.Point(480, 206);
            актерыLabel.Name = "актерыLabel";
            актерыLabel.Size = new System.Drawing.Size(58, 16);
            актерыLabel.TabIndex = 11;
            актерыLabel.Text = "Актеры:";
            // 
            // кадр_из_фильмаLabel
            // 
            кадр_из_фильмаLabel.AutoSize = true;
            кадр_из_фильмаLabel.Location = new System.Drawing.Point(459, 27);
            кадр_из_фильмаLabel.Name = "кадр_из_фильмаLabel";
            кадр_из_фильмаLabel.Size = new System.Drawing.Size(115, 16);
            кадр_из_фильмаLabel.TabIndex = 13;
            кадр_из_фильмаLabel.Text = "Кадр из фильма:";
            // 
            // длительностьLabel
            // 
            длительностьLabel.AutoSize = true;
            длительностьLabel.Location = new System.Drawing.Point(12, 153);
            длительностьLabel.Name = "длительностьLabel";
            длительностьLabel.Size = new System.Drawing.Size(102, 16);
            длительностьLabel.TabIndex = 15;
            длительностьLabel.Text = "Длительность:";
            // 
            // прокатная_стоимостьLabel
            // 
            прокатная_стоимостьLabel.AutoSize = true;
            прокатная_стоимостьLabel.Location = new System.Drawing.Point(12, 181);
            прокатная_стоимостьLabel.Name = "прокатная_стоимостьLabel";
            прокатная_стоимостьLabel.Size = new System.Drawing.Size(152, 16);
            прокатная_стоимостьLabel.TabIndex = 17;
            прокатная_стоимостьLabel.Text = "Прокатная стоимость:";
            // 
            // странаLabel
            // 
            странаLabel.AutoSize = true;
            странаLabel.Location = new System.Drawing.Point(12, 209);
            странаLabel.Name = "странаLabel";
            странаLabel.Size = new System.Drawing.Size(58, 16);
            странаLabel.TabIndex = 19;
            странаLabel.Text = "Страна:";
            // 
            // год_производстваLabel
            // 
            год_производстваLabel.AutoSize = true;
            год_производстваLabel.Location = new System.Drawing.Point(12, 238);
            год_производстваLabel.Name = "год_производстваLabel";
            год_производстваLabel.Size = new System.Drawing.Size(130, 16);
            год_производстваLabel.TabIndex = 21;
            год_производстваLabel.Text = "Год производства:";
            // 
            // жанрLabel
            // 
            жанрLabel.AutoSize = true;
            жанрLabel.Location = new System.Drawing.Point(12, 265);
            жанрLabel.Name = "жанрLabel";
            жанрLabel.Size = new System.Drawing.Size(47, 16);
            жанрLabel.TabIndex = 23;
            жанрLabel.Text = "Жанр:";
            // 
            // название_фильмаLabel
            // 
            название_фильмаLabel.AutoSize = true;
            название_фильмаLabel.Location = new System.Drawing.Point(12, 293);
            название_фильмаLabel.Name = "название_фильмаLabel";
            название_фильмаLabel.Size = new System.Drawing.Size(130, 16);
            название_фильмаLabel.TabIndex = 25;
            название_фильмаLabel.Text = "Название фильма:";
            // 
            // id_названияLabel
            // 
            id_названияLabel.AutoSize = true;
            id_названияLabel.Location = new System.Drawing.Point(557, 309);
            id_названияLabel.Name = "id_названияLabel";
            id_названияLabel.Size = new System.Drawing.Size(87, 16);
            id_названияLabel.TabIndex = 31;
            id_названияLabel.Text = "Id названия:";
            // 
            // фильмBindingNavigator
            // 
            this.фильмBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.фильмBindingNavigator.BindingSource = this.фильмBindingSource;
            this.фильмBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.фильмBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.фильмBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.фильмBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.фильмBindingNavigatorSaveItem});
            this.фильмBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.фильмBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.фильмBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.фильмBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.фильмBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.фильмBindingNavigator.Name = "фильмBindingNavigator";
            this.фильмBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.фильмBindingNavigator.Size = new System.Drawing.Size(871, 27);
            this.фильмBindingNavigator.TabIndex = 0;
            this.фильмBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // фильмBindingSource
            // 
            this.фильмBindingSource.DataMember = "Фильм";
            this.фильмBindingSource.DataSource = this.справочная_служба_кинотеатровDataSet;
            // 
            // справочная_служба_кинотеатровDataSet
            // 
            this.справочная_служба_кинотеатровDataSet.DataSetName = "Справочная_служба_кинотеатровDataSet";
            this.справочная_служба_кинотеатровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // фильмBindingNavigatorSaveItem
            // 
            this.фильмBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.фильмBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("фильмBindingNavigatorSaveItem.Image")));
            this.фильмBindingNavigatorSaveItem.Name = "фильмBindingNavigatorSaveItem";
            this.фильмBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.фильмBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.фильмBindingNavigatorSaveItem.Click += new System.EventHandler(this.фильмBindingNavigatorSaveItem_Click);
            // 
            // id_фильмаTextBox
            // 
            this.id_фильмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Id_фильма", true));
            this.id_фильмаTextBox.Location = new System.Drawing.Point(170, 38);
            this.id_фильмаTextBox.Name = "id_фильмаTextBox";
            this.id_фильмаTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_фильмаTextBox.TabIndex = 2;
            // 
            // id_кинотеатраTextBox
            // 
            this.id_кинотеатраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Id_кинотеатра", true));
            this.id_кинотеатраTextBox.Location = new System.Drawing.Point(170, 66);
            this.id_кинотеатраTextBox.Name = "id_кинотеатраTextBox";
            this.id_кинотеатраTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_кинотеатраTextBox.TabIndex = 4;
            // 
            // наградыCheckBox
            // 
            this.наградыCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.фильмBindingSource, "Награды", true));
            this.наградыCheckBox.Location = new System.Drawing.Point(462, 125);
            this.наградыCheckBox.Name = "наградыCheckBox";
            this.наградыCheckBox.Size = new System.Drawing.Size(25, 24);
            this.наградыCheckBox.TabIndex = 6;
            this.наградыCheckBox.UseVisualStyleBackColor = true;
            // 
            // операторTextBox
            // 
            this.операторTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Оператор", true));
            this.операторTextBox.Location = new System.Drawing.Point(170, 94);
            this.операторTextBox.Name = "операторTextBox";
            this.операторTextBox.Size = new System.Drawing.Size(200, 22);
            this.операторTextBox.TabIndex = 8;
            // 
            // режиссерTextBox
            // 
            this.режиссерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Режиссер", true));
            this.режиссерTextBox.Location = new System.Drawing.Point(170, 122);
            this.режиссерTextBox.Name = "режиссерTextBox";
            this.режиссерTextBox.Size = new System.Drawing.Size(200, 22);
            this.режиссерTextBox.TabIndex = 10;
            // 
            // актерыTextBox
            // 
            this.актерыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Актеры", true));
            this.актерыTextBox.Location = new System.Drawing.Point(558, 173);
            this.актерыTextBox.Multiline = true;
            this.актерыTextBox.Name = "актерыTextBox";
            this.актерыTextBox.Size = new System.Drawing.Size(242, 81);
            this.актерыTextBox.TabIndex = 12;
            // 
            // фотоPictureBox
            // 
            this.фотоPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.фильмBindingSource, "Кадр_из_фильма", true));
            this.фотоPictureBox.Location = new System.Drawing.Point(588, 12);
            this.фотоPictureBox.Name = "фотоPictureBox";
            this.фотоPictureBox.Size = new System.Drawing.Size(200, 137);
            this.фотоPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотоPictureBox.TabIndex = 14;
            this.фотоPictureBox.TabStop = false;
            // 
            // длительностьTextBox
            // 
            this.длительностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Длительность", true));
            this.длительностьTextBox.Location = new System.Drawing.Point(170, 150);
            this.длительностьTextBox.Name = "длительностьTextBox";
            this.длительностьTextBox.Size = new System.Drawing.Size(200, 22);
            this.длительностьTextBox.TabIndex = 16;
            // 
            // прокатная_стоимостьTextBox
            // 
            this.прокатная_стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Прокатная_стоимость", true));
            this.прокатная_стоимостьTextBox.Location = new System.Drawing.Point(170, 178);
            this.прокатная_стоимостьTextBox.Name = "прокатная_стоимостьTextBox";
            this.прокатная_стоимостьTextBox.Size = new System.Drawing.Size(200, 22);
            this.прокатная_стоимостьTextBox.TabIndex = 18;
            // 
            // странаTextBox
            // 
            this.странаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Страна", true));
            this.странаTextBox.Location = new System.Drawing.Point(170, 206);
            this.странаTextBox.Name = "странаTextBox";
            this.странаTextBox.Size = new System.Drawing.Size(200, 22);
            this.странаTextBox.TabIndex = 20;
            // 
            // год_производстваDateTimePicker
            // 
            this.год_производстваDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.фильмBindingSource, "Год_производства", true));
            this.год_производстваDateTimePicker.Location = new System.Drawing.Point(170, 234);
            this.год_производстваDateTimePicker.Name = "год_производстваDateTimePicker";
            this.год_производстваDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.год_производстваDateTimePicker.TabIndex = 22;
            // 
            // жанрTextBox
            // 
            this.жанрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Жанр", true));
            this.жанрTextBox.Location = new System.Drawing.Point(170, 262);
            this.жанрTextBox.Name = "жанрTextBox";
            this.жанрTextBox.Size = new System.Drawing.Size(200, 22);
            this.жанрTextBox.TabIndex = 24;
            // 
            // название_фильмаTextBox
            // 
            this.название_фильмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Название_фильма", true));
            this.название_фильмаTextBox.Location = new System.Drawing.Point(170, 290);
            this.название_фильмаTextBox.Name = "название_фильмаTextBox";
            this.название_фильмаTextBox.Size = new System.Drawing.Size(200, 22);
            this.название_фильмаTextBox.TabIndex = 26;
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(470, 62);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(112, 23);
            this.buttonOpenPhoto.TabIndex = 27;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // buttonKino
            // 
            this.buttonKino.Location = new System.Drawing.Point(412, 306);
            this.buttonKino.Name = "buttonKino";
            this.buttonKino.Size = new System.Drawing.Size(94, 23);
            this.buttonKino.TabIndex = 28;
            this.buttonKino.Text = "Кинотеатр";
            this.buttonKino.UseVisualStyleBackColor = true;
            this.buttonKino.Click += new System.EventHandler(this.buttonKino_Click);
            // 
            // id_названияTextBox
            // 
            this.id_названияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмBindingSource, "Id_названия", true));
            this.id_названияTextBox.Location = new System.Drawing.Point(650, 306);
            this.id_названияTextBox.Name = "id_названияTextBox";
            this.id_названияTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_названияTextBox.TabIndex = 32;
            // 
            // фильмTableAdapter
            // 
            this.фильмTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BD.Справочная_служба_кинотеатровDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.КинотеатрTableAdapter = null;
            this.tableAdapterManager.СеансTableAdapter = null;
            this.tableAdapterManager.ФильмTableAdapter = this.фильмTableAdapter;
            // 
            // кинотеатрBindingSource
            // 
            this.кинотеатрBindingSource.DataMember = "Кинотеатр";
            this.кинотеатрBindingSource.DataSource = this.справочная_служба_кинотеатровDataSet;
            // 
            // кинотеатрTableAdapter
            // 
            this.кинотеатрTableAdapter.ClearBeforeFill = true;
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 555);
            this.Controls.Add(id_названияLabel);
            this.Controls.Add(this.id_названияTextBox);
            this.Controls.Add(this.buttonKino);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(id_фильмаLabel);
            this.Controls.Add(this.id_фильмаTextBox);
            this.Controls.Add(id_кинотеатраLabel);
            this.Controls.Add(this.id_кинотеатраTextBox);
            this.Controls.Add(наградыLabel);
            this.Controls.Add(this.наградыCheckBox);
            this.Controls.Add(операторLabel);
            this.Controls.Add(this.операторTextBox);
            this.Controls.Add(режиссерLabel);
            this.Controls.Add(this.режиссерTextBox);
            this.Controls.Add(актерыLabel);
            this.Controls.Add(this.актерыTextBox);
            this.Controls.Add(кадр_из_фильмаLabel);
            this.Controls.Add(this.фотоPictureBox);
            this.Controls.Add(длительностьLabel);
            this.Controls.Add(this.длительностьTextBox);
            this.Controls.Add(прокатная_стоимостьLabel);
            this.Controls.Add(this.прокатная_стоимостьTextBox);
            this.Controls.Add(странаLabel);
            this.Controls.Add(this.странаTextBox);
            this.Controls.Add(год_производстваLabel);
            this.Controls.Add(this.год_производстваDateTimePicker);
            this.Controls.Add(жанрLabel);
            this.Controls.Add(this.жанрTextBox);
            this.Controls.Add(название_фильмаLabel);
            this.Controls.Add(this.название_фильмаTextBox);
            this.Controls.Add(this.фильмBindingNavigator);
            this.Name = "FormFilm";
            this.Text = "Фильм";
            this.Load += new System.EventHandler(this.FormFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingNavigator)).EndInit();
            this.фильмBindingNavigator.ResumeLayout(false);
            this.фильмBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочная_служба_кинотеатровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Справочная_служба_кинотеатровDataSet справочная_служба_кинотеатровDataSet;
        private System.Windows.Forms.BindingSource фильмBindingSource;
        private Справочная_служба_кинотеатровDataSetTableAdapters.ФильмTableAdapter фильмTableAdapter;
        private Справочная_служба_кинотеатровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator фильмBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton фильмBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_фильмаTextBox;
        private System.Windows.Forms.TextBox id_кинотеатраTextBox;
        private System.Windows.Forms.CheckBox наградыCheckBox;
        private System.Windows.Forms.TextBox операторTextBox;
        private System.Windows.Forms.TextBox режиссерTextBox;
        private System.Windows.Forms.TextBox актерыTextBox;
        private System.Windows.Forms.PictureBox фотоPictureBox;
        private System.Windows.Forms.TextBox длительностьTextBox;
        private System.Windows.Forms.TextBox прокатная_стоимостьTextBox;
        private System.Windows.Forms.TextBox странаTextBox;
        private System.Windows.Forms.DateTimePicker год_производстваDateTimePicker;
        private System.Windows.Forms.TextBox жанрTextBox;
        private System.Windows.Forms.TextBox название_фильмаTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.Button buttonKino;
        private System.Windows.Forms.BindingSource кинотеатрBindingSource;
        private Справочная_служба_кинотеатровDataSetTableAdapters.КинотеатрTableAdapter кинотеатрTableAdapter;
        private System.Windows.Forms.TextBox id_названияTextBox;
    }
}