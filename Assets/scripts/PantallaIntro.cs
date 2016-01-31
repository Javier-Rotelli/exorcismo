using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PantallaIntro : MonoBehaviour, IPointerClickHandler {

	protected CanvasGroup cg;
	protected bool animating = false;

	// Use this for initialization
	void Start () {
		cg = GetComponent<CanvasGroup> ();
	}

	void Update(){
		if (cg.alpha > 0f && animating) {
			cg.alpha -= Time.deltaTime;
		} else if (cg.alpha <= 0f) {
			animating = false;
			GameObject.Find ("Musica").GetComponent<AudioSource>().Play ();
		}
	}

	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData)
	{
		animating = true;
	}
	#endregion
}
