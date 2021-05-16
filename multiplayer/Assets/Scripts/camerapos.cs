using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;
public class camerapos : MonoBehaviour
{
    public GameObject camera;
    public GameObject vrremote;
    private PhotonView PV;
    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();
        if (PV.IsMine)
        {
            camera = GameObject.Find("Main Camera");
            vrremote= GameObject.Find("VRBrowserHand");

        }
       
          
    }

    // Update is called once per frame
    void Update()
    { 
    
        if (!PV.IsMine) return;

       transform.position = new Vector3(camera.transform.position.x, 0.4f, camera.transform.position.z);
       transform.rotation = Quaternion.Euler(new Vector3(0, camera.transform.rotation.eulerAngles.y, 0));
    }
}
