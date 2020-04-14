using EjemploDClases.Controller;
using EjemploDClases.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDClases
{
    public partial class Form1 : Form
    {
        PersonController _objPerson = new PersonController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personBindingSource.DataSource = _objPerson.listPerson(txtSearch.Text);

            //listData(txtSearch.Text);
        }

        private void listData(string pSearch)
        {
            personBindingSource.DataSource = _objPerson.read(pSearch);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPersonDetail frmPerson = new frmPersonDetail();
            frmPerson.ShowDialog();
            personBindingSource.DataSource = _objPerson.listPerson(txtSearch.Text);
            _objPerson = new PersonController();

            //listData(txtSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (personBindingSource.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    deleteData(Convert.ToInt32(idLabel1.Text));
                    listData(txtSearch.Text);
                    _objPerson = new PersonController();
                }
            }
        }

        private void deleteData(int pId)
        {
            _objPerson.delete(pId);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //listData(txtSearch.Text);
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                personBindingSource.DataSource = _objPerson.listPerson(txtSearch.Text);

                //listData(txtSearch.Text);
            }
        }

        private void personDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPersonDetail frmPerson = new frmPersonDetail(Convert.ToInt32(idLabel1.Text));
            frmPerson.ShowDialog();
            listData(txtSearch.Text);
        }
    }
}