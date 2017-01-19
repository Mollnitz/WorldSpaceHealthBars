using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int currentHP;
    public int MaxHP = 100;

    HealthBar hBar;

    private void Awake()
    {

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
