using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helix_Manager : MonoBehaviour
{
    public GameObject[] HelixRings;
    private float ySpawn = 0;
    public int RingDistance = 5;





    public int No_of_Rings;
    void Start()
    {
        No_of_Rings = GameManager.currentLevelIndex + 8;
        RingSpawn(0);
        for (int i = 0; i < No_of_Rings; i++)
        {
            RingSpawn(Random.Range(1, HelixRings.Length - 1));
        }
        RingSpawn(HelixRings.Length - 1);
    }


    void Update()
    {

    }


    public void RingSpawn(int RingIndex)
    {
        GameObject Generated_Rings = Instantiate(HelixRings[RingIndex], transform.up * ySpawn, Quaternion.identity);
        Generated_Rings.transform.parent = transform;
        ySpawn -= RingDistance;
    }

}
