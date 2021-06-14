using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBasket : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
    }
}
