using UnityEngine;
using System.Collections;

public class PillarCtr : MonoBehaviour {

	public float speed =2f;
	public float topPosition = 3f;
	public float bottomPosition = 0.5f;
	
	public Vector3 pillarPosition;
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	pillarPosition = transform.position;
	pillarPosition.y += speed *Time.deltaTime;
	transform.position = pillarPosition;
	
	if ( pillarPosition.y < bottomPosition){
		speed = Mathf.Abs(speed);
	} else if (pillarPosition.y > topPosition ) {
		speed = -Mathf.Abs(speed);
	}
	}
	
	
}
