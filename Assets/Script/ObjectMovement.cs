using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour{

    public float maxSpeed;

    private Vector3 startPosition;

    bool up = true;
    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveVertical();
        Rotation();
    }

    void Rotation()
    {
        transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);
    }

    void MoveVertical()
    {
        var temp = transform.position;
        print(up);
        if (up == true)
        {
            temp.y += maxSpeed * Time.deltaTime;
            transform.position = temp;
            if (transform.position.y >= 1.24f)
            {
                up = false;
            }
        }
        if (up == false)
        {
            temp.y -= maxSpeed * Time.deltaTime;
            transform.position = temp;
            if (transform.position.y <= 1.20f)
            {
                up = true;
            }
        }
    }
}
