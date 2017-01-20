using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IBarRepresentable
{
    public int currentHP { get; set; }
    public int MaxHP { get; set; }

    HealthBar hBar;

    private void Awake()
    {
        MaxHP = 100;
        currentHP = MaxHP;
    }

    // Use this for initialization
    void Start () {
        hBar = GetComponentInChildren<HealthBar>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage();
        }
	}

    public void TakeDamage(int inputDamage = 10)
    {
        currentHP -= inputDamage;
        hBar.UpdateHealthBarRepresentation();
    }
}
