using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject[] spawnPoints;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < spawnPoints.Length; ++i)
        {
            int randNum = Random.Range(1, 21);
            GameObject loadedItem = 
                (GameObject)Resources.Load("Pickables/Pickable" + randNum);
            Instantiate(loadedItem,
                spawnPoints[i].transform.position,
                spawnPoints[i].transform.rotation);
        }
	}
}
