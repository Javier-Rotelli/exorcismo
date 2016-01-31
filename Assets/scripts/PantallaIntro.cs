using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PantallaIntro : MonoBehaviour, IPointerClickHandler {

	protected CanvasGroup cg;
	protected bool animating = false;

	AudioSource musica;

	// Use this for initialization
	void Start () {
		cg = GetComponent<CanvasGroup> ();
		musica = GameObject.Find ("MusicaMapa").GetComponent<AudioSource> ();
	}

	void Update(){
		if (cg.alpha > 0f && animating) {
			cg.alpha -= Time.deltaTime/2;
			if (cg.alpha > 0.5f && !musica.isPlaying) {
				musica.Play ();
			}
		} else if (cg.alpha <= 0f) {
			animating = false;
			this.enabled = false;
			GameObject.Find("Nivel").GetComponent<MainMapa> ().handleClick ();
		}
	}

	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData)
	{
		animating = true;
	}
	#endregion
}
