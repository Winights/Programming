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
        /// Номер семестра.
        /// </summary>
        private int _semester;

        /// <summary>
        /// Возвращает и задает имя профессора.
        /// </summary>
        public string Professor { get; set; }

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает номер семестра. Должен быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="semester">Номер семестра.</param>
        /// <param name="professor">Имя профессора.</param>
        public Discipline(string name, int semester, string professor)
        {
            Name = name;
            Semester = semester;
            Professor = professor;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline()
        {
            Name = "";
            Semester = 0;
            Professor = "";
        }
    }
}
