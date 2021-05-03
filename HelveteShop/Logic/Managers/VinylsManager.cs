﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Managers
{
    using Data;
    using Logic.DTO;

    public class VinylsManager
    {
        private DataBase dataBase = null;

        public VinylsManager()
        {
            dataBase = Data.GetDataBase();
        }

        public List<VinylDTO> GetAllVinylsAsDTO()
        {
            List<VinylDTO> listToReturn = new List<VinylDTO>();

            foreach (Vinyl vinyl in dataBase.GetAllVinyls())
            {
                listToReturn.Add(DTOMapper.Map(vinyl));
            }

            return listToReturn;
        }

    }
}
