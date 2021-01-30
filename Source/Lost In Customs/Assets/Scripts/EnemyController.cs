using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Enemy Animator")] private Animator animator = null;

    [SerializeField, Tooltip("Stun Time (In Seconds)")] private float stunTime = 10.0f;
    #endregion // Editor Attributes

    #region Public Methods
    public void Stun()
    {
        animator.SetBool("IsHappy", true);
    }
    #endregion // Public Methods
}
