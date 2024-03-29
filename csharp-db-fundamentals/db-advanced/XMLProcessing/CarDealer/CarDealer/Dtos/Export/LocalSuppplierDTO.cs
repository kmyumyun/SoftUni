﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Dtos.Export
{
    [XmlType("supplier")]
    public class LocalSupplierDTO
    {
        [XmlElement("suplier")]
        public List<SupplierDTO> Suppliers { get; set; }
    }

    public class SupplierDTO
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("parts-count")]
        public int PartsCount { get; set; }
    }
}
