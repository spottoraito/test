using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {


	public float movespeed = 2.0f;

	public float rotation = 720.0f;

	public float mouse = 0.0f;


	bool movestop = false;

   

  



	// 移動速度
	private static readonly float MOVE_F = 1.0f;
	private static readonly float MOVE_B = -1.0f;


//	CharacterController characterController;
	//Animator animator;


	// Use this for initialization
	void Start () {
	//	characterController = GetComponent<CharacterController> ();

	//	animator = GetComponent<Animator> ();


      
	}
	
	// Update is called once per frame
	void Update () {

		//center ();
		// 発射状態の時は手を挙げる

        MOVE();
        rota();

		/*
		characterController.Move (Vector3.right * axisValse * movespeed * Time.deltaTime);
		*/
	}

	void center(){
		//characterController.center = new Vector3 (0,1,0);
	}


	// 進む
	private void MOVE(){
		Vector3 Position = Vector3.zero;	// 移動量

		Vector3 vecInput = new Vector3 (0f, 0, Input.GetAxisRaw ("Vertical"));

		//zに何が入っているかの確認

		if (vecInput.z > 0) {
			Position.z = MOVE_F;	// 前進
		} else if (vecInput.z < 0) {
			Position.z = MOVE_B;	// 後進
		}



		transform.position += ((transform.rotation * Position) * Time.deltaTime);
		// animator.SetFloat ("speed", Position.z);


	}

	// 回転させる
	private void  rota(){
		
		float addRotationY = 0.0f;

		addRotationY += (Input.GetAxis ("Horizontal") * rotation);

		mouse += (addRotationY * Time.deltaTime);

		transform.rotation = Quaternion.Euler (0,mouse,0);

	}
}
