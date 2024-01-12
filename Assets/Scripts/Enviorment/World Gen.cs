using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldGen : MonoBehaviour
{
    [Header("Settings")]
    public int SizeOfMap;

    [Header("Refrences")]
    public Tilemap map;
    public GameObject Forest;

    [Header("Tiles")]
    public Tile Grass;

    void Start() {
        for(int i = 0; i < SizeOfMap; i++) {
            for (int j = 0; j < SizeOfMap; j++) {
                Vector3Int tilePosition = new Vector3Int(-i, -j, 0) + new Vector3Int(SizeOfMap/2 ,SizeOfMap/2,0);
                map.SetTile(tilePosition, Grass);
            }
        }

        for(int i = 0; i < Random.Range(2,4); i++) {
            Instantiate(Forest, new Vector3(Random.Range(-SizeOfMap/2 * 0.7f, SizeOfMap/2 * 0.7f), Random.Range(-SizeOfMap/2 * 0.7f, SizeOfMap/2 * 0.7f), 0), Quaternion.identity);
        }
    }
}