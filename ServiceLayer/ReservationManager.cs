using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    class ReservationManager
    {
        private static ReservationContext reservationContext;
        public ReservationManager(RestaurantDbContext dbContext)
        {
            reservationContext = new ReservationContext(dbContext);
        }

        public static void Create(Reservation reservation)
        {
            try
            {
                reservationContext.Create(reservation);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Reservation Read(int key)
        {
            try
            {
                return reservationContext.ReadOne(key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static ICollection<Reservation> ReadAll()
        {
            try
            {
                return reservationContext.ReadAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Update(Reservation reservation)
        {
            try
            {
                reservationContext.Update(reservation);
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
                reservationContext.Delete(key);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
