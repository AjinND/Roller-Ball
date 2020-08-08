using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {
	public GameObject[] tilePrefabs;

	private Transform playerTransform;
	private float spawnZ = 0f;
	private float tileLenght;
	private int amntOfTileOnScreen = 7;
	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		tileLenght = GameObject.FindGameObjectsWithTag("Platform").Length;
		for(int i = 0; i < amntOfTileOnScreen; i++)
		{
			tileSpawn();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTransform.position.z > (spawnZ - amntOfTileOnScreen * tileLenght))
		{
			tileSpawn();
		}
		
	}
	private void tileSpawn(int prefabIndex = -1)
	{
		GameObject go;
		go = Instantiate(tilePrefabs[0]) as GameObject;
		go.transform.SetParent(transform);
		go.transform.position = Vector3.forward * spawnZ;
		spawnZ += tileLenght;
	}
}
