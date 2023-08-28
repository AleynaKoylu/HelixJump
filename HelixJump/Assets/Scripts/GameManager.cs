using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Grounds = new List<GameObject>();

    [SerializeField]
    GameObject Ball;

    public Vector3 gTransform;

    Grounds grounds;

    [SerializeField]
    TextMeshProUGUI ScoreTxt;
     int score;

    [SerializeField]
    GameObject pauseMenu, pauseButton,dieMenu,startMenu;
    void Start()
    {
        ScoreTxt.text = score.ToString();
        Time.timeScale = 0;
    }



    void Update()
    {
        foreach (var g in Grounds)
        {
            gTransform = g.transform.position;
            if (g.activeSelf == false)
            {
                grounds = g.GetComponent<Grounds>();
                grounds.ChangeTransform();
                g.SetActive(true);
            }
        }

        
    }
    public void Score()
    {
        score += 10;
        ScoreTxt.text = score.ToString();
        ReturnScore();
    }
    int ReturnScore()
    {
        return score;
    }
     public void StartBtn(GameObject strt)
    {
        strt.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }
    public void PlayButton()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        
        Time.timeScale = 1;
    }
  
    public void QuitBtn()
    {
        Application.Quit();
    }
    public void PauseBtn()
    {
        pauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void ExitBtn(GameObject mainmenu)
    {
        Time.timeScale = 0;
        startMenu.SetActive(true);
        mainmenu.SetActive(false);

    }
    public void restart()
    {
        
        SceneManager.LoadScene(0);
        
        
    }
}

