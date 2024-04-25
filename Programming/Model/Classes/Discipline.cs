using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплинах в зачетной книжке.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Номер семестра для всех объектов данного класса.
        /// </summary>
        private int _semester;

        /// <summary>
        /// Имя профессора для всех объектов данного класса.
        /// </summary>
        public string Professor { get; set; }

        /// <summary>
        /// Название дисциплины для всех объектов данного класса.
        /// </summary>
        public string Name { get; set; }
        public int Semester 
        {
            get
            {
                return _semester;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Semester");
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
