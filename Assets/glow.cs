using UnityEngine;
using System.Collections;

public class glow : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Mathf.Abs( Mathf.Cos (Time.time)));
		var material = gameObject.GetComponent<SpriteRenderer> ().material;
		material.SetFloat ("ShineLocation", Mathf.Abs( Mathf.Cos (Time.time)));

		MaterialPropertyBlock pb = new MaterialPropertyBlock ();
		gameObject.GetComponent<SpriteRenderer> ().GetPropertyBlock(pb);
		pb.SetFloat ("ShineLocation", Mathf.Abs (Mathf.Cos (Time.time)));
		gameObject.GetComponent<SpriteRenderer> ().SetPropertyBlock (pb);
	}
}
