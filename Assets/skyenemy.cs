using UnityEngine;
using System.Collections;

public class skyenemy : MonoBehaviour {

    bool on = false;
    public GameObject empty;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

 //       if (on)
//        {
//             attack(empty.transform.position);
//        
//        }
	
	}

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "player")
        {
            Instantiate(empty, player.transform.position, player.transform.rotation);
            //on = true;
        }

       
    }


    void attack(Vector3 position)
    {

        transform.LookAt(position);

        transform.Translate(Vector3.forward * 0.4f);
       
    }

}
