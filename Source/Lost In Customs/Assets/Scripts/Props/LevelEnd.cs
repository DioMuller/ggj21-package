using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    #region MonoBehaviour Methods
    void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Player" && GameManager.Instance.HasPackage )
        {
            GameManager.Instance.FinishLevel();
        }
    }
    #endregion // MonoBehaviour Methods
}
