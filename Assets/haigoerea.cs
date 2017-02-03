using UnityEngine;
using System.Collections;

public class haigoerea : MonoBehaviour {


    public GameObject player;

    public GameObject noboriori;

    public bool flag;

	// Use this for initialization
	void Start () {

        flag = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider player){

        if (!flag)
        {
            flag = true;
            GameObject T = (GameObject)Instantiate(noboriori,this.transform.position,this.transform.rotation);
            T.name = noboriori.name;
            Destroy(player.gameObject);
        }

    }
    void OnTriggerExit(Collider noboriori)
    {
        flag = false;
        GameObject T = (GameObject)Instantiate(player, this.transform.position, this.transform.rotation);
        T.name = noboriori.name;
        Destroy(noboriori.gameObject);

    }
}
