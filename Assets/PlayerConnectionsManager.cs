using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConnectionsManager : MonoBehaviour
{
    
    private List<PlayerController> activePlayerControllers;
    public int numberOfPlayers;
    public GameObject playerPrefab;
    

    void Start()
    {
        SetupActivePlayers();
    }

    void SetupActivePlayers()
    {

        activePlayerControllers = new List<PlayerController>(numberOfPlayers);

            SpawnPlayers();

            //SetupUIMenuPlayerList();

    }
    void SpawnPlayers()
    {
         for(int i = 0; i < numberOfPlayers; i++)
        {

            GameObject spawnedPlayer = Instantiate(playerPrefab, transform.position, transform.rotation);
            
            activePlayerControllers.Insert(i, spawnedPlayer.GetComponent<PlayerController>());

            Vector3 spawnPosition = Vector3.zero;//PositionInRing(i);
            spawnedPlayer.transform.position = spawnPosition;

            // Quaternion randomSpawnRotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0));
            // spawnedPlayer.transform.rotation = randomSpawnRotation;

        }

       // SetupUIMenuPlayerList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
