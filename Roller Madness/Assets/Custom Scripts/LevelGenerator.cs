using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelGenerator : MonoBehaviour {
	private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;

	[SerializeField] private Transform levelPart_Start;
	[SerializeField] private List<Transform> levelPartList;
	private Transform playerTransform;

	private Vector3 lastEndPosition; 
	private void Awake() {
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		lastEndPosition = levelPart_Start.Find("EndPosition").position;
		int startingspawnLevelParts = 1;
		for(int i = 0; i < startingspawnLevelParts; i++)
		{
			spawnLevelPart();
		}
	}

	private void Update()
	{
		if(Vector3.Distance(playerTransform.position, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
		{
			spawnLevelPart();
		}
	}
	private void spawnLevelPart()
	{
		Transform chooseLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
		Transform lastPartTransform = spawnLevelPart(chooseLevelPart, lastEndPosition);
		lastEndPosition = lastPartTransform.Find("EndPosition").position;
	}

	private Transform spawnLevelPart(Transform levelPart, Vector3 spawnPosition)
	{
		Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
		return levelPartTransform;
	}

}
