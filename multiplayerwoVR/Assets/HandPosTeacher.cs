using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPosTeacher : MonoBehaviour
{
    private PhotonView PV;
    Transform tracker;
   
    // Start is called before the first frame update
    void Start()
    {
         
        PV =GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PV.IsMine)
        {
            if (Input.touchCount > 0)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    //transform.position = hit.point;
                    transform.position = new Vector3(hit.point.x,hit.point.y,hit.point.z-0.03f);
                    //Debug.Log(transform.position+" "+ hit.point);

                }
                //Debug.Log("Checking mouse");

                // Debug.Log("mouse pos: " + Camera.main.ScreenToWorldPoint(Input.mousePosition));

                //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            }
        }
    }
}
