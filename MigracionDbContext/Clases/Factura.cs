﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionDbContext.Clases
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public string ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Total { get; set; }
    }
}
