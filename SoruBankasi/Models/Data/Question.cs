using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoruBankasi.Models.Data
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Definition { get; set; }
        public int UserID { get; set; }

        [ForeignKey("UserId")]
        public virtual ICollection<User> AppUsers { get; set; }

        public Question()
        {
            AppUsers = new List<User>();
        }
    }
}
