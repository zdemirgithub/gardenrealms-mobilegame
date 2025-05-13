using Photon.Pun;
using UnityEngine;

public class MultiplayerManager : MonoBehaviourPunCallbacks
{
    public static MultiplayerManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public void StartGame()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room successfully!");
        PhotonNetwork.LoadLevel("GameScene");
    }

    public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
    {
        Debug.Log("Player " + newPlayer.NickName + " entered the room.");
    }

    public void EndGameForAll()
    {
        PhotonNetwork.LoadLevel("GameOverScene");
    }
}
