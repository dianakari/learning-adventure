using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager obj;

    public Text lives;
    public int maxLives = 3;
    public bool gamePause;
    public Transform UIPanel;

    //public Transform UIGameOver;
    public Transform UIPanelPreg; //variable para la pregunta
    public Transform UIPanelPreg2; //variable para la pregunta
    public Transform UIPanelPreg3; //variable para la pregunta
                                   // public Transform UIPanelPreg4; //variable para la pregunta





    void Awake()
    {
        obj = this;
    }

    void Start()
    {
        gamePause = false;
        startGame();
        UIPanelPreg.gameObject.SetActive(false);
        UIPanelPreg2.gameObject.SetActive(false);
        UIPanelPreg3.gameObject.SetActive(false);
    }




    public void updateLives()
    {
        lives.text = "" + Submarino.obj.lives;
    }

    public void startGame()
    {

        gamePause = true;
        UIPanel.gameObject.SetActive(true);

        //UIPanel.gameObject.SetActive(true);
        //  UIInicar.gameObject.SetActive(false);
        /*UIPanelPreg.gameObject.SetActive(false); //para la pregunta
        UIPanelPreg2.gameObject.SetActive(false); //para la pregunta
        UIPanelPreg3.gameObject.SetActive(false); //para la pregunta
       // UIPanelPreg4.gameObject.SetActive(false); //para la pregunta*/
    }

    public void hideInitPanel()
    {
        gamePause = false;
        UIPanel.gameObject.SetActive(false);
    }

    public void RestartLever()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // private void OneDestroy()
    // {
    //    obj = null;
    // }

    public void hidePanelPreg()
    {
        UIPanelPreg.gameObject.SetActive(true);
        gamePause = true;
    }

    public void hidePanelPreg2()
    {
        UIPanelPreg2.gameObject.SetActive(true);
        gamePause = true;
    }

    public void hidePanelPreg3()
    {
        UIPanelPreg3.gameObject.SetActive(true);
        gamePause = true;
    }


    //public void hidePanelPreg4()
    //{
    //    UIPanelPreg4.gameObject.SetActive(true);
    //    gamePause = true;
    //}

    public void RInco()
    {

    }

    //public void RInco2()
    //{

    //}

    public void RCorr()
    {
        //AudioController.obj.playGood();
        gamePause = false;
        UIPanelPreg.gameObject.SetActive(false);
        UIPanelPreg2.gameObject.SetActive(false);
        UIPanelPreg3.gameObject.SetActive(false);
        // UIPanelPreg4.gameObject.SetActive(false);
    }


}