using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecordAPI.Models.Domain_Models
{
    public class Comment
    {
        [Required]
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Text { get; set; }
    }
}
