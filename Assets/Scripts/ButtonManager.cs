using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
      public void Level1Btn(string MazeGameLevel1)
    {
        SceneManager.LoadScene(MazeGameLevel1);
    }

    public void Level2Btn(string MazeGameLevel2)
    {
        SceneManager.LoadScene(MazeGameLevel2);
    }

    public void ExitGaneBtn()
    {
        Application.Quit();
    }

 }
