using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace EduCal
{
    public static class FileHelper
    {
        public static void SaveToJsonFile<T>(string fileName, T data)
        {
            string jsonString = JsonSerializer.Serialize(data);
            File.WriteAllText(fileName, jsonString);
        }

        public static T LoadFromJsonFile<T>(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        public static void SaveToXmlFile<T>(string fileName, T data)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static T LoadFromXmlFile<T>(string fileName)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var reader = new StreamReader(fileName))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Example of saving settings to JSON file
        EventSettings eventSettings = new EventSettings
        {
            // ... (your settings)
        };

        FileHelper.SaveToJsonFile("app_settings.json", eventSettings);

        // Example of loading settings from JSON file
        EventSettings loadedJsonSettings = FileHelper.LoadFromJsonFile<EventSettings>("app_settings.json");

        // Example of saving settings to XML file
        FileHelper.SaveToXmlFile("app_settings.xml", eventSettings);

        // Example of loading settings from XML file
        EventSettings loadedXmlSettings = FileHelper.LoadFromXmlFile<EventSettings>("app_settings.xml");
    }
}


