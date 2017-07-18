using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoruBankasi.Models.Data
{
    public class Question
    {
        public int ID { get; set; }
        public string Definition { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
