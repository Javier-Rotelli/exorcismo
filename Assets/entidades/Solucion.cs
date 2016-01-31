using System;
using System.Collections.Generic;
using System.Xml;

[Serializable()]
public class Solucion
{
	[System.Xml.Serialization.XmlElement("slot")]
	public Slot[] slots;

	[System.Xml.Serialization.XmlElementAttribute ("texto", typeof(Texto))]
	public Texto texto { get; set; }
}