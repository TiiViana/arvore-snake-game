using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetDatabase : MonoBehaviour
{
    public static AssetDatabase instance;

    // Assrt list
    public Sprite snakeHeadGreen;

    void Awake()
    {
        instance = this;
    }
}