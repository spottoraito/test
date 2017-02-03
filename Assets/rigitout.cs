using UnityEngine;
using System.Collections;

public class rigitout : MonoBehaviour
{


    Rigidbody r;
    public GameObject hasigo;

    // Use this for initialization
    void Start()
    {

        r = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider hasigo)
    {
        r.isKinematic = true;
    }
    void OnTriggerExit(Collider hasigo)
    {
        r.isKinematic =false;
    }

}
