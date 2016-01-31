using System;
using System.Collections.Generic;
using System.Xml;

[Serializable()]
public class Slot
{
	[System.Xml.Serialization.XmlElement("carta")]
	public string[] cartas;
}
