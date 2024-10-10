using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;
    }
}
