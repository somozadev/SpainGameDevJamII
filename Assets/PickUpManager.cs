using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{

    public Player player;
    public GameObject hand;

    void Start()
    {
        //player.pickUpToolEvent += OnPickUpTool;
    }
    
    void OnPickUpTool(GameObject tool)
    {
        tool.GetComponent<BoxCollider>().enabled = false;
        tool.GetComponent<Rigidbody>().isKinematic = true;

        tool.transform.parent = hand.transform;
        tool.transform.localPosition = new Vector3(0, 0, 0.5f);
        tool.transform.localRotation = Quaternion.identity;
    }
        
}
