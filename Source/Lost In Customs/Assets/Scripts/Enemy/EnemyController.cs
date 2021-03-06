using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Enemy Animator")] private Animator animator = null;

    [SerializeField, Tooltip("Character Controller")] private CharacterController controller = null;

    [SerializeField, Tooltip("Enemy Damage Object")] private GameObject enemyDamage = null;

    [SerializeField, Tooltip("Enemy Speed")] private float speed = 10;
    
    [SerializeField, Tooltip("Can the enemy be defeated?")] private bool canBeDefeated = true;
    #endregion // Editor Attributes

    #region Attributes
    private Vector3? _playerPosition = null;
    private bool _isHappy = false;
    #endregion // Attributes

    #region  Properties
    public bool IsInactive => _isHappy;
    #endregion // Properties

    #region MonoBehaviour Methods
    void Update()
    {
        if( GameManager.Instance.IsOver ) return;
        if( _isHappy ) return;

        animator.SetBool("IsMad", _playerPosition != null);    

        if( _playerPosition is Vector3 position )
        {
            var movement = (position - transform.position).normalized * speed * Time.deltaTime;
            controller.Move(movement);
        }
    }
    #endregion // MonoBehaviour Methods

    #region Public Methods
    public void Stun()
    {
        if( !canBeDefeated ) return;
        
        _isHappy = true;
        enemyDamage.SetActive(false);
        controller.enabled = false;
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
