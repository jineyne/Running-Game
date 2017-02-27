using System.Collections;
using UnityEngine;

public class Block_Loop : MonoBehaviour
{
    public float Speed = 3;

    public GameObject Block;
    public GameObject A_ZONE;
    public GameObject B_ZONE;

    private void Move()
    {
        A_ZONE.transform.Translate(Vector3.left * Speed * Time.deltaTime);
        B_ZONE.transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if (B_ZONE.transform.position.x <= 0)
        {
            Destroy(A_ZONE);
            A_ZONE = B_ZONE;
            Make();
        }
    }

    private void Make()
    {
        /*B_ZONE = Instantiate(Block, new Vector3(30, -5, 0), transform.rotation) as GameObject;*/
        B_ZONE = Instantiate(Block, new Vector3(A_ZONE.transform.position.x + 30, -5, 0), transform.rotation) as GameObject;
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }
}