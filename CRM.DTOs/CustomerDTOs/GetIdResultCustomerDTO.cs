﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CRM.DTOs.CustomerDTO
{
    public class GetIdResultCustomerDTO
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string Name {  get; set; }

        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Display(Name = "Direccion")]
        public string? Address {  get; set; }
    }
}
