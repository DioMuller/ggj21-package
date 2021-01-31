using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region  Singleton
    public static GameManager Instance {get; private set;}
    #endregion // Singleton
    // Start is called before the first frame update

    #region Properties
    public int Health { get; private set; } = 100;
    public int Ammo { get; private set; } = 10;

    public bool HasPackage { get; private set; } = false;
    #endregion // Properties
    
    #region MonoBehaviour Methods
    void Awake() 
    {
        Instance = this;
    }
    #endregion // Monobehaviour Methods

    #region Helper Methods
    public bool TakeDamage(int amount)
    {
        if( Health <= 0 ) return false;

        Health-=amount;
        return Health >= 0;
    }

    public bool UseAmmo()
    {
        if( Ammo <= 0 ) return false;

        Ammo--;
        return true;
    }

    public bool GetPackage()
    {
        if( HasPackage ) return false;

        HasPackage = true;
        return true;
    }

    public bool DropPackage()
    {
        if( !HasPackage ) return false;

        HasPackage = false;
        return true;
    }
    #endregion // Helper Methods
}
