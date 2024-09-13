using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует статистическую генерацию следующего номера для обьекта.
    /// </summary>
    internal class IdGenerator
    {
        /// <summary>
        /// Счетчик для всех существующих объектов.
        /// </summary>
        private static int _nextId;

        /// <summary>
        /// Генерирует следующий номер обьекта.
        /// </summary>
        /// <returns>Возвращает следующий номер для обьекта.</returns>
        public static int GetNextId()
        {
            return _nextId++;
        }
    }
}
