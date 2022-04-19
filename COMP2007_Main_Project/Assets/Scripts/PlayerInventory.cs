using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int numberOfCollectables { get; private set; }

    //public UnityEvent<PlayerInventory> OnCollected;

    public void Collected()
    {
        numberOfCollectables++;
        //OnCollected.Invoke(this);
    }

}
