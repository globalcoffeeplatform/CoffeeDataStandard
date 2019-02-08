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
        private TitleNumber _titleNumber;

        public GenerateTests()
        {
            _titleNumber = new TitleNumber();
        }

        [TestMethod]
        public void ParseGlobalCoffeeDataStandardSchema()
        {
            var jsonObject =
                JObject.Parse(File.ReadAllText(
                    @"D:\dev\GlobalCoffeeDataStandard\git\schema\global-coffee-data-standard.schema.json"));
            Assert.IsNotNull(jsonObject, "No JSON parsed");

            WriteDynamicProperties(jsonObject);

            _titleNumber.Level1 = 1;
            WriteHeading("Metadata", 2);

            _titleNumber.Level2 = 1;
            var rootProperties = JObject.Parse(jsonObject.Property("properties").Value.ToString());
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
                _titleNumber.Level2++;
            }

            // Now parse next level:
            WriteNextLevel(propertyList, 2);
        }

        private void WriteNextLevel(IEnumerable<JProperty> propertyList, int headerLevel)
        {
            foreach (var property in propertyList)
            {
                SetTitleNumbers(headerLevel);

                var objectProperties = JObject.Parse(property.Value.ToString());
                WriteProperties(property.Name, objectProperties, headerLevel);

                if (objectProperties.ContainsKey("type") &&
                    objectProperties.GetValue("type").ToString() == "object")
                {
                    var subProperties = JObject.Parse(objectProperties.GetValue("properties").ToString());
                    foreach (var subProperty in subProperties)
                    {
                        var subObjectProperties = JObject.Parse(subProperty.Value.ToString());
                        if (subObjectProperties.ContainsKey("type") && subObjectProperties.GetValue("type").ToString() == "object")
                        {
                            SetTitleNumbers(headerLevel + 1);
                            WriteHeading(subProperty.Key, headerLevel + 1);
                            WriteNextLevel(JObject.Parse(subObjectProperties.Property("properties").Value.ToString()).Properties().ToList(), headerLevel + 2);
                            SetTitleNumbers(headerLevel + 2);
                            continue;
                        }
                        SetTitleNumbers(headerLevel + 1);
                        WriteProperties(subProperty.Key, subObjectProperties, headerLevel + 1);
                    }
                }

                // WriteProperties(property.Name, objectProperties);
            }
        }

        private void SetTitleNumbers(int headerLevel)
        {
            switch (headerLevel)
            {
                case 2:
                    _titleNumber.Level1++;
                    _titleNumber.Level2 = 0;
                    break;
                case 3:
                    _titleNumber.Level2++;
                    _titleNumber.Level3 = 0;
                    break;
                case 4:
                    _titleNumber.Level3++;
                    _titleNumber.Level4 = 0;
                    break;
                case 5:
                    _titleNumber.Level4++;
                    _titleNumber.Level5 = 0;
                    break;
            }
        }

        private void WriteHeading(string text, int level)
        {
            // text = $"{_titleNumber} {text} ({level})";
            text = $"{_titleNumber} {text}";
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

        private void WriteProperties(string propertyName, JObject objectProperties, int headingLevel = 3)
        {
            WriteHeading(propertyName, headingLevel);

            if (objectProperties.ContainsKey("title")) Debug.WriteLine(objectProperties.GetValue("title") + "\n");
            if (objectProperties.ContainsKey("description")) Debug.WriteLine(objectProperties.GetValue("description").ToString());

            if (objectProperties.ContainsKey("$ref")) Debug.WriteLine("\n.. todo:: Show sample JSON of " + objectProperties.GetValue("$ref"));
        }

        private void WriteDynamicProperties(dynamic jsonObject)
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
            Debug.WriteLine("");
            Debug.WriteLine(text);
            Debug.WriteLine(new string('*', text.Length));
        }

        private static void WriteBold(string text)
        {
            Debug.WriteLine($"\n**{text}**");
        }


        private static void WriteItalic(string text)
        {
            Debug.WriteLine($"\n*{text}*");
        }

        private struct TitleNumber
        {
            public int Level1 { get; set; }
            public int Level2 { get; set; }
            public int Level3 { get; set; }
            public int Level4 { get; set; }
            public int Level5 { get; set; }

            public override string ToString()
            {
                var text = string.Empty;
                
                if (Level1 <= 0) return text;
                
                text = Level1.ToString();
                if (Level2 <= 0) return text;
                
                text = $"{Level1}.{Level2}";
                if (Level3 <= 0) return text;
                
                text = $"{Level1}.{Level2}.{Level3}";
                if (Level4 <= 0) return text;
                
                text = $"{Level1}.{Level2}.{Level3}.{Level4}";
                if (Level5 > 0) text = $"{Level1}.{Level2}.{Level3}.{Level4}.{Level5}";
                return text;
            }
        }

    }


}
