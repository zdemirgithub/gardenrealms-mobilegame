using UnityEngine;

public class Plant : MonoBehaviour
{
    public string plantName;
    public int growthValue;
    public bool isPlanted = false;

    public void PlantOnTile(Tile tile)
    {
        if (!tile.isOccupied)
        {
            tile.PlaceObject(gameObject);
            isPlanted = true;
            // Add growth value based on the tile properties
            CalculateGrowth(tile);
        }
    }

    void CalculateGrowth(Tile tile)
    {
        // Example: Grow faster on sunlight tiles, slow down on rock tiles, etc.
        if (tile.isSunlight)
            growthValue += 10;
        if (tile.isWater)
            growthValue += 5;
        if (tile.isRock)
            growthValue -= 5;

        GameManager.Instance.AddScore(growthValue);
    }
}
