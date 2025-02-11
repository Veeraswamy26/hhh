using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Program
{
    static string element = "about";
    public static void elementpath()
    {
        string filePath = "C:\\Users\\iray\\source\\repos\\pract5\\pract5\\data\\mybio.json";
        string jsonString = File.ReadAllText(filePath);
        var xpaths = JObject.Parse(jsonString);
        Console.WriteLine(xpaths);
        string xpath = xpaths[element].ToString();
        Console.WriteLine(xpath);
        return;
    }
        public static void Main()
        {

           elementpath();
            
           


            
            //
           

        }

        //D.driver.FindElement(By.XPath(xpath)).Click();
        // Use the XPath in your Appium automation (example)
        // driver.FindElement(By.XPath(xpath)).Click();
        //public static void xpathtrail()
        //{
        //  string elementName = "about";
        //    Main();
        //    string filePath = "C:\\Users\\iray\\source\\repos\\pract5\\pract5\\data\\mybio.json";
        //    string jsonString = File.ReadAllText(filePath);
        //    var xpaths = JObject.Parse(jsonString);
        //    Console.WriteLine(xpaths);
        //    string xpath = xpaths[elementName].ToString();
        //    Console.WriteLine(xpath);
        //}


    }

