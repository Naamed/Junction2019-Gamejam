using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signalSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int cycleTime = 20;

    void Spawn()
    {
        //randomises positions
        Vector3 position = new Vector3(Random.Range(-50.0f, 50.0f), 1, Random.Range(-50.0f, 50.0f));
        GameObject instObj = Instantiate(prefab, position, Quaternion.identity);
        //checks for the removal
        instObj.GetComponent<TimedRemoval>().DestroyObjectDelayed(cycleTime);
    }

// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, cycleTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
