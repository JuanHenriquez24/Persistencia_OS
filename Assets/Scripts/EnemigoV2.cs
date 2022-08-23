﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoV2 : MonoBehaviour {

    public EnemyDataSO data;
	// Use this for initialization
	void Start () {
        data.tr = transform;
		if (data.defeated)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
private void OnMouseDown()
{
    data.defeated = true;
    GetComponent<MeshRenderer>().enabled = false;
    GetComponent<Collider>().enabled = false;
 }
}