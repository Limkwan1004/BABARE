using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectText : MonoBehaviour
{
    private string _tag = "Untagged";

    private void Start()
    {
        
        gameObject.tag= _tag;
    }
}
