using System.Collections;
using UnityEngine;

public class Scroll_Mapping : MonoBehaviour
{
    public float ScrollSpeed = 0.5f;
    private float Target_offset;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Target_offset += Time.deltaTime * ScrollSpeed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Target_offset, 0);
    }
}