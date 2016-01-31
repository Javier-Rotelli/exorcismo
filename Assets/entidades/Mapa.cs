using System;
using System.Xml.Serialization;

[Serializable()]
[XmlRoot("juego")]
public class Mapa
{
	[XmlArray("mapa")]
	[XmlArrayItem("introduccion", typeof(Introduccion))]
	public Introduccion[] introducciones;

}
