using System;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;

class Mapaserializer
{
	public Mapa MapaDeserializer(string text)
	{
		using(TextReader tr = new StringReader(text)){
			Mapa mapa;
			XmlSerializer serializer = new XmlSerializer(typeof(Mapa));
			mapa = (Mapa)serializer.Deserialize (tr);
			return mapa;
		}
	}
}
