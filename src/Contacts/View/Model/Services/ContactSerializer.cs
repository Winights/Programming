using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Реализирует сохранение и загрузку данных из файла.
    /// </summary>
    public static class ContactSerializer
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
        /// Сохраняет список контактов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public static void SaveContacts(ObservableCollection<Contact> contacts)
        {
            var directory = Path.GetDirectoryName(FilePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonConvert.SerializeObject(contacts);
            File.WriteAllText(FilePath, json);
        }

        /// <summary>
        /// Загружает из файла список объектов контакта.
        /// </summary>
        /// <returns> Возвращает список объектов контакта, иначе пустой список.</returns>
        public static ObservableCollection<Contact> LoadContacts()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json)
                    ?? new ObservableCollection<Contact>();
            }
            else
            {
                return new ObservableCollection<Contact>();
            }
        }
    }
}
