﻿using System;
namespace IvanAgencyService.BindingModel
{
   public class ReportBindingModel
    {
        public string FileName { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }
}
