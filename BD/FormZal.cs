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
    public partial class FormZal : Form
    {
        private static FormZal f;
        public static FormZal fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormZal();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        public FormZal()
        {
            InitializeComponent();
        }

        private void залBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.залBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.справочная_служба_кинотеатровDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormZal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "справочная_служба_кинотеатровDataSet.Кинотеатр". При необходимости она может быть перемещена или удалена.
            this.кинотеатрTableAdapter.Fill(this.справочная_служба_кинотеатровDataSet.Кинотеатр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "справочная_служба_кинотеатровDataSet.Зал". При необходимости она может быть перемещена или удалена.
            this.залTableAdapter.Fill(this.справочная_служба_кинотеатровDataSet.Зал);
        }
        string GetSelectedFieldName()
        {
            return
           залDataGridView.Columns[залDataGridView.CurrentCell.ColumnIndex
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
               залBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                залBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сеансов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                залBindingSource.Position = 0;
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
                        залBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                залBindingSource.Filter = "";
            if (залBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                залBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}
