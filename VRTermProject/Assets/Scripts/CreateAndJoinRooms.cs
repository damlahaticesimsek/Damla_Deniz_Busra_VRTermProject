using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
        Debug.Log("Created");

    }

    
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom() 
    {
        //PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.LoadLevel("DryForestEnvironment");
        Debug.Log("Joined a room");
    }

}
