using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistencia_PlayerPrefs : MonoBehaviour {

    public string nombre;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetString("nombreAlmacenado", nombre);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
