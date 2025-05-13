using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool isOccupied = false;
    public bool isWater = false;
    public bool isSunlight = false;
    public bool isRock = false;

    public void Initialize(bool isWaterTile, bool isSunlightTile, bool isRockTile)
    {
        isWater = isWaterTile;
        isSunlight = isSunlightTile;
        isRock = isRockTile;
    }

    public void PlaceObject(GameObject plantObject)
    {
        isOccupied = true;
        plantObject.transform.position = transform.position;
    }
}
