using System;
using UnityEngine;

public class Estado
{
	private static Estado _singleton;
	private static object lockObject = new object();

	public Niveles niveles;

	private Estado (){
		CargarRecursos ();
	}

	public static Estado Instance 
	{
		get
		{
			lock(lockObject)
			{
				if (_singleton == null)
					_singleton = new Estado();
			}
			return _singleton;
		}
	}

	void CargarRecursos () {
		var textAsset = (TextAsset) Resources.Load("niveles");
		var nvd = new NivelSerializer ();
		niveles = nvd.NivelesDeserializer (textAsset.text);

	}
}