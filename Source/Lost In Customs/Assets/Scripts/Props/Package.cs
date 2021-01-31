using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{

    #region MonoBehaviour Methods
    // Update is called once per frame
    private void OnTriggerEnter(Collider other) 
    {
        if( other.tag == "Player")
        {
            if( GameManager.Instance.GetPackage() )
            {
                Destroy(gameObject);
            }
        }
    }
    #endregion // MonoBehaviour Methods
}
