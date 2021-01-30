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
                StartCoroutine(nameof(HitEnemy));
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

    #region Coroutines
    IEnumerator HitEnemy()
    {
        if( _currentEnemy != null )
        {
            var enemy = _currentEnemy;
            yield return new WaitForSeconds(1);
            enemy.Stun();
        }
    }
    #endregion // Coroutines
}
