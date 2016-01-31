using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollearTexto : MonoBehaviour {

	public string texto;
	public int posActual = 0;
	public float delay = 0.75f;
	private float _deltaAcumulado = 0f;
	private Text text;

	void Start() {
		text = gameObject.GetComponentInChildren<Text> ();
		text.text = "";
	}

	// Update is called once per frame
	void Update () {
		_deltaAcumulado += Time.deltaTime;
		if (_deltaAcumulado > delay && posActual < texto.Length) {
			posActual++;
			text.text = texto.Substring (0, posActual);
			_deltaAcumulado = (texto [posActual] == '\n') ? -0.10f : 0;
			_deltaAcumulado = (texto [posActual] == ' ') ? -0.02f : 0;
		}

		if (posActual >= texto.Length) {
			this.enabled = false;
		}
	}
}
