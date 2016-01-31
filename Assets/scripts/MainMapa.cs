using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMapa : MonoBehaviour {
	Estado estado;
	int textoActual = 0;



	GameObject viewportMapa;
	GameObject pantallaIntro;
	GameObject fondo;
	GameObject pantallaFin;

	const string textoPerdiste = "Sacerdote... has fallado.\n\n Pero aún creemos en ti.\n Intentalo nuevamente, eres nuestra unica esperanza";
	const string textoGanaste = "Sacerdote... has fallado.\n\n Pero aún creemos en ti.\n Intentalo nuevamente, eres nuestra unica esperanza";
	public Sprite spritePerdiste;
	public Sprite spriteGanaste;

	void Awake () {
		estado = Estado.Instance;
		viewportMapa = GameObject.Find ("ViewportMapa");
		pantallaIntro = GameObject.Find ("PantallaIntro");
		pantallaFin = GameObject.Find ("PantallaPerdiste");
		fondo = GameObject.Find ("Fondo");
	}

	void Start() {
		switch (estado.nivelActual) {
		case 0:
			pantallaIntro.GetComponent<CanvasGroup> ().alpha = 1;
			pantallaIntro.GetComponent<PantallaIntro> ().enabled = true;
			break;
		case -1:
			procesarFinal (textoPerdiste, spritePerdiste);
			break;
		case 7:
			procesarFinal (textoGanaste, spriteGanaste);
			break;
		default:
			break;
		}
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

	void procesarFinal(string texto, Sprite imagen){
		pantallaFin.GetComponentInChildren<Image> ().sprite = imagen;
		pantallaFin.GetComponentInChildren<Text> ().text = texto;
		pantallaIntro.GetComponent<CanvasGroup> ().alpha = 1;
		pantallaFin.GetComponent<PantallaIntro> ().enabled = true;
	}
}
