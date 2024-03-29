﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject1.Models
{
    public class ItemData
    {
        [Key]
        public int paymentDetailId { get; set; }
        public string cardOwnerNumber { get; set; }
        public string cardNumber { get; set; }
        public string expirationDate { get; set; }
        public string securityCode { get; set; }
    }
}