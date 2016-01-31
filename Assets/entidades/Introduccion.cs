using System;
using System.Xml.Serialization;

[Serializable()]
public class Introduccion
{
	[System.Xml.Serialization.XmlElement("texto")]
	public Texto[] textos;
}

