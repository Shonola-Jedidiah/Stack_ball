using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    private Rigidbody PlayerRB;
    public float Bounce_forcce;

    public AudioSource AudioManager;
    public AudioClip Bounce;
    public AudioClip GameOver;
    public AudioClip LvlCompleted;
    public AudioClip Whoosh;


    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        PlayerRB.velocity = new Vector3(PlayerRB.velocity.x, Bounce_forcce, PlayerRB.velocity.z);

        string Material_Name = collision.transform.gameObject.GetComponent<MeshRenderer>().material.name;


        if (Material_Name == "Safe (Instance)")

        {

            if (GameManager.mute)
            {
                AudioManager.PlayOneShot(Bounce);
            }

        }
        else if (Material_Name == "UnSafe (Instance)")
        {
            GameManager.gameOver = true;
            if (GameManager.mute)
            {
                AudioManager.PlayOneShot(GameOver);
            }

        }
        else if (Material_Name == "LastManMat (Instance)")
        {
            Time.timeScale = 0;
            GameManager.lvlCompleted = true;
            if (GameManager.mute)
            {
                AudioManager.PlayOneShot(LvlCompleted);
            }

        }

    }
    public void WhooshAudio()
    {
        if (GameManager.mute)
        {
            AudioManager.PlayOneShot(Whoosh);
        }

    }
}
