using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperarDatoDePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(PlayerPrefs.GetString("nombreAlmacenado"));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
