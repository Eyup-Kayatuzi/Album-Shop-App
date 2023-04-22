using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    public class Manager : Base
    {
        public int ManagerId { get; set; }  
        public string UserName { get; set; }
        public string Password { get; set; }    
    }
}
