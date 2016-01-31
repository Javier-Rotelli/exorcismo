using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MandarClickAlMain : MonoBehaviour, IPointerClickHandler {

	#region IPointerClickHandler implementation

	public void OnPointerClick (PointerEventData eventData)
	{
		GameObject.Find("Nivel").GetComponent<MainMapa> ().handleClick ();
	}

	#endregion



}
