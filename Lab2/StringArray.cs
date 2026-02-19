using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    // Клас для одного рядка (елемент масиву)
    public class StringItem
    {
        public int Length; // Довжина рядка
        public string Value; // Покажчик на текст (у C# це посилання на рядок)

        public StringItem(string text)
        {
            Value = text;
            Length = text.Length;
        }
    }

    // Головний клас для роботи з масивом рядків
    public class StringArray
    {
        // Внутрішній список для зберігання об'єктів StringItem
        private List<StringItem> itemsList = new List<StringItem>();

        // Метод додавання нового рядка
        public void Add(string text)
        {
            itemsList.Add(new StringItem(text));
        }

        // Властивість для отримання кількості елементів
        public int Count => itemsList.Count;

        // Звернення за індексом з контролем виходу за межі
        public string GetAt(int index)
        {
            if (index >= 0 && index < itemsList.Count)
            {
                return itemsList[index].Value;
            }
            return "Помилка: Індекс поза межами!";
        }

        // Поелементне зчеплення (конкатенація) двох масивів
        public StringArray Concat(StringArray other)
        {
            StringArray result = new StringArray();
            // Визначаємо спільну довжину за меншим масивом
            int minLen = Math.Min(this.Count, other.Count);

            for (int i = 0; i < minLen; i++)
            {
                // Склеюємо рядки з обох масивів під однаковими індексами
                result.Add(this.GetAt(i) + other.GetAt(i));
            }
            return result;
        }

        // Злиття двох масивів з виключенням повторів
        public StringArray MergeUnique(StringArray other)
        {
            StringArray result = new StringArray();

            // 1. Додаємо все з першого масиву
            for (int i = 0; i < this.Count; i++)
            {
                result.Add(this.GetAt(i));
            }

            // 2. Додаємо з другого, перевіряючи на унікальність
            for (int i = 0; i < other.Count; i++)
            {
                string newValue = other.GetAt(i);
                bool isDuplicate = false;

                // Перевіряємо, чи є такий рядок уже в результаті
                for (int j = 0; j < result.Count; j++)
                {
                    if (result.GetAt(j) == newValue)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    result.Add(newValue);
                }
            }
            return result;
        }
    }
}