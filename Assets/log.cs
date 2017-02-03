using UnityEngine;
using System.Collections;

public class log : MonoBehaviour {

    string[] data = { "apple","banana","raito"};

	// Use this for initialization
	void Start () {

        for (int i = 0; i < data.Length; i++)
            Debug.Log(data[i]);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
