using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMapa : MonoBehaviour {
	Estado estado;
	int textoActual = 0;



	GameObject viewportMapa;
	GameObject pantallaIntro;
	GameObject camino;
	GameObject pantallaFin;

	const string textoPerdiste = "Sacerdote... has fallado.\n\n Pero aún creemos en ti.\n Intentalo nuevamente, eres nuestra unica esperanza";
	const string textoGanaste = "Sacerdote... has fallado.\n\n Pero aún creemos en ti.\n Intentalo nuevamente, eres nuestra unica esperanza";
	public Sprite spritePerdiste;
	public Sprite spriteGanaste;
	public Sprite[] caminos;
	AudioSource musica;

	void Awake () {
		estado = Estado.Instance;
		viewportMapa = GameObject.Find ("ViewportMapa");
		pantallaIntro = GameObject.Find ("PantallaIntro");
		pantallaFin = GameObject.Find ("PantallaPerdiste");
		camino = GameObject.Find ("camino");
		musica = GameObject.Find ("MusicaMapa").GetComponent<AudioSource> ();
	}

	void Start() {
		empezarNivelActual ();
		camino.GetComponent<SpriteRenderer> ().sprite = caminos [estado.nivelActual];
	}

	void empezarNivelActual ()
	{
		
		switch (estado.nivelActual) {
		case -1:
			procesarFinal (textoPerdiste, spritePerdiste);
			estado.nivelActual = 0;
			empezarNivelActual ();
			musica.Play ();
			break;
		case 0:
			pantallaIntro.GetComponent<CanvasGroup> ().alpha = 1;
			pantallaIntro.GetComponent<PantallaIntro> ().enabled = true;
			break;
		case 7:
			procesarFinal (textoGanaste, spriteGanaste);
			musica.Play ();
			break;
		default:
			musica.Play ();
			handleClick ();
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

	void Update() {
		if(Input.GetKey(KeyCode.Alpha0))
		{
			estado.nivelActual++;
		}
	}
}
