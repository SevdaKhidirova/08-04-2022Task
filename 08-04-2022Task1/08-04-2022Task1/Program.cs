using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Xml.Serialization;

namespace _08_04_2022Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("pls enter time");
                string date = Console.ReadLine();

                HttpClient client = new HttpClient();
                string context = client.GetStringAsync("https://www.cbar.az/currencies/" + date + ".xml").Result;
                StringReader sr = new StringReader(context);
                // sr.Close();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));
                ValCurs val = (ValCurs)xmlSerializer.Deserialize(sr);
                File.Delete(@"C:\Users\daniz\Desktop\Task\08-04-2022Task1\08-04-2022Task1\Files\cbar.json");
                var myFile = File.Create(@"C:\Users\daniz\Desktop\Task\08-04-2022Task1\08-04-2022Task1\Files\cbar.json");
                myFile.Close();
                string valAsJson = JsonConvert.SerializeObject(val);
                StreamWriter jsonData = new StreamWriter(@"C:\Users\daniz\Desktop\Task\08-04-2022Task1\08-04-2022Task1\Files\cbar.json");
                jsonData.Write(valAsJson);
                jsonData.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}

/*Tapşırıq 1:
https://www.cbar.az/currencies/08.04.2022.xml linkindəki datanı götürüb json-a cevirən 
və .json faylı kimi save edən console app yazın. (Detalları vermirəm özünüz düşünün, alınmasa hint üçün müraciət edin.)
(Bonus: console app-da tarix daxil edilsin. Həmin tarixin məzənnələri götürülsün və json-a çevirilsin.)*/