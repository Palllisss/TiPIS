using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD.Properties;

namespace BD
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
            "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,ФВС,Якаева Полина Андреевна,группа 520,2023", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void Информация_О_ФильмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFilm.fd.ShowForm();
        }

        private void Информация_О_КинотеатреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKino.fw.ShowForm();
        }

        private void Информация_О_СеансеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSeans.fw.ShowForm();
        }

        private void Информация_О_ЗалеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZal.fw.ShowForm();
        }

        private void ЗапросыToolStripButton_Click(object sender, EventArgs e)
        {
            FormSQL.fw.ShowForm();
        }
    }
}
