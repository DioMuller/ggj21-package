using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    #region Editor Attributes
    [SerializeField, Tooltip("Weapon Animator")] private Animator animator = null;
    [SerializeField, Tooltip("Weapon Collider")] private WeaponCollider weaponCollider = null;
    [SerializeField, Tooltip("Money Particle System")] private ParticleSystem particles = null;
    #endregion // Editor Attributes

    #region Private Attributes
    private bool _isActive = false;
    #endregion // Private Attributes

    #region MonoBehaviour Methods
    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown("Fire1") && !_isActive )
        {
            if( GameManager.Instance.UseAmmo() )
            {
                _isActive = true;
                animator.SetTrigger("Execute");
                particles.Play();
                StartCoroutine(nameof(ActivateCollider));
            }
        }
    }

    #endregion // MonoBehaviour Methods

    #region Coroutines
    IEnumerator ActivateCollider()
    {
        weaponCollider.Activate(true);
        yield return new WaitForFixedUpdate();
        weaponCollider.Activate(false);
        _isActive = false;
    }
    #endregion // Coroutines
}
