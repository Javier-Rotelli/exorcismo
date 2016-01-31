using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMapa : MonoBehaviour {
	Estado estado;
	int textoActual = 0;

	GameObject viewportMapa;

	void Awake () {
		estado = Estado.Instance;
		viewportMapa = GameObject.Find ("ViewportMapa");
	}

	public void handleClick ()
	{
		var intro = estado.getIntroduccionActual ();
		var scriptAnimar = viewportMapa.GetComponent<ScrollearTexto>();
		if (textoActual < intro.textos.Length) {
			if (scriptAnimar.enabled) {
				return; //todavia estoy animando el texto anterior
			}
			scriptAnimar.texto = intro.textos [textoActual].esp;
			scriptAnimar.enabled = true;
			textoActual++;
		} 
		else {
			pasarABatalla ();
		}
	}


	void pasarABatalla ()
	{
		throw new System.NotImplementedException ();
	}
}
