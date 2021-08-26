using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureCollection : MonoBehaviour
{

    [SerializeField] public int treasureCount;

    [SerializeField] public int winCount;

    public bool youWin;


    // Start is called before the first frame update
    void Start()
    {
        youWin = false;
        treasureCount = 0;
        winCount = 3;
        Debug.Log(treasureCount);      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
