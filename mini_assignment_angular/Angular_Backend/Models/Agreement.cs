using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Backend.Models
{
    public class Agreement
    {

        [Key]
        public int AgreementId { get; set; }
        public string Brand { get; set; }

        public string Model { get; set; }

        public string RentPerDay { get; set; }

        public string Total { get; set; }

        public bool Review { get; set; }
    }
}
