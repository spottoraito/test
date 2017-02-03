using UnityEngine;
using System.Collections;

public class sample : MonoBehaviour {


    public Transform target;
    public float speed = 0.1f;
    private Vector3 vec;


	// Use this for initialization
	void Start () {
        //target = GameObject.Find("対象").transform;
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);
        transform.position += transform.forward * speed;
	
	}
}
