using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Plant plantPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.GetComponent<Tile>())
            {
                Tile tile = hit.collider.GetComponent<Tile>();
                Plant newPlant = Instantiate(plantPrefab);
                newPlant.PlantOnTile(tile);
                GameManager.Instance.EndTurn();
            }
        }
    }
}
