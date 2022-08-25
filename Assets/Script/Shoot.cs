using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject arCamera;
  //  public GameObject smaoke;

    public void Shooting()
    {
        RaycastHit hit;
        if( Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            Destroy(hit.transform.gameObject);
        }
    }
}
