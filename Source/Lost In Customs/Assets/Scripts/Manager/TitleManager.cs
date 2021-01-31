using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Credits Panel")] private GameObject credits = null;
    #endregion // Editor Attributes

    #region  UI Methods
    public void PlayGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void ToggleCredits()
    {
        credits.SetActive(!credits.activeSelf);
    }

    public void ShowManual()
    {
        SceneManager.LoadScene("HowToPlayScene");
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
    #endregion // UI Methods    
}
