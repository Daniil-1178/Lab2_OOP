using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class StringItem
    {
        public int Length;
        public string Value;

        public StringItem(string text)
        {
            Value = text;
            Length = text.Length;
        }
    }

    public class StringArray
    {
        private List<StringItem> itemsList = new List<StringItem>();

        public void Add(string text)
        {
            itemsList.Add(new StringItem(text));
        }

        public int Count => itemsList.Count;

        public string GetAt(int index)
        {
            if (index >= 0 && index < itemsList.Count)
            {
                return itemsList[index].Value;
            }
            return "Помилка: Індекс поза межами";
        }

        public StringArray Concat(StringArray other)
        {
            StringArray result = new StringArray();
            int minLen = Math.Min(this.Count, other.Count);

            for (int i = 0; i < minLen; i++)
            {
                result.Add(this.GetAt(i) + other.GetAt(i));
            }
            return result;
        }

        public StringArray MergeUnique(StringArray other)
        {
            StringArray result = new StringArray();

            for (int i = 0; i < this.Count; i++)
            {
                result.Add(this.GetAt(i));
            }

            for (int i = 0; i < other.Count; i++)
            {
                string newValue = other.GetAt(i);
                bool isDuplicate = false;

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