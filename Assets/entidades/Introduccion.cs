using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;

[Serializable()]
public class Introduccion
{
	[System.Xml.Serialization.XmlElement("texto")]
	public Texto[] textos;
}

