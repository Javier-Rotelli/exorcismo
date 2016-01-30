using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class NivelSerializer
{
	public Niveles NivelesDeserializer(string text)
	{
		using(TextReader tr = new StringReader(text)){
			Niveles niveles;
			XmlSerializer serializer = new XmlSerializer(typeof(Niveles));
			niveles = (Niveles)serializer.Deserialize (tr);
			return niveles;
		}
	}
}