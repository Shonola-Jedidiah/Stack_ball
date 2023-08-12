using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rings : MonoBehaviour
{
    private player AudioStuff;
    private Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        AudioStuff = FindObjectOfType<player>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > Player.position.y)
        {
            GameManager.no_of_passed_rings++;
            Destroy(gameObject);
            GameManager.score++;
            AudioStuff.WhooshAudio();
        }
    }
}
