
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace ProxyIndexConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.SetWindowSize(140, 30);
                Console.SetBufferSize(140, 30);
                Lines();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured:" + ex.Message);
            }
        }

        public static void Lines()
        {
            Console.WriteLine("Enter the path of the proxy.");
            string path = Console.ReadLine();
            if (string.IsNullOrEmpty(path))
            {
                path = @"C:\Users\anbajori\Documents\Visual Studio 2013\Projects\ProxyIndexConvertor\ProxyIndexConvertor\UnModified Proxies\ConsultadatosLinea.cs";
            }
            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i].Contains("Order = "))
                {
                    string newLine;
                    string orderLine = lines[i];
                    string variableLine = lines[i + 1];

                    Console.WriteLine(orderLine);
                    Console.WriteLine(variableLine);

                    if (!variableLine.ToUpper().Contains("PUBLIC")|| variableLine.EndsWith(";")) continue;
                    string valueToReplace = variableLine.Trim().Split(' ')[2];
                    Console.WriteLine(valueToReplace);

                    List<string> strings = orderLine.Trim().Split(',').ToList();
                    if (strings.Count == 1 && strings[0].ToUpper().Contains("ORDER"))
                    {
                        newLine = string.Format("[System.Xml.Serialization.XmlElementAttribute(\"{0}\")]",
                            valueToReplace);
                    }

                    else
                    {
                        const string elementName = "ElementName = ";
                        valueToReplace = string.Format("{0}\"{1}\")]", elementName, valueToReplace);
                        strings[strings.Count() - 1] = valueToReplace;
                        StringBuilder sb = new StringBuilder();
                        foreach (string st in strings)
                        {
                            if (strings.IndexOf(st) != 0)
                                sb.Append(",");
                            sb.Append(st);
                        }
                        newLine = sb.ToString();
                    }

                    lines[i] = newLine;
                    Console.WriteLine(newLine);
                }
            }
            string newPath = Path.GetDirectoryName(path) + '\\' + Path.GetFileNameWithoutExtension(path) + "Modified" + Path.GetRandomFileName() + Path.GetExtension(path);
            File.WriteAllLines(newPath, lines);
            Console.WriteLine("\n\nA new file has been generated:" + Path.GetFileNameWithoutExtension(path) + "Modified" + Path.GetRandomFileName() + Path.GetExtension(path));
            Console.WriteLine("\nLocation of new file path:" + Path.GetDirectoryName(path));
            Console.WriteLine("\n\nPlease any key to Exit.");
            Console.ReadLine();
        }
    }
}
