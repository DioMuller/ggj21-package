using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    #region Editor Attributes
    [SerializeField, Tooltip("Weapon Animator")] private Animator animator = null;
    #endregion // Editor Attributes

    #region Private Attributes
    public EnemyController _currentEnemy = null;
    #endregion // Private Attributes

    #region MonoBehaviour Methods
    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown("Fire1") )
        {
            animator.SetTrigger("Execute");

            if( _currentEnemy != null)
            {
                _currentEnemy.Stun();
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if( other.tag == "Enemy")
        {
            _currentEnemy = other.gameObject.GetComponent<EnemyController>();
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if( other.tag == "Enemy")
        {
            _currentEnemy = null;
        }
    }
    #endregion // MonoBehaviour Methods
}
