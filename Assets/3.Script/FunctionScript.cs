using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Tilemaps;

public class FunctionScript : MonoBehaviour
{
    public Tilemap _tilemap;
    public TileBase _TileBase;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            _tilemap.SwapTile(_tilemap.GetTile(Vector3Int.zero), _TileBase);
        }
    }




}

