
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhotonTeacher : MonoBehaviour
{
    private PhotonView PV;
    public GameObject myAvatar;
    public GameObject teacherpoint;
    // Start is called before the first frame update
    void Start()
    {
        
        PV = GetComponent<PhotonView>();
        //
        if(PV.IsMine)
        {
            myAvatar=PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerAvatar"),
                GameSetup.GS.teacherpoint.transform.position, GameSetup.GS.teacherpoint.transform.rotation, 0); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
