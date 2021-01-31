using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Player Speed")] private float speed = 10;
    #endregion // Editor Attributes

    #region Components
    private CharacterController _controller = null;
    #endregion // Components

    #region MonoBehaviour Methods
    void Awake()
    {
        _controller = GetComponent<CharacterController>();                
    }

    void Update()
    {
        if( GameManager.Instance.IsOver ) return;

        float mx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float my = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        var movement = transform.right * mx + transform.forward * my;

        _controller.Move(movement);
    }
    #endregion // MonoBehaviour Methods
}
