using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureCollection : MonoBehaviour
{

    [SerializeField] public int treasureCount;


    // Start is called before the first frame update
    void Start()
    {
        treasureCount = 0;
        Debug.Log(treasureCount);      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
