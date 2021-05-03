using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Managers
{
    using Data;
    using Logic.DTO;

    public class ClientsManager
    {
        private DataBase dataBase = null;

        public ClientsManager()
        {
            dataBase = Data.GetDataBase();
        }

        public List<ClientDTO> GetAllClientsAsDTO()
        {
            List<ClientDTO> listToReturn = new List<ClientDTO>();

            foreach (Client client in dataBase.GetAllClients())
            {
                listToReturn.Add(DTOMapper.Map(client));
            }

            return listToReturn;
        }

    }
}
