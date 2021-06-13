using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject menu;
    public GameObject levels;
    public GameObject about;

    public void showLevels()
    {
        menu.SetActive(false);
        levels.SetActive(true);
    }

    public void showMenu()
    {
        about.SetActive(false);
        levels.SetActive(false);
        menu.SetActive(true);
    }

    public void ShowAbout()
    {
        menu.SetActive(false);
        about.SetActive(true);
    }
}
