using System;
using System.Collections.Generic;
using System.Xml;

[Serializable()]
public class Solucion
{
	[System.Xml.Serialization.XmlArray("slot")]
	[System.Xml.Serialization.XmlArrayItem("carta")]
	public string[][] cartas;
}