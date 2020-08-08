using UnityEngine;
using UnityStandardAssets.Vehicles.Ball;

public class DificultyLevelSetter : MonoBehaviour {

	private float time = 0.0f;
	private int timeToNextLevel = 20;
	private float difficultyLvl = 1.0f;
	private int maxDifficultyLvl = 10;

	
	// Update is called once per frame
	void Update () {
		
		if (time >= timeToNextLevel)
			nextLvl();
		time += Time.deltaTime;
	}
	void nextLvl()
	{
		if (difficultyLvl == maxDifficultyLvl)
			return;
		difficultyLvl++;
		timeToNextLevel *= 2;
		time = 0.0f;
		GetComponent<Ball>().setPower(difficultyLvl);
	}
}
