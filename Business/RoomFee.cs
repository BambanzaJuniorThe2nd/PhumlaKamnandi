using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace PhumlaKamnandi.Business
{
    public class RoomFee
    {
        public enum Season
        {
            LowSeason,
            MidSeason,
            HighSeason
        }

        Collection<Booking> LowSeason;
        Collection<Booking> MidSeason;
        Collection<Booking> HighSeason;
        Season season;



        public RoomFee()
        {

        }

        //    public static decimal getTotalFee( String checkin, String checkout)
        //    {

        //        decimal price = 0; 

        //       if (int.Parse(checkin.Substring(0,2)) <= 7)
        //        {
        //            price = 550;


        //        }

        //       else if ((int.Parse(checkin.Substring(0, 2)) >= 8) && (int.Parse(checkout.Substring(0, 2)) <= 15))
        //        {
        //            price = 750;
        //        }

        //       else if ((int.Parse(checkin.Substring(0, 2)) >= 16) && (int.Parse(checkout.Substring(0, 2)) <= 31))
        //        {
        //            price = 995;
        //        }


        //        return price;
        //    }



        //}
        public decimal TotalFee(DateTime checkin)
        {

            decimal price = 0;
            DateTime lowcheckin = new DateTime(2021, 12, 01);
            DateTime midcheckin = new DateTime(2021, 12, 08);
            DateTime Highcheckin = new DateTime(2021, 12, 16);

            if (checkin.Date < midcheckin.Date)
            { 
                price = 550;
              
            }
            else if ((checkin.Date >= midcheckin.Date)&&(checkin.Date<Highcheckin.Date))
            {
                price = 750;
                
            }
            else if (checkin.Date <= Highcheckin.Date)
            {
                price = 995;
                
            }
            return price;


        }
    }
}

       
    

