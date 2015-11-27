using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PillarCtr : MonoBehaviour {

	public float speed =2f;
	public float topPosition = 3f;
	public float bottomPosition = 0.5f;
	public Vector3 pillarPosition;
	public Transform characterPos;
	
	// Use this for initialization
	void Start () 
	{

		
	}
    // Update is called once per frame
	
    void Update () 
	{		
		pillarPosition = transform.position; 
		pillarPosition.y += speed * Time.deltaTime;
		transform.position = pillarPosition;
		
		GameObject Cc = GameObject.Find("ChControl");
		characterPos = Cc.GetComponent<Transform>();
		
		if(pillarPosition.x == characterPos.transform.position.x)
		{
			StopPillar();
		}
	    else if ( pillarPosition.y < bottomPosition)
		{
			speed = Mathf.Abs(speed);
		} 
		else if (pillarPosition.y > topPosition ) 
		{
			speed = -Mathf.Abs(speed);
		}	
	}
	
	// 움직이지 않는 기둥
	void StopPillar () 
	{
		pillarPosition = new Vector3(pillarPosition.x, 2.28f, pillarPosition.z);
		transform.position = pillarPosition;		
	}
	
		
 
}