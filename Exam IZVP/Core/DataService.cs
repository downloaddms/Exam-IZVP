using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Exam_IZVP.Core
{
    public class DataService<T> where T : class
    {
        protected List<T> items = new List<T>();

        public List<T> GetAll() => items;
        public void Add(T item) => items.Add(item);
        public bool Remove(T item) => items.Remove(item);
        public int Count => items.Count;

        public List<T> Find(Func<T, bool> condition) =>
            items.Where(condition).ToList();

        public void SaveToJson(string filePath)
        {
            // ВАРІАНТ 1: Повне ім'я
            string json = JsonConvert.SerializeObject(items, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromJson(string filePath)
        {
            if (!File.Exists(filePath)) return;
            string json = File.ReadAllText(filePath);
            items = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }
    }
}
