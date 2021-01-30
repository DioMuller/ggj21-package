using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollider : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Player Collider Instance")] private Collider collider = null;
    #endregion // Editor Attributes

    #region MonoBehaviour Methods
    // Update is called once per frame
    private void OnTriggerEnter(Collider other) 
    {
        if( other.tag == "Enemy")
        {
            var enemy = other.gameObject.GetComponent<EnemyController>();
            StartCoroutine(nameof(HitEnemy), enemy);
        }
    }
    #endregion // MonoBehaviour Methods

    #region Helper Methods
    public void Activate(bool active)
    {
        collider.enabled = active;
    }
    #endregion // Helper Methods

    #region Coroutines
    IEnumerator HitEnemy(EnemyController enemy)
    {
        if( enemy != null )
        {
            yield return new WaitForSeconds(0.2f);
            enemy.Stun();
        }
    }
    #endregion // Coroutines
}
