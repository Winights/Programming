using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _name;
        private int _semester;
        private string _professor;

        public string Name { get { return _name; } set { _name = value; } }
        public int Semester { get { return _semester; } set { _semester = value; } }
        public string Professor { get { return _professor; } set { _professor = value; } }

        public Discipline(string name, int credits, int semester, string professor)
        {
            Name = name;
            Semester = semester;
            Professor = professor;
        }

        public Discipline()
        {
            Name = "";
            Semester = 0;
            Professor = "";
        }
    }
}
