using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedRemoval : MonoBehaviour
{
    public void DestroyObjectDelayed(int aliveTime)
    {
        // Kills the game object in X seconds after loading the object
        Destroy(gameObject, aliveTime);
    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
       //Same basic logic can be used here, just with additional inputs before triggering the deletion 
    }
}
