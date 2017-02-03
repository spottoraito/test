using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

    public int angle = 360;

    public int score = 10;

    private Vector3 target;




	// Use this for initialization
	void Start () {

        Transform T = GameObject.Find("player").transform;

        target = T.position;

        transform.LookAt(T);

        transform.Rotate(0,0,Random.Range(0,360),Space.World);
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 axis = transform.TransformDirection(Vector3.up);
        transform.RotateAround(target,axis,angle*Time.deltaTime);
	}
}
