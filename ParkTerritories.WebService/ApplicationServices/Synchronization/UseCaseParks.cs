using System;
using System.Collections.Generic;
using System.Net;
using ParkTerritories.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

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
            //Console.WriteLine(parks[0].Cells.CommonName);

            for (int i = 0; i < park_cells.Count; i++)
            {
                parks.Add(new Park() { 
                    Name = park_cells[i].Cells.CommonName, 
                    Id = park_cells[i].Cells.global_id, 
                    Location = park_cells[i].Cells.Location, 
                    PlayGround = park_cells[i].Cells.HasPlayground, 
                    SportsGround = park_cells[i].Cells.HasSportground,
                    Water = park_cells[i].Cells.HasWater 
                });
            }
        }      
        
    }
}

