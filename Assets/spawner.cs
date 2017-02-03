using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

    public GameObject pre;
    public float ins;
    public float rag = 3;

	// Use this for initialization
	IEnumerator Start () {

        while (true)
        {
            transform.position = new Vector3(transform.position.x,Random.Range(-rag,rag),transform.position.z); // 形成位置の設計

            Instantiate(pre, transform.position, transform.rotation);

            yield return new WaitForSeconds(ins);
        }
	}
	
	// Update is called once per frame
	void Update () {


      
	}
}
