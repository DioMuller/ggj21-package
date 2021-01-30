using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Health Label")] private Text healthLabel;
    [SerializeField, Tooltip("Ammo Label")] private Text ammoLabel;
    #endregion // Editor Attributes

    #region MonoBehaviour Methods
    // Update is called once per frame
    void Update()
    {
        healthLabel.text = GameManager.Instance.Health.ToString();
        ammoLabel.text = GameManager.Instance.Ammo.ToString();
    }
    #endregion // MonoBehaviour Methods
}