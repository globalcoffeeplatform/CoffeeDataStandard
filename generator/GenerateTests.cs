using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace Json2Rst
{
    [TestClass]
    public class GenerateTests
    {
        [TestMethod]
        public void ParseGlobalCoffeeDataStandardSchema()
        {
            var jsonObject =
                JObject.Parse(File.ReadAllText(
                    @"D:\dev\GlobalCoffeeDataStandard\git\schema\global-coffee-data-standard.schema.json"));
            Assert.IsNotNull(jsonObject, "No JSON parsed");

            WriteDynamicProperties(jsonObject);

            WriteHeading("Metadata", 2);

            var rootProperties = JObject.Parse(jsonObject.Property("properties").Value.ToString());
            // Debug.WriteLine(rootProperties);
            var propertyList = new List<JProperty>();
            foreach (var property in rootProperties.Properties())
            {
                var objectProperties = JObject.Parse(property.Value.ToString());
                if (objectProperties.ContainsKey("type") && objectProperties.GetValue("type").ToString() == "object")
                {
                    propertyList.Add(property);
                    continue; // Save for later
                }

                WriteProperties(property.Name, objectProperties);
            }

            // Now parse next level:
            WriteNextLevel(propertyList, 1);
        }

        private static void WriteNextLevel(List<JProperty> propertyList, int numLoop)
        {
            foreach (var property in propertyList)
            {
                var objectProperties = JObject.Parse(property.Value.ToString());
                WriteHeading(property.Name, numLoop + 1);
                if (objectProperties.ContainsKey("description")) Debug.WriteLine(objectProperties.GetValue("description").ToString());

                if (objectProperties.ContainsKey("type") &&
                    objectProperties.GetValue("type").ToString() == "object")
                {
                    var subProperties = JObject.Parse(objectProperties.GetValue("properties").ToString());
                    foreach (var subProperty in subProperties)
                    {
                        var subObjectProperties = JObject.Parse(subProperty.Value.ToString());
                        if (subObjectProperties.ContainsKey("type") && subObjectProperties.GetValue("type").ToString() == "object")
                        {
                            WriteHeading(subProperty.Key, numLoop + 1);
                            WriteNextLevel(JObject.Parse(subObjectProperties.Property("properties").Value.ToString()).Properties().ToList(), ++numLoop);
                            continue; // Next property
                        }
                        WriteProperties(subProperty.Key, subObjectProperties);
                    }
                }

                // WriteProperties(property.Name, objectProperties);
            }
        }

        private static void WriteHeading(string text, int level)
        {
            text = $"{text} ({level})";
            switch (level)
            {
                case 1:
                    WriteHeading1(text);
                    break;
                case 2:
                    WriteHeading2(text);
                    break;
                case 3:
                    WriteHeading3(text);
                    break;
                case 4:
                    WriteHeading4(text);
                    break;
                case 5:
                    WriteHeading5(text);
                    break;
                default:
                    WriteHeading5(text);
                    break;
            }
        }

        private static void WriteProperties(string propertyName, JObject objectProperties, int headingLevel = 3)
        {
            WriteHeading(propertyName, headingLevel);

            if (objectProperties.ContainsKey("title")) Debug.WriteLine(objectProperties.GetValue("title") + "\n");
            if (objectProperties.ContainsKey("description")) Debug.WriteLine(objectProperties.GetValue("description").ToString());

            if (objectProperties.ContainsKey("$ref")) Debug.WriteLine("\n.. todo:: Show sample JSON of " + objectProperties.GetValue("$ref"));
        }

        private static void WriteDynamicProperties(dynamic jsonObject)
        {
            WriteHeading((string)jsonObject.title, 1);
            string description = jsonObject.description;
            Debug.WriteLine(description);
        }

        private static void WriteHeading1(string text)
        {
            Debug.WriteLine("");
            Debug.WriteLine(new string('=', text.Length));
            Debug.WriteLine(text);
            Debug.WriteLine(new string('=', text.Length));
        }

        private static void WriteHeading2(string text)
        {
            Debug.WriteLine("");
            Debug.WriteLine(new string('*', text.Length));
            Debug.WriteLine(text);
            Debug.WriteLine(new string('*', text.Length));
        }

        private static void WriteHeading3(string text)
        {
            Debug.WriteLine("");
            Debug.WriteLine(text);
            Debug.WriteLine(new string('^', text.Length));
        }

        private static void WriteHeading4(string text)
        {
            Debug.WriteLine("");
            Debug.WriteLine(text);
            Debug.WriteLine(new string('-', text.Length));
        }

        private static void WriteHeading5(string text)
        {
            WriteItalic(text);
        }

        private static void WriteBold(string text)
        {
            Debug.WriteLine($"\n**{text}**");
        }


        private static void WriteItalic(string text)
        {
            Debug.WriteLine($"\n*{text}*");
        }

    }


}
