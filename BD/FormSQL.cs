using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD
{
    public partial class FormSQL : Form
    {
        private static FormSQL f;
        public static FormSQL fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public FormSQL()
        {
            InitializeComponent();
        }
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных

             SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.
            Справочная_служба_кинотеатровConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
             DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonKino_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Кинотеатр"); 
        }

        private void radioButtonZal_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT Id_зала, Вместимость, 
        Категория_зала, Кинотеатр.Id_кинотеатра, Категория FROM  Зал, Кинотеатр
		WHERE Зал.Id_кинотеатра = Кинотеатр.Id_кинотеатра");
        }

        private void radioButtonSeans_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT Зал.Id_зала, Категория_зала,
        Вместимость, Сеанс.Id_сеанса, Дата, Время_сеанса, Количество_свободных_мест, Цена_билета
        FROM  Зал, Сеанс WHERE Зал.Id_зала = Сеанс.Id_зала");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFilm.Text))
            {
                MessageBox.Show("Обязательно укажите название фильма." +
                    "\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_свободны.Checked) 
            {
                sqlSelect = (@"SELECT F.Id_фильма, F.Название_фильма, 
                S.Время_сеанса,S.Цена_билета,S.Количество_свободных_мест
                FROM Фильм F, Сеанс S
                WHERE F.Id_фильма = S.Id_фильма AND F.Название_фильма = @last_name
                AND S.Количество_свободных_мест > 0 ");
            }

            if (radioButtonDet_заняты.Checked)
            {
                sqlSelect = (@"SELECT F.Id_фильма, F.Название_фильма, 
                S.Время_сеанса,S.Цена_билета,S.Количество_свободных_мест
                FROM Фильм F, Сеанс S
                WHERE F.Id_фильма = S.Id_фильма AND F.Название_фильма = @last_name 
                AND S.Количество_свободных_мест = 0 ");
            }
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Справочная_служба_кинотеатровConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxFilm.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void InsertKino()
        {
            if (String.IsNullOrEmpty(textBoxId_kino.Text) ||
            (String.IsNullOrEmpty(textBoxAdress_kino.Text) ||
            (String.IsNullOrEmpty(textBoxName_kino.Text) ||
            (String.IsNullOrEmpty(textBoxRaion_kino.Text) ||
            (String.IsNullOrEmpty(textBoxKategoria_kino.Text))))))
            {
                MessageBox.Show("Обязательно введите Id_кинотеатра, адрес, название, район и категорию ",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxId_kino.Text, out id))
            {
                MessageBox.Show("Некоректное значение Id_кинотеатра!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = @"INSERT INTO Кинотеатр (Id_кинотеатра, Адрес, Название, Район, Категория )
            VALUES ( @Id, @Adress, @Name, @Raion, @Kategoria)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Справочная_служба_кинотеатровConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@Id", id);
            //или другим способом, если необходимо явное указание типа данных
            command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = textBoxAdress_kino.Text;
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxName_kino.Text;
            command.Parameters.Add("@Raion", SqlDbType.NVarChar).Value = textBoxRaion_kino.Text;
            command.Parameters.Add("@Kategoria", SqlDbType.NVarChar).Value = textBoxKategoria_kino.Text;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectKino_Click (this, EventArgs.Empty);
        }

        void UpdateKino()
        {
            if (String.IsNullOrEmpty(textBoxId_kino.Text))
            {
                MessageBox.Show("Обязательно укажите Id_кинотеатра, для которого будете менять данные",
                "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxId_kino.Text, out id))
            {
                MessageBox.Show("Некоректное значение Id_кинотеатра!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE Кинотеатр SET  Адрес=@Adress, Название=@Name, Район=@Raion, " +
                "Категория=@Kategoria WHERE Id_кинотеатра = @Id";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Справочная_служба_кинотеатровConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();

            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxAdress_kino.Text))
                sqlValues += "Адрес=@Adress,";
            if (!String.IsNullOrEmpty(textBoxName_kino.Text))
                sqlValues += "Название=@Name,";
            if (!String.IsNullOrEmpty(textBoxRaion_kino.Text))
                sqlValues += "Район=@Raion,";
            if (!String.IsNullOrEmpty(textBoxKategoria_kino.Text))
                sqlValues += "Категория=@Kategoria,";

            command.CommandText = String.Format(sqlUpdate, sqlValues);
            //или другим способом, если необходимо явное указание типа данных

            if (!String.IsNullOrEmpty(textBoxAdress_kino.Text))
                command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = textBoxAdress_kino.Text;

            if (!String.IsNullOrEmpty(textBoxName_kino.Text))
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxName_kino.Text;

            if (!String.IsNullOrEmpty(textBoxRaion_kino.Text))
                command.Parameters.Add("@Raion", SqlDbType.NVarChar).Value = textBoxRaion_kino.Text;

            if (!String.IsNullOrEmpty(textBoxKategoria_kino.Text))
                command.Parameters.Add("@Kategoria", SqlDbType.NVarChar).Value = textBoxKategoria_kino.Text;

            command.Parameters.AddWithValue("@Id", id);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectKino_Click(this, EventArgs.Empty);
        }

        void DeleteKino()
        {
            if (String.IsNullOrEmpty(textBoxId_kino.Text))
            {
                MessageBox.Show("Обязательно укажите Id_кинотеатра данные которого необходимо удалить", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxId_kino.Text, out id))
            {
                MessageBox.Show("Некоректное значение Id_кинотеатра!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Кинотеатр WHERE Id_кинотеатра=@Id";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Справочная_служба_кинотеатровConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectKino_Click(this, EventArgs.Empty);
        }

        private void buttonSelectKino_Click(object sender, EventArgs e)
        {
            dataGridViewKino.DataSource = FillDataGridView("SELECT * FROM Кинотеатр");
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_kino.Checked)
                InsertKino();
                else
            if (radioButtonUpdate_kino.Checked)
             UpdateKino();
                else
         if (radioButtonDelete_kino.Checked)
             DeleteKino();
                else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
