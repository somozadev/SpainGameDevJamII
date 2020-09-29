using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObjectsManager : MonoBehaviour
{
    public GameObject prefab;
    public float timeLeftToSpawn;
    public List<Transform> spawningPos;
    public List<int> times;
    public float force;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeftToSpawn -= Time.deltaTime;
        if(timeLeftToSpawn<=0)
        {
            timeLeftToSpawn = times[Random.Range(0, times.Count)];
            GameObject aux = Instantiate(prefab, spawningPos[Random.Range(0, spawningPos.Count)].position,Quaternion.identity);
            aux.transform.Rotate(new Vector3(-90, 0, -90));
            aux.GetComponent<Rigidbody>().AddForce(Vector3.down * force,ForceMode.Impulse);
        }
        
    }
}
