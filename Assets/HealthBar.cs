using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IBarRepresentable
{
    int currentHP { get; set; }
    int MaxHP { get; set; }
}


public class HealthBar : MonoBehaviour {
    public GameObject healthScript;
    IBarRepresentable Barscript;

    Image img;
    float originalImageSizeDeltaX;

    float percentage = 1f;

    int currentHealth;
    int maximumHealth;

    // Use this for initialization
	void Start () {
        Barscript = healthScript.GetComponent<IBarRepresentable>();

        img = GetComponent<Image>();
        originalImageSizeDeltaX = img.rectTransform.sizeDelta.x;

        
        currentHealth = Barscript.currentHP;
        maximumHealth = Barscript.MaxHP;
    }
	
	// Update is called once per frame
	void Update ()
    {
        

    }


    /// <summary>
    /// Updates the health bar
    /// </summary>
    public void UpdateHealthBarRepresentation()
    {
        currentHealth = Barscript.currentHP;
        maximumHealth = Barscript.MaxHP;
        percentage = (float)currentHealth / (float)maximumHealth; // floatcasting to avoid integer rounding.
        
        if (percentage >= 0f)
        {
            img.rectTransform.sizeDelta = new Vector2(originalImageSizeDeltaX * percentage, img.rectTransform.sizeDelta.y);
        }
    }



}

