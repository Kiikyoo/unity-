using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    public float Height;

    private void Awake()
    {
        Height = transform.position.y;
    }
    private void LateUpdate()
    {
        Vector3 playerPos = PlayerController.INSTANCE.playerModel.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y + Height, playerPos.z);
    }
}
