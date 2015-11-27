using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour 
{
	public float maxHeight;
	public float jumpTime;
	public float jumpTimeSec;
	
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		float y = 1 * maxHeight * Mathf.Pow(jumpTime*(jumpTimeSec*2)-1,2) + maxHeight;
		
	}
}  
			
		
	
	
