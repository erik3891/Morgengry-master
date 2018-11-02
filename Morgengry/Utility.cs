using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        //public static double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet)
            {
                Amulet amulet = (Amulet)merchandise;
                Level q = amulet.Quality;
                // ændringhgchgc
                if (q == Level.low)
                {
                    return 12.5;
                }
                else if (q == Level.medium)
                {
                    return 20.0;
                }
                else
                {
                    return 27.5;
                }

            }
            else
            {
                if (merchandise is Book)
                {
                    Book book = (Book)merchandise;
                    return book.Price;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static double GetValueOfCourse(Course course)
        {
            int DurationInHours = course.DurationInMinutes / 60;
           
            if (course.DurationInMinutes == 0)
            {
                return 0.0; 
            }
            else
            {
                return (DurationInHours + 1) * 875;
            }
        }
    }
}
