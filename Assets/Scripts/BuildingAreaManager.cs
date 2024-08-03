using DefaultNamespace;
using UnityEngine;

public class BuildingAreaManager : SingleTon<BuildingAreaManager>
{
    [SerializeField] private Trade trade;

    [SerializeField] private Village village;

    [SerializeField] private GrassLand grassLand;

    private void Awake()
    {
        trade = FindObjectOfType<Trade>();
        village = FindObjectOfType<Village>();
        grassLand = FindObjectOfType<GrassLand>();
    }

    public GrassLand GetGrassLand()
    {
        if (grassLand) return grassLand;

        Debug.LogError("GrassLand building not found or not manager is not awake");
        return null;
    }

    public Trade GetTrade()
    {
        if (trade) return trade;

        Debug.LogError("Trade building not found or not manager is not awake");
        return null;
    }

    public Village GetVillage()
    {
        if (village) return village;

        Debug.LogError("Village building not found or not manager is not awake");
        return null;
    }
}