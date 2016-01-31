using System;
using UnityEngine;

public class Estado
{
	private static Estado _singleton;
	private static object lockObject = new object();

	public Niveles niveles;
	public Mapa mapa;

	public int nivelActual = 0;

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

	public Introduccion getIntroduccionActual() {
		if (niveles.nivel [nivelActual] == null) {
			Debug.LogFormat ("ERROR: se quiso cargar el nivel nro:{0} pero no existe. volviendo al nivel 0", nivelActual);
			nivelActual = 0;
		}
		return mapa.introducciones [nivelActual];
	}

	void CargarRecursos () {
		var textAsset = (TextAsset) Resources.Load("niveles");
		var nvd = new NivelSerializer ();
		niveles = nvd.NivelesDeserializer (textAsset.text);

		var mapserializer = new Mapaserializer();

		mapa = mapserializer.MapaDeserializer (textAsset.text);
	}
}