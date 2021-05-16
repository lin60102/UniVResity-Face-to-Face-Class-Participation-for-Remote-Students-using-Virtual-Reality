using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMeIfIAmLocal : MonoBehaviour
{
    PhotonView PV;
    // Start is called before the first frame update
    void Start()
    {
        PV = transform.parent.parent.GetComponent<PhotonView>();
       if (PV.IsMine)
            GetComponent<SkinnedMeshRenderer>().enabled = false;

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
