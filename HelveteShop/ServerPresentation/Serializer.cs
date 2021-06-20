using System;
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

        public static float FloatFromJson(string json)
        {
            return JsonSerializer.Deserialize<float>(json);
        }

        public static int IntFromJson(string json)
        {
            return JsonSerializer.Deserialize<int>(json);
        }
    }
}
