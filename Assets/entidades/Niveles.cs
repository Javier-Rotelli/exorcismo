using System;
using System.Xml;
using System.Xml.Serialization;


[Serializable()]
[XmlRoot("juego")]
public class Niveles
{
	[XmlArray("niveles")]
	[XmlArrayItem("nivel", typeof(Nivel))]
	public Nivel[] nivel { get; set; }
}