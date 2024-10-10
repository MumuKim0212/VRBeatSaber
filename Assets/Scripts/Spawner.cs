using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] notes;
    public Transform[] pos;

    public float time = (60 / 130);
    float timer;

    private void Update()
    {
        if (timer > time)
        {
            GameObject note = Instantiate(notes[Random.Range(0, 2)], pos[Random.Range(0, pos.Length)]);
            note.transform.localPosition = Vector3.zero;
            note.transform.Rotate(transform.forward, 90 * Random.Range(0, pos.Length));
            timer -= time;
        }
        timer += Time.deltaTime;
    }
}
