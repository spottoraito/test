using UnityEngine;
using System.Collections;

public class ran : MonoBehaviour {


   

    public float speed = 0.1f;

    public float rot;

    public bool on;

    public Transform player;    // 追いかけ対象

    public Vector3 move = new Vector3(0, 0, 0);
  

    public Vector3 distance;

	// Use this for initialization
	void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(player.transform.position);

        if (on == true)
        {

            move = Vector3.forward;

            transform.Translate(move * speed);
        }

       
      
      //  distance = this.transform.position - player.transform.position;
	
	}


    void OnTriggerStay(Collider player)
    {
        on = true;
    }
    void OnTriggerExit(Collider player)
    {
        on = false;
    }
}
