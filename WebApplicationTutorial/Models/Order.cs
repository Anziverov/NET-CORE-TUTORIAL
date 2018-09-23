using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTutorial.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Adress { get; set; }
        public string ContactPhone { get; set; }


        #region ref to Phone model
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
        #endregion
    }
}
