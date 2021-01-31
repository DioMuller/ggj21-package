using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Enemy Controller")] private EnemyController controller = null;

    [SerializeField, Tooltip("Random Audio Player")] private RandomAudioPlayer player = null;

    #endregion // Editor Attributes

    #region Attributes
    private Transform _playerTransform;
    #endregion // Attributes

    #region MonoBehaviour Methods
    void Update()
    {
        if( _playerTransform != null )
        {
            controller.SetPlayerPosition(_playerTransform.position);
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if( other.tag == "Player")
        {
            _playerTransform = other.transform;
            if( !controller.IsInactive ) player.PlayAudio();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if ( other.tag == "Player" )
        {
            _playerTransform = null;
            controller.ResetPlayerPosition();
        }
    }
    #endregion // MonoBehaviour Methods
}
