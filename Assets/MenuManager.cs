using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    public GameObject creditsMenu;
    public GameObject musicManager;

    public void Start()
    {
        // Initially disable the credits menu
        creditsMenu.SetActive(false);
    }

    public void ShowCredits()
    {
        // Enable credits menu and disable music manager
        creditsMenu.SetActive(true);
        musicManager.SetActive(false);

    }

    public void GoBack()
    {
        // Disable credits menu and enable music manager
        creditsMenu.SetActive(false);
        musicManager.SetActive(true);
    }
}