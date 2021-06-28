using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectEggGreen2 : MonoBehaviour
{
   public GameObject Door;
    public float y=5;
    public float x=5;
    public float z=5;
    private bool isCollected = false;
    void OnTriggerEnter(Collider other) 
    {
        if (!isCollected)
        {
            Door.gameObject.transform.position = new Vector3(x, y, z);
            ScoringSystem.theScore += 1;
            Debug.Log(gameObject.name + " + 1" + other.name);
            Destroy(gameObject);
            isCollected = true;
        }
    }
}
