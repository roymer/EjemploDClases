using EjemploDClases.Data;
using EjemploDClases.Data.dsClassesTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDClases.Controller
{
    class PersonController
    {
        dsClasses _ds = new dsClasses();
        PersonTableAdapter _ta = new PersonTableAdapter();

        dbClassesEntities _db = new dbClassesEntities();

        #region Atributos
        private string firstName;
        private string lastName;
        private string email;
        private string adress;
        private int phone;
        private DateTime date;
        #endregion

        #region Properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Adress { get => adress; set => adress = value; }
        public int Phone { get => phone; set => phone = value; }
        public DateTime Date { get => date; set => date = value; }
        #endregion

        #region Methods

        public bool insert()
        {
            _ta.Insert(FirstName, LastName, Email, Adress, Phone, Date);   
            return true;
        }

        public bool update(int pId)
        {
            _ta.UpdateQuery(FirstName, LastName, Email, Adress, Phone, Date, pId);
            return true;
        }
        public bool delete(int pId)
        {
            _ta.DeleteQuery(pId);
            return true;
        }

        public DataTable read(string pSearch)
        {
            return _ta.GetData(pSearch);
        }

        public DataTable serachById(int pId)
        {
            _ta.FillById(_ds.Person, pId);

            var fill = _ds.Person[0];
            firstName = fill.FirstName;
            lastName = fill.LastName;
            email = fill.Email;
            adress = fill.Adress;
            phone = fill.Phone;
            date = fill.Date;

            return _ds.Person;
        }

        #endregion

        #region Methods EF

        public List<Person> listPerson(string pSearch)
        {
            return _db.Person.Where(x => x.FirstName.Contains(pSearch) || x.LastName.Contains(pSearch)).ToList();
        }

        public bool insertEF(Person reg)
        {
            _db.Person.Add(reg);
            return _db.SaveChanges() > 0;
        }
    

        #endregion

    }
}
