﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using ServerLogic;

namespace ServerPresentation
{
    public static class Serializer
    {

        public static string AllDataToJson(IVinylServices vinylsService)
        {
            var vinyls = vinylsService.GetAllVinyls().Result;

            string stringToReturn = "Vinyls";

            stringToReturn += JsonSerializer.Serialize(vinyls);

            Console.WriteLine("Prepared data: " + stringToReturn);

            return stringToReturn;
        }

        public static int IntFromJson(string json)
        {
            return JsonSerializer.Deserialize<int>(json);
        }

        /*public static VinylDTO VinylFromJson(string json)
        {
            return JsonSerializer.Deserialize<VinylDTO>(json);
        }*/
    }
}
