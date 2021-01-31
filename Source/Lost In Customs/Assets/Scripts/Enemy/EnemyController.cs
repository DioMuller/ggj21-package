using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Enemy Animator")] private Animator animator = null;

    [SerializeField, Tooltip("Character Controller")] private CharacterController controller = null;

    [SerializeField, Tooltip("Stun Time (In Seconds)")] private float stunTime = 10.0f;

    [SerializeField, Tooltip("Enemy Speed")] private float speed = 10;
    #endregion // Editor Attributes

    #region Attributes
    private Vector3? _playerPosition = null;
    #endregion // Attributes

    #region MonoBehaviour Methods
    void Update()
    {
        animator.SetBool("IsMad", GameManager.Instance.HasPackage);    

        if( GameManager.Instance.HasPackage )
        {
            if( _playerPosition is Vector3 position )
            {
                var movement = (position - transform.position).normalized * speed * Time.deltaTime;
                controller.Move(movement);
            }
        }    
    }
    #endregion // MonoBehaviour Methods

    #region Public Methods
    public void Stun()
    {
        animator.SetBool("IsHappy", true);
    }

    public void SetPlayerPosition(Vector3 position)
    {
        _playerPosition = position;
    }

    public void ResetPlayerPosition()
    {
        _playerPosition = null;
    }
    #endregion // Public Methods
}
