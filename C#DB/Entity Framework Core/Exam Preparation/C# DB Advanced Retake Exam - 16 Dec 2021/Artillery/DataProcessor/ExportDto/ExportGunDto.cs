﻿using Artillery.Data.Models;
using Artillery.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ExportDto;
[XmlType("Gun")]
public class ExportGunDto
{
    [XmlAttribute("Manufacturer")]
    public string Manufacturer { get; set; }

    [XmlAttribute("GunType")]
    public string GunType { get; set; }

    [XmlAttribute("GunWeight")]
    public int GunWeight { get; set; }

    [XmlAttribute("BarrelLength")]
    public double BarrelLength { get; set; }
    [XmlAttribute("Range")]
    public int Range { get; set; }
    [XmlArray("Countries")]
    public ExportCountryDto[] Countries { get; set; }

}
[XmlType("Country")]
public class ExportCountryDto
{
    [XmlAttribute("Country")]
    public string Country { get; set; }
    [XmlAttribute("ArmySize")]
    public int ArmySize { get; set; }
}