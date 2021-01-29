using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Player Look Sensivity")] 
    private float sensitivity = 150;

    [SerializeField, Tooltip("Player Up/Down angle limit")] 
    private float lookLimit = 45;
    
    [SerializeField, Tooltip("Camera Game Object")] 
    private Transform cameraTransform = null;
    #endregion // Editor Attributes

    #region Private Attributes
    private float _rotationX;
    #endregion // Private Attributes

    #region MonoBehaviour Methods

    private void Awake()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        float lx = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float ly = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        _rotationX = Mathf.Clamp(_rotationX - ly, -lookLimit, lookLimit);

        cameraTransform.localRotation = Quaternion.Euler(_rotationX, 0f,0f);
        transform.Rotate(Vector2.up * lx);
    }
    #endregion // MonoBehaviour Methods
}
