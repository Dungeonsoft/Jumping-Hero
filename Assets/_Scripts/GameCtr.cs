using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameCtr : MonoBehaviour {
	public List<Transform> pillar;
	
	[SerializeField]
	GameObject pillarPrefab;
	
	[SerializeField]
	Transform pillarPool;
	GameObject GO;
	GameObject pillarGO;
	
	[SerializeField]
	Transform pillarBatch;
	
		

	// Use this for initialization
	void Start () 
	{	
		for(int i=0; i<10; i++)
		{
			GO = Instantiate(pillarPrefab);
			GO.name = "pillar"+i.ToString("00") ;
			GO.transform.parent = pillarPool;
			GO.SetActive(false);
		}
		
		
		for(int i=0; i<4; i++)
		{
			pillarGO = pillarPool.GetChild(0).gameObject;
			pillarGO.transform.parent = pillarBatch;
			pillarGO.SetActive(true);
			pillarGO.transform.localPosition = new Vector3((2*i)-2,Random.Range(-1f,2f),0);
			
		}
		
		StartCoroutine(PillarOut());
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	IEnumerator PillarOut ()
	{
		yield return new WaitForSeconds(5f);
		
		pillarGO = pillarBatch.GetChild(0).gameObject;
		pillarGO.transform.parent = pillarPool;
		pillarGO.SetActive(false);
	}
}
