using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject tilePrefab;
    public int gridSize = 5; // 5x5 grid
    public Transform gridParent;

    private Tile[,] tiles;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        tiles = new Tile[gridSize, gridSize];
        
        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                GameObject tileObj = Instantiate(tilePrefab, new Vector3(x, y, 0), Quaternion.identity);
                tileObj.transform.SetParent(gridParent);
                Tile tile = tileObj.GetComponent<Tile>();
                bool isWaterTile = Random.value > 0.7f;
                bool isSunlightTile = Random.value > 0.5f;
                bool isRockTile = Random.value > 0.8f;
                tile.Initialize(isWaterTile, isSunlightTile, isRockTile);
                tiles[x, y] = tile;
            }
        }
    }
}
