using UnityEngine;
using System.Collections;

public class moveup : MonoBehaviour {


    public GameObject player;

    public float speed;

    public float upspeed;

    public bool rock;

	// Use this for initialization
	void Start () {

        rock = false;
     
	}
	
	// Update is called once per frame
	void Update () {


        if (rock)
        {
            Vector3 Pos = Vector3.zero;
            Vector3 input = new Vector3(0, Input.GetAxis("Vertical"), 0);

            if (input.y > 0)
            {
                Pos.y = speed;
            }
            else if (input.y < 0)
            {
                Pos.y = -speed;
            }
            player.transform.Translate(0, Pos.y, 0);
        }
	}

   void OnTriggerEnter(Collider player){

       rock = true;

    }
   void OnTriggerExit(Collider player)
   {
       rock = false;
   }

}
