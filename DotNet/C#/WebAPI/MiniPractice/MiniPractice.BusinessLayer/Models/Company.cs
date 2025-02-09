using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPractice.BusinessLayer.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        
        public string Name { get; set; }

        public string City { get; set; }
    }
}
