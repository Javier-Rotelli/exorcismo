using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// El gc es un singleton, asi lo hacemos en unity
	public static GameController instance;

	public Niveles niveles;

	public GameController(){
	}

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}



	void Update(){
		
	}


}