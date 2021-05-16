using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.FinalIK;
using Photon.Pun;

public class AttachTargetToAimIK : MonoBehaviour
{
    private PhotonView PV;
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        PV = transform.parent.GetComponent<PhotonView>();
        GameObject[] handposes = GameObject.FindGameObjectsWithTag("handpos");
        foreach (GameObject g in handposes)
        {
            if (g.transform.GetComponent<PhotonView>().Owner == PV.Owner)
            {
                GetComponent<FullBodyBipedIK>().solver.rightHandEffector.target = g.transform;
                Debug.Log("Hurray!");
                break;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
