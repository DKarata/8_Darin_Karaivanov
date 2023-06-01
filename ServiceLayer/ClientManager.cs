using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    class ClientManager
    {
        private static ClientContext clientContext;
        public ClientManager(RestaurantDbContext dbContext)
        {
            clientContext = new ClientContext(dbContext);
        }

        public static void Create(Client client)
        {
            try
            {
                clientContext.Create(client);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Client Read(int key)
        {
            try
            {
                return clientContext.ReadOne(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static ICollection<Client> ReadAll()
        {
            try
            {
                return clientContext.ReadAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Update(Client client)
        {
            try
            {
                clientContext.Update(client);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Delete(int key)
        {
            try
            {
                clientContext.Delete(key);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
