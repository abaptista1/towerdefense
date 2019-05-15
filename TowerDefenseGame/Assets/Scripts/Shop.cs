using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret ()
    {
        Debug.Log("standard purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);

    }

    public void PurchaseMissileLauncher()
    {
        Debug.Log("Missile launcher purchased");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }
}
