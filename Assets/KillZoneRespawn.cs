using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZoneRespawn : MonoBehaviour
{
    [SerializeField]
    private GameObject GoBackTo;
    [SerializeField]
    private float KillZoneLimit;
    
    void Update()
    {
        Vector3 position = transform.position;
        if (position.y < KillZoneLimit)
        {
            Respawn();
        }    
    }

    private void Respawn()
    {
        transform.position = GoBackTo.transform.position;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}