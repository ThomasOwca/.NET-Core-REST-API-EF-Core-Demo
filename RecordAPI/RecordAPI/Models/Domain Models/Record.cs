using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecordAPI.Models.Domain_Models
{
    public class Record
    {
        [Required]
        public int Id { get; set; }
        public string Status { get; set; }
        public string Owner { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime LastTimeCreated { get; set; }
        [ForeignKey("CommentId")]
        public Comment Comment { get; set; }
    }
}
