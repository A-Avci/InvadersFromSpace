using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

[System.Serializable]
public class ShipStats : MonoBehaviour
{
    [Range(1, 5)]
    public int maxHealth;
    [HideInInspector] public int currentHealth;
    [HideInInspector] public int maxLifes = 3;
    [HideInInspector] public int currentLifes = 3;

    public float shipSpeed;
    public float fireRate;
}
