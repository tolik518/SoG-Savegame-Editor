using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoG_SGreader.Enum
{
    public class DynamicEnum
    {
        private readonly string filePath;
        private Dictionary<string, int> nameToValue = new Dictionary<string, int>();
        private Dictionary<int, string> valueToName = new Dictionary<int, string>();

        public DynamicEnum(string filePath, string key)
        {
            var jsonData = File.ReadAllText(filePath);
            var items = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, int>>>(jsonData);
            if (items != null && items.ContainsKey(key))
            {
                foreach (var item in items[key])
                {
                    nameToValue[RemoveLeadingUnderscore(item.Key)] = item.Value;
                    valueToName[item.Value] = RemoveLeadingUnderscore(item.Key);
                }
            }
            else
            {
                throw new KeyNotFoundException($"The key '{key}' is not found in the JSON data.");
            }
        }

        public int GetValue(string name)
        {
            if (nameToValue.ContainsKey(name))
            {
                return nameToValue[name];
            }
            throw new KeyNotFoundException($"The name '{name}' is not found in the {filePath} enum.");
        }

        public string GetName(int value)
        {
            if (valueToName.ContainsKey(value))
            {
                return valueToName[value];
            }
            throw new KeyNotFoundException($"The value '{value}' is not found in the {filePath} enum.");
        }

        public IEnumerable<string> GetNames()
        {
            return nameToValue.Keys;
        }

        private static string RemoveLeadingUnderscore(string input)
        {
            return input.StartsWith("_") ? input.Substring(1) : input;
        }
    }
}
