using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMapa : MonoBehaviour {
	Estado estado;

	void Awake () {
		estado = Estado.Instance;
	}

	public void handleClick ()
	{
		if (estado.niveles.nivel [estado.nivelActual] != null) {
			Debug.LogFormat ("ERROR: se quiso cargar el nivel nro:{0} pero no existe. volviendo al nivel 0", estado.nivelActual);
			estado.nivelActual = 0;
		}

	}
}
