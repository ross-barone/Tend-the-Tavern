using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    //List of all customers currently in scene
    [SerializeField] List<CustomerInfo> customers = new List<CustomerInfo>();

    //Customer prefab to be spawned from
    [SerializeField] GameObject customerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
