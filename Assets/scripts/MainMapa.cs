using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

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

		if (scriptAnimar.enabled) {
			return; //todavia estoy animando el texto anterior
		}

		if (textoActual < intro.textos.Length) {
			
			scriptAnimar.texto = intro.textos [textoActual].esp.Trim();
			scriptAnimar.enabled = true;
			textoActual++;
		} 
		else {
			pasarABatalla ();
		}
	}


	void pasarABatalla ()
	{
		SceneManager.LoadScene ("batalla");
	}
}
