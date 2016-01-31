using System;
using System.Xml;

[Serializable()]
public class Nivel
{
	[System.Xml.Serialization.XmlAttribute("numero")]
	public int numero { get ; set; }

	[System.Xml.Serialization.XmlElement("textointro")]
	public string textointro { get ; set; }

	[System.Xml.Serialization.XmlElement("solucion", typeof(Solucion))]
	public Solucion[] solucion { get; set; }
}
