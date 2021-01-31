using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Health Label")] private Text healthLabel;
    [SerializeField, Tooltip("Ammo Label")] private Text ammoLabel;

    [SerializeField, Tooltip("Game Over Screen")] private GameObject gameOver;

    [SerializeField, Tooltip("Back to Title Button")] private GameObject backToTitleButton;

    [SerializeField, Tooltip("Level Finished Screen")] private GameObject levelFinished;

    [SerializeField, Tooltip("Next Level Button")] private GameObject nextLevelButton;

    [SerializeField, Tooltip("Event System")] private EventSystem eventSystem;
    #endregion // Editor Attributes

    #region MonoBehaviour Methods
    // Update is called once per frame
    void Update()
    {
        healthLabel.text = Math.Max(0,GameManager.Instance.Health).ToString();
        ammoLabel.text = GameManager.Instance.Ammo.ToString();

        gameOver.SetActive(GameManager.Instance.Health <= 0);

        if( gameOver.activeSelf ) eventSystem.SetSelectedGameObject(backToTitleButton);

        levelFinished.SetActive(GameManager.Instance.LevelEnded);

        if( levelFinished.activeSelf ) eventSystem.SetSelectedGameObject(nextLevelButton);
    }
    #endregion // MonoBehaviour Methods

    #region UI Events
    public void BackToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(GameManager.Instance.NextLevel);
    }
    #endregion // UI Events
}
