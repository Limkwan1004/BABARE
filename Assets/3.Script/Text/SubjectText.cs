using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SubjectText : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private TileBase _tileBase;

    private void SubjectActive()
    {
        _tileBase.GetComponent<SpriteRenderer>();
    }

}
