using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class FormFilm : Form
    {
        private static FormFilm f;
        public static FormFilm fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormFilm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormFilm()
        {
            InitializeComponent();
        }

        private void фильмBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.фильмBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.справочная_служба_кинотеатровDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormFilm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "справочная_служба_кинотеатровDataSet.Кинотеатр". При необходимости она может быть перемещена или удалена.
            this.кинотеатрTableAdapter.Fill(this.справочная_служба_кинотеатровDataSet.Кинотеатр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "справочная_служба_кинотеатровDataSet.Фильм". При необходимости она может быть перемещена или удалена.
            this.фильмTableAdapter.Fill(this.справочная_служба_кинотеатровDataSet.Фильм);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    фотоPictureBox.Image = new
                   Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        private void buttonKino_Click(object sender, EventArgs e)
        {
            int id = -1;
            if
           (((DataRowView)фильмBindingSource.Current)["id_кинотеатра"].ToString() !="")
            {
                id =
               (int)(((DataRowView)фильмBindingSource.Current)["id_кинотеатра"]);
            }
            id = FormKino.fw.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)фильмBindingSource.Current)["id_кинотеатра"] = id;
                фильмBindingSource.EndEdit();
            }
        }
    }
}
