using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public class DataTools
    {
        /// <summary>
        /// Делегат сравнения товаров по критерию.
        /// </summary>
        /// <param name="first">Товар 1.</param>
        /// <param name="second">Товар 2.</param>
        /// <returns>Менять ли товары местами.</returns>
        public delegate bool CompareCriteria(Item first, Item second);

        /// <summary>
        /// Фильтрация товаров по критерию.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="criteria">Критерий.</param>
        /// <returns>Фильтрованный список товаров.</returns>
        public static List<Item> FilterItems(List<Item> items, Predicate<Item> criteria)
        {
            var filteredItems = new List<Item>();

            foreach (var item in items)
            {
                if (criteria(item))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        /// <summary>
        /// Сортировка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="compare">Делегат сравнения.</param>
        /// <returns>Отсортированный список товаров.</returns>
        public static List<Item> SortItems(List<Item> items,
        CompareCriteria compare)
        {
            var sortedItems = new List<Item>(items);

            for (int i = 0; i < sortedItems.Count; i++)
            {
                for (int j = 1; j < sortedItems.Count; j++)
                {
                    if (compare(sortedItems[j], sortedItems[j - 1]))
                    {
                        var temp = sortedItems[j];
                        sortedItems[j] = sortedItems[j - 1];
                        sortedItems[j - 1] = temp;
                    }
                }
            }

            return sortedItems;
        }
    }
}
