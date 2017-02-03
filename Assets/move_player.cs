using UnityEngine;
using System.Collections;

public class move_player : MonoBehaviour {


    public bool on;
    public GameObject ob; 
	// Use this for initialization
	void Start () {

        on = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (!on)
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(new Vector3(0, 0, 0.1f));
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(new Vector3(0, 0, -0.1f));
            }
          
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-0.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(0.1f, 0, 0));
        }

	}

    void OnTriggerEnter(Collider ob)
    {
        on = true;
    }
    void OnTriggerExit(Collider ob)
    {
        on = false;
    }
}
