﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace PetClinic.DataProcessor.DTO.Import
{
    [XmlType("Procedure")]
    public class ImportProcedureDTO
    {
        //     <Procedure>
        //     <Vet>Niels Bohr</Vet>
        //     <Animal>acattee321</Animal>
        //<DateTime>14-01-2016</DateTime>
        //     <AnimalAids>
        //         <AnimalAid>
        //             <Name>Nasal Bordetella</Name>
        //         </AnimalAid>
        //         <AnimalAid>
        //             <Name>Internal Deworming</Name>
        //         </AnimalAid>
        //         <AnimalAid>
        //             <Name>Fecal Test</Name>
        //         </AnimalAid>
        //     </AnimalAids>
        // </Procedure>

        [Required]
        [XmlElement("Vet")]
        public string VetName { get; set; }

        [Required]
        [XmlElement("Animal")]
        public string AnimalSerialNumber { get; set; }

        [Required]
        public string DateTime { get; set; }

        [XmlArray("AnimalAids")]
        public List<AnimalAidDTO> AnimalAids { get; set; }
    }

    [XmlType("AnimalAid")]
    public class AnimalAidDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
