using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonLobby : MonoBehaviourPunCallbacks
{

    public static PhotonLobby lobby;

    public GameObject battlebutton;
    public GameObject cancelbutton;

    private void Awake()
    {
        lobby = this; //Creates the singleton, lives withing the main menu scene.
    }

    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = true;
        PhotonNetwork.ConnectUsingSettings(); //connects to Master Photon server


    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Player has connected to the Photon master server");
        PhotonNetwork.AutomaticallySyncScene = true;
        battlebutton.SetActive(true);
    
    }
    public void OnBattleButtonClicked()
    {
        Debug.Log("Battle button was Click");
        battlebutton.SetActive(false);
        cancelbutton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to join a random game but failed. There must be no open games available");
        CreateRoom();
    }
    void CreateRoom()
    {
        Debug.Log("Trying to create a new room");
        int randomRoomName = Random.Range(0, 10000);
        RoomOptions roomops = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)MultiplayerSetting.multiplayersetting.maxPlayers };
        PhotonNetwork.CreateRoom("Room" + randomRoomName, roomops);
    }
   
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to create a random game but failed. There must already be a room with the same name");
        CreateRoom();
    }
   

    public void OnCancelButtonClicked()
    {
        Debug.Log("Cancel button was Click");
        cancelbutton.SetActive(false);
        battlebutton.SetActive(true);
        PhotonNetwork.LeaveRoom(); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
