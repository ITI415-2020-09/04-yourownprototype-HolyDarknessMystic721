using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    private PlayerController    pc;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;

        pc = player.GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position - pc.currentDirection * offset.magnitude;
        this.gameObject.transform.LookAt(player.transform);

    }
}
