using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToManager : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Plot Panel")] private GameObject plotPanel = null;
    [SerializeField, Tooltip("Controls Panel")] private GameObject controlsPanel = null;
    [SerializeField, Tooltip("Enemies Panel")] private GameObject enemiesPanel = null;
    #endregion // Editor Attributes

    #region  UI Methods
    public void PlayGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void TogglePlot()
    {
        plotPanel.SetActive(true);
        controlsPanel.SetActive(false);
        enemiesPanel.SetActive(false);
    }

    public void ToggleControls()
    {
        plotPanel.SetActive(false);
        controlsPanel.SetActive(true);
        enemiesPanel.SetActive(false);
    }

        public void ToggleEnemies()
    {
        plotPanel.SetActive(false);
        controlsPanel.SetActive(false);
        enemiesPanel.SetActive(true);
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
    #endregion // UI Methods    
}
