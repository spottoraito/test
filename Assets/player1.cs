using UnityEngine;
using System.Collections;



public class player1 : MonoBehaviour {

    [SerializeField]
    private int data = 0;

    public float move = 5.0f;

    public float rotationS = 360;

    Animator ani;

    CharacterController chara;

    

    public bool on;
    public float speed;

	// Use this for initialization
    void Start()
    {

        on = false;

        chara = GetComponent<CharacterController>();    // キャラクターコントローラ呼び出し

        ani = GetComponentInChildren<Animator>();

    }
	
	// Update is called once per frame
	void Update () {

        move1();
     
    }
    void move1()
    {
           Vector3 movehoukou = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));  // キー指定 上下移動　左右移動


       
        if (movehoukou.sqrMagnitude > 0.01f)    // ベクトルの2乗を返す（入力されたかどうか）
        {
            Vector3 forward = Vector3.Slerp(transform.forward,movehoukou,rotationS * Time.deltaTime / Vector3.Angle(transform.forward,movehoukou));
           transform.LookAt(transform.position + forward);
        }
        chara.Move(( movehoukou * move) * Time.deltaTime);

        ani.SetFloat("speed",chara.velocity.magnitude);
	
    }

    void OnTriggerEnter(Collider player)
    {


        on = true;

    }

    void OnTriggerExit(Collider player)
    {

        on = false;



    }

    /*
    void hasigo()
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
           this.transform.Translate(0, Pos.y, 0);
        
    }
    */

    /*
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

       
    }
     */
}

    



/*
 Get.Axis キー入力処理
 * GetComponent コンポーネント取得
 * transform
 * .translate
 * .rotation
 * .LookAt
 * 
 */