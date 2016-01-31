using System;

[Serializable()]
public class Texto
{
	[System.Xml.Serialization.XmlElement("esp")]
	public string esp  { get ; set; }

	[System.Xml.Serialization.XmlElement("eng")]
	public string eng  { get ; set; }
}

