using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
        #region Editor Attributes
    [SerializeField, Tooltip("Damage Amount")] private int damage = 1;
    #endregion // Editor Attributes

    #region Attributes
    private bool _isDamaging = false;
    private float _timeSinceLast = 1.0f;
    #endregion // Attributes

    #region MonoBehaviour Methods
    void Update()
    {
        if( !_isDamaging || !GameManager.Instance.HasPackage ) return;

        _timeSinceLast += Time.deltaTime;

        if( _timeSinceLast > 1.0f)
        {
            GameManager.Instance.TakeDamage(damage);
            _timeSinceLast -= 1.0f;
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
