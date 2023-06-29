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
    public partial class FormKino : Form
    {
        private static FormKino f;
        public static FormKino fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormKino();
                return f;
            }
        }
        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            кинотеатрBindingSource.Position = 0;
            Show();
            Activate();
        }

        public FormKino()
        {
            InitializeComponent();
        }

        private void кинотеатрBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.кинотеатрBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.справочная_служба_кинотеатровDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormKino_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "справочная_служба_кинотеатровDataSet.Кинотеатр". При необходимости она может быть перемещена или удалена.
            this.кинотеатрTableAdapter.Fill(this.справочная_служба_кинотеатровDataSet.Кинотеатр);

        }
        string GetSelectedFieldName()
        {
            return
           кинотеатрDataGridView.Columns[кинотеатрDataGridView.CurrentCell.ColumnIndex
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
               кинотеатрBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                кинотеатрBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                кинотеатрBindingSource.Position = 0;
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
                        кинотеатрBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                кинотеатрBindingSource.Filter = "";
            if (кинотеатрBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                кинотеатрBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        //переменная для текущего(выбранного) кода сотрудника
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)кинотеатрBindingSource.Current)["id_кинотеатра"];
            else
                return -1;
        }

        private void FormKino_Shown(object sender, EventArgs e)
        {
            кинотеатрBindingSource.Position =
            кинотеатрBindingSource.Find("id_кинотеатра", idCurrent);
        }
    }
}
