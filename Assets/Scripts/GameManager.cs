using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool lvlCompleted;
    public static bool mute = true;
    public static int currentLevelIndex;
    public static int no_of_passed_rings;
    public static bool isGameStarted;
    public static int score = 0;


    public GameObject GameOverPanel;
    public GameObject LevelCompletedPanel;
    public GameObject gameProgPanel;
    public GameObject startMenuPanel;


    public TextMeshProUGUI CurrentLevelText;
    public TextMeshProUGUI NextLevelText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighScoreText;
    public Slider Progress_Bar;



    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
        currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex", 1);
    }

    void Start()
    {
        HighScoreText.text = "HighSCore\n" + PlayerPrefs.GetInt("HighScore", 0);
        isGameStarted = false;
        no_of_passed_rings = 0;
        gameProgPanel.SetActive(false);
        Time.timeScale = 1;
        gameOver = false;
        lvlCompleted = false;

    }

    // Update is called once per frame
    void Update()
    {



        CurrentLevelText.text = currentLevelIndex.ToString();
        NextLevelText.text = (currentLevelIndex + 1).ToString();
        int prog_bar_value = no_of_passed_rings * 100 / FindObjectOfType<Helix_Manager>().No_of_Rings;
        Progress_Bar.value = prog_bar_value;

        ScoreText.text = score.ToString();


        //Start Game
        if (Input.GetMouseButtonDown(0) && !isGameStarted)
        {
            if (EventSystem.current.IsPointerOverGameObject())

                return;

            startMenuPanel.SetActive(false);
            gameProgPanel.SetActive(true);
        }

        //GameOver
        if (gameOver)
        {
            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
          Time.timeScale = 0;
            GameOverPanel.SetActive(true);

           // Debug.Log(Input.mousePresent.ToString() + "First");

            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {

               // Debug.Log(Input.mousePresent.ToString() + "Second");

               // Debug.Log("WHyaintyouworking");
                score = 0;
                SceneManager.LoadScene("Level");

            }

        }

      



        if (lvlCompleted)
        {
            LevelCompletedPanel.SetActive(true);
            if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.SetInt("CurrentLevelIndex", currentLevelIndex + 1);
                SceneManager.LoadScene("Level");
            }
        }

    }
    /* public void Click2Continue()
     {
         //Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began
         //Input .GetTouch(0).fingerId
     }*/

  /*  public void GameOverReload()
    {
        Debug.Log("jgdfv bgrjvl; etcgy");
    }*/
}
