using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HW1_BirthdayCard.Models
{
    public class CardEntry
    {
        [Required(ErrorMessage = "Please enter who this card is send from")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter who this card is send to")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter the message of this card")]
        public string Message { get; set; }
    }
}