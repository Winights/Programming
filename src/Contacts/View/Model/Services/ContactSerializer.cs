using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Реализирует сохранение и загрузку данных из файла.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу по умолчанию.
        /// </summary>
        private static string _filePath = Path.Combine(Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments),"Contacts", "contacts.json");

        /// <summary>
        /// Возвращает путь к файлу.
        /// </summary>
        public static string FilePath { get { return _filePath; } }

        /// <summary>
        /// Сохраняет объект контакта в файл.
        /// </summary>
        /// <param name="contact">Объект контакта.</param>
        public static void SaveContact(Contact contact)
        {
            var directory = Path.GetDirectoryName(FilePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonConvert.SerializeObject(contact);
            File.WriteAllText(FilePath, json);
        }

        /// <summary>
        /// Загружает из файла объект контакта.
        /// </summary>
        /// <returns> Возвращает объект контакта.</returns>
        public static Contact LoadContact()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                Contact contact = JsonConvert.DeserializeObject<Contact>(json);
                return contact;
            }
            else
            {
                throw new Exception("File not find");
            }
        }
    }
}
