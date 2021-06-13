using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{


    public static void NextScene()
    {
        //MoveCounter.ResetMoves();
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
    }

    public static void ReloadScene()
    {
        //MoveCounter.ResetMoves();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void MainScene()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public static void Quit()
    {
        Application.Quit();
    }

    public static void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public static void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public static void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public static void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public static void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public static void Level6()
    {
        SceneManager.LoadScene("Level 6");
    }
    public static void Level7()
    {
        SceneManager.LoadScene("Level 7");
    }
    public static void Level8()
    {
        SceneManager.LoadScene("Level 8");
    }
    public static void Level9()
    {
        SceneManager.LoadScene("Level 9");
    }
    public static void Level10()
    {
        SceneManager.LoadScene("Level 10");
    }
}
