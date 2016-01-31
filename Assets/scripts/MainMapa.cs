using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMapa : MonoBehaviour {
	Estado estado;

	void Awake () {
		estado = Estado.Instance;

		Debug.Log(estado.mapa.introducciones[0].textos[0].esp);
	}

	
	// Update is called once per frame
	void Update () {
	}
}
