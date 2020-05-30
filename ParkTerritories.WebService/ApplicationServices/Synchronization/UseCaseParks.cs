using System;
using System.Collections.Generic;
using System.Net;
using ParkTerritories.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using ParkTerritories.InfrastructureServices.Gateways.Database;

namespace ParkTerritories.ApplicationServices.Synchronization
{
    public class Park_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public Park_inf Cells { get; set; }   
    }

    public class Park_inf
    {
        public long global_id { get; set; }
        public string CommonName { get; set; }
        public string Location { get; set; }
        public string HasWater { get; set; } 
        public string HasPlayground { get; set; }
        public string HasSportground { get; set; }
    }

    public class UseCaseParks
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/1465/rows?api_key=80a756e69ebdbb37f01f159f6325baac&$top=1000";

        string path = @".\update_database\park-";
        
        List<Park_Cell> park_cells;

        public List<Park> parks = new List<Park>();

        public UseCaseParks()
        {
            //---Запрос---
            WebRequest request = WebRequest.Create(remoteUri);
            WebResponse response = request.GetResponse();

            //читаем ответ
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string line = stream.ReadToEnd();

            //вытащили весь массив данных из json
            JArray jsonArray = JArray.Parse(line);

            //заполним класс, который вытащит нам только нужные поля и выведем списком все парки
            park_cells = JsonConvert.DeserializeObject<List<Park_Cell>>(jsonArray.ToString());

            //дата последнего обновления данных 
            DateTime Date_update = DateTime.Now;
            string date_update = Date_update.ToShortDateString();

            path = path + date_update + @".json";
            // сохранение данных
            using (FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate))
            {
                //чтобы кодировка не слетала на кириллице
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                //обозначим начало массива данных
                string text = "[";
                byte[] input = Encoding.Default.GetBytes(text);
                // запись в файл
                fs2.Write(input, 0, input.Length);
                text = ",";

                for (int i = 0; i < park_cells.Count; i++)
                {
                    parks.Add(new Park()
                    {
                        Name = park_cells[i].Cells.CommonName,
                        Id = park_cells[i].Number,
                        Location = park_cells[i].Cells.Location,
                        PlayGround = park_cells[i].Cells.HasPlayground,
                        SportsGround = park_cells[i].Cells.HasSportground,
                        Water = park_cells[i].Cells.HasWater
                    });

                    System.Text.Json.JsonSerializer.SerializeAsync<Park>(fs2, parks[i], options).GetAwaiter().GetResult();

                    if (i != park_cells.Count - 1)
                    {
                        input = Encoding.Default.GetBytes(text);
                        fs2.Write(input, 0, input.Length);
                    }
                }

                text = "]";
                input = Encoding.Default.GetBytes(text);
                fs2.Write(input, 0, input.Length);
            }   
        }
    }
}

