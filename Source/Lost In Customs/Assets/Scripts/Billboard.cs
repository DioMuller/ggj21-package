using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    #region Editor Attributes  
    [SerializeField, Tooltip("Camera Game Object")] 
    private Transform sprite = null;
    #endregion // Editor Attributes

    #region Private Attributes
    private Camera _camera;
    #endregion // Private Attributes

    void Awake()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        sprite.LookAt(sprite.position + _camera.transform.rotation * Vector3.forward, _camera.transform.rotation * Vector3.up);
        
        Vector3 eulerAngles = sprite.eulerAngles;
        eulerAngles.z = 0;
        sprite.eulerAngles = eulerAngles;            
    }
}
