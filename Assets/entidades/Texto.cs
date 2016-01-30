using System;

[Serializable()]
public class Texto
{
	[System.Xml.Serialization.XmlAttribute("esp")]
	public string esp  { get ; set; }

	[System.Xml.Serialization.XmlAttribute("eng")]
	public string eng  { get ; set; }
}

