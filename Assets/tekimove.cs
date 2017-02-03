using UnityEngine;
using System.Collections;

public class tekimove : MonoBehaviour {

    public float speed = 0.1f;

    public float rot;

    public Transform player;    // 追いかけ対象

    Vector3 move = new Vector3(0,0,0);


    public float mouse = 0.0f;

    public float rotation = 0.0f;

    // Use this for initialization
	void Start () {

       // player = GameObject.Find("player").transform;

       
	
	    
	}
	
	// Update is called once per frame
	void Update () {


        transform.LookAt(player.transform.position);

        move = Vector3.forward;

        transform.Translate(move * speed);
        
      
       
        /*
        move = player.position - transform.position;    // ターゲット方向ベクトル


       
        // ターゲットを向く
       // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(move.x, 0, move.z)), 0.3f);

       transform.Translate(transform.forward * speed);
	    */
     
	}
    private void rota(Vector3 move)
    {

        

        float addRotationY = 0.0f;

      //  addRotationY += (Input.GetAxis("Horizontal") * rotation);

        

        mouse += (addRotationY * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0, mouse, 0);

    }
}
