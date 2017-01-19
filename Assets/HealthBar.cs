using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    public Health healthScript;
    Image img;
    float originalImageScale;

    float percentage = 1f;

    int currentHealth;
    int maximumHealth;

    // Use this for initialization
	void Start () {
        img = GetComponent<Image>();
        originalImageScale = img.rectTransform.sizeDelta.x;


        healthScript = GetComponentInParent<Health>();
        currentHealth = healthScript.currentHP;
        maximumHealth = healthScript.MaxHP;
    }
	
	// Update is called once per frame
	void Update ()
    {
        

    }

    public void UpdateHealthBarRepresentation()
    {
        currentHealth = healthScript.currentHP;
        maximumHealth = healthScript.MaxHP;
        percentage = (float)currentHealth / (float)maximumHealth;
        
        if (percentage >= 0f)
        {
            img.rectTransform.sizeDelta = new Vector2(originalImageScale * percentage, img.rectTransform.sizeDelta.y);
        }
    }



}
