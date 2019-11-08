using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public void Spawn()
    {
        transform.position = LevelManager.Instance.BluePortal.transform.position;
    }
}
