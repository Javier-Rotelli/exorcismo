using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;

[Serializable()]
[XmlRoot("juego")]
public class Mapa
{
	[XmlArray("mapa")]
	[XmlArrayItem("introduccion", typeof(Introduccion))]
	public Introduccion[] introducciones;

	Queue<Introduccion> _introducciones;

}
