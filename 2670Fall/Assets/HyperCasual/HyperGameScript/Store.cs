using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{
    public Objects Purchased;
    public Objects Available;

    public void MakePurchase(Object obj)
    {
        foreach (var availableObject in Purchased.ObjectList)
        {
            if (availableObject == obj)
            {
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableObject);
            }
        }
    }
    
}
