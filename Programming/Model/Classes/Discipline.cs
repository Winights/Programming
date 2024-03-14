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
        private int _semester;
        public string Professor { get; set; }
        public string Name { get; set; }
        public int Semester 
        {
            get
            {
                return _semester;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ашибка");
                }
                _semester = value;
            }
        }
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
