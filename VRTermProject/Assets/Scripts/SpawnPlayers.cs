using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    //public Transform playerCameraRoot;

    private void Start()
    {
        //TODO: Spawn Player
        //PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position,  spawnPoint.rotation);
        SpawnPlayer();

    }

    void SpawnPlayer()
    {
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position,  spawnPoint.rotation);
        //playerCameraRoot = player.transform;

    }

}
