using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {
	
	public float jumpSpeed;
	public float jumpHeight;
	public float jumpMoveRange;
	public float jumpSpeedMul;
	public float downSpeed;
	public float downSpeedMul;
	public float downMoveRange;
	public float downHeight;
	public Vector3 characterPos;
	public Vector3 pillarPos;
	
	
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
        if (Input.GetKeyUp(KeyCode.Space))
        {
        characterPos = transform.position; 
		pillarPos = GetComponent<PillarCtr>().pillarPosition;
		
		
			
		
		if(characterPos.y > pillarPos.y){
			Debug.Log("Success");
		}else{
			Debug.Log("Failed");
	}
        }
	
	}

}
