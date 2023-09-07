using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool right;
    // Start is called before the first frame update
    void Start()
    {
        if (!right) transform.Rotate(Vector3.forward * 180);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed, Space.Self);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        DirectionalNode dn = other.GetComponent<DirectionalNode>();
        Debug.Log(dn.current);
        float rot = 90;
        Vector3 dir = Vector3.zero;
        if (dn.current == "right") dir = Vector3.back;
        if (dn.current == "left") dir = Vector3.forward;
        transform.position = other.transform.position;
        transform.Rotate(dir * rot);
    }
}
