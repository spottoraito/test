using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {


    public Transform traget;
    public float smoothing = 5f;

    Vector3 offset;

	// Use this for initialization
	void Start () {

        offset = transform.position - traget.position;  // 距離指定
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 Campos = traget.position + offset;
        transform.position = Vector3.Lerp(transform.position,Campos,smoothing * Time.deltaTime);
	}
}
