using EjemploDClases.Controller;
using EjemploDClases.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDClases.View
{
    public partial class frmPersonDetail : Form
    {
        PersonController _objPerson = new PersonController();

        private bool _isNew = true;
        public int _pId;

        public frmPersonDetail()
        {
            _isNew = true;
            InitializeComponent();
        }

        public frmPersonDetail(int pId)
        {
            _isNew = false;
            _pId = pId;
            InitializeComponent();
        }

        private void frmPersonDetail_Load(object sender, EventArgs e)
        {
            if (_isNew)
            {
                personBindingSource1.AddNew();
            }
            else
            {
                personBindingSource.DataSource = _objPerson.serachById(Convert.ToInt32(_pId));
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void saveData()
        {
            //if (loadData())
            //{
            //var reg = loadData();

                if (_isNew)
                {
                    var reg = (Person)personBindingSource1.Current;
                    _objPerson.insertEF(reg);
                }
                else
                {
                    _objPerson.update(_pId);
                }
                
            Close();
            //}
        }

        //private Person loadData()
        //{
            //try
            //{
                //_objPerson.FirstName = firstNameTextBox.Text;
                //_objPerson.LastName = lastNameTextBox.Text;
                //_objPerson.Email = emailTextBox.Text;
                //_objPerson.Adress = adressTextBox.Text;
                //_objPerson.Phone = Convert.ToInt32(phoneTextBox.Text);
                //_objPerson.Date = dateDateTimePicker.Value.Date;

                //var reg = (Person)personBindingSource.Current;
                //reg.Date = dateDateTimePicker.Value.Date;
                //return reg;
            //}
            //catch (Exception ex)
            //{
            //    if (ex.Message.Contains("La cadena de entrada no tiene el formato correcto"))
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //    else
            //    {
            //        MessageBox.Show("Verifique datos de entrada");
            //    }
            //    return false;
            //}


        //}
    }
}
