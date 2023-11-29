﻿using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ExportDto;
[XmlType("Boardgame")]
public class ExportBoardGame
{
    [XmlElement("BoardgameName")]
    public string BoardgameName { get; set; }
    [XmlElement("BoardgameYearPublished")]

    public int BoardgameYearPublished { get; set; }

}