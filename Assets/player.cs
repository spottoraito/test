using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {


    public float jump;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0,jump,0);
        }
	}
    void OnCollisionEnter(Collision other)
    {
        Application.LoadLevel(Application.loadedLevel);

    }
}
