using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    #region Constants
    private const float DELAY = 1.0f;
    #endregion // Constants

    #region Editor Attributes
    [SerializeField, Tooltip("Damage Amount")] private int damage = 1;
    #endregion // Editor Attributes

    #region Attributes
    private bool _isDamaging = false;
    private float _timeSinceLast = DELAY;
    #endregion // Attributes

    #region MonoBehaviour Methods
    void Update()
    {
        if( GameManager.Instance.IsOver ) return;

        if( !_isDamaging ) return;

        _timeSinceLast += Time.deltaTime;

        if( _timeSinceLast > DELAY)
        {
            GameManager.Instance.TakeDamage(damage);
            _timeSinceLast -= DELAY;
        }
    }



    void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Player" )
        {
            _isDamaging = true;
            _timeSinceLast = 1.0f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if( other.tag == "Player" )
        {
            _isDamaging = false;
        }
    }

    #endregion // MonoBehaviour Methods
}
