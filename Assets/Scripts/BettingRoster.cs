using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BettingRoster : MonoBehaviour
{

    public GameObject _playerPairs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is the amount of player pair:" + _playerPairs.transform.childCount);
    }
}
