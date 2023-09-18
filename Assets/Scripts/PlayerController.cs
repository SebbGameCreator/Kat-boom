using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        int isDia = x * y != 0 ? 0 : 1;
        transform.position += new Vector3(x, y, 0) * isDia * Time.deltaTime * speed;
    }
}
