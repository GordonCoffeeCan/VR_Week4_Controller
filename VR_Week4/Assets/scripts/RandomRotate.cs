using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 90);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
