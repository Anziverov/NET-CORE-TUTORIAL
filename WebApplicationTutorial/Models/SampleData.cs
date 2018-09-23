using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTutorial.Models
{
    public class SampleData
    {
        public static void Initialize(MobileContext context) //We add new content to db if there is no current one exists
        {
            if(!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "Iphone 5s",
                        Company = "Apple",
                        Price = 900
                    },
                    new Phone
                    {
                        Name = "Mi 5",
                        Company = "Xiaomi",
                        Price = 300
                    },
                    new Phone
                    {
                        Name = "Galaxy S6",
                        Company = "Samsung",
                        Price = 800
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
