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
    public partial class FormSeans : Form
    {
        private static FormSeans f;
        public static FormSeans fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSeans();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormSeans()
        {
            InitializeComponent();
        }

        private void сеансBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.сеансBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.справочная_служба_кинотеатровDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormSeans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "справочная_служба_кинотеатровDataSet.Фильм". При необходимости она может быть перемещена или удалена.
            this.фильмTableAdapter.Fill(this.справочная_служба_кинотеатровDataSet.Фильм);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "справочная_служба_кинотеатровDataSet.Зал". При необходимости она может быть перемещена или удалена.
            this.залTableAdapter.Fill(this.справочная_служба_кинотеатровDataSet.Зал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "справочная_служба_кинотеатровDataSet.Сеанс". При необходимости она может быть перемещена или удалена.
            this.сеансTableAdapter.Fill(this.справочная_служба_кинотеатровDataSet.Сеанс);
        }
        string GetSelectedFieldName()
        {
            return
           сеансDataGridView.Columns[сеансDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               сеансBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                сеансBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сеансов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                сеансBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        сеансBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                сеансBindingSource.Filter = "";
            if (сеансBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                сеансBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}
