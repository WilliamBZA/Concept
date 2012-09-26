using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Concept.ViewModels
{
    public class OnlineEnquiryViewModel
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}