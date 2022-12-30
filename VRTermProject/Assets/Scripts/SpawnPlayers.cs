using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public GameObject playerFollow;
    public GameObject playerCamera;

    private void Start()
    {
        //TODO: Spawn Player
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position,  spawnPoint.rotation);
        //playerFollow = GameObject.FindGameObjectWithTag("PlayerFollowCamera");
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");

       
    }

    void SpawnPlayer()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position,  spawnPoint.rotation);
        //PhotonNetwork.Instantiate(playerFollow.name, spawnPoint.position, spawnPoint.rotation);
        //PhotonNetwork.Instantiate(playerCamera.name, spawnPoint.position, spawnPoint.rotation);

    }

}
