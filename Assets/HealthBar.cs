using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour {
    Image img;
    float originalImageSizeDeltaX;

    float originalAnchoredPositionX;

    float percentage = 1f;

    [SerializeField] private int currentHealth = 100;
    [SerializeField] private int maximumHealth = 100;

    public bool EnableAlignmentCorrection = true;

    // Use this for initialization
	void Start () {
        img = GetComponent<Image>();
        originalImageSizeDeltaX = img.rectTransform.sizeDelta.x;

        //Not needed right now, as it is always zero, but this should prevent some future issues!
        originalAnchoredPositionX = img.rectTransform.anchoredPosition.x;
    }

    public void SetHealth(int health)
    {
        currentHealth = Mathf.Clamp(health, 0, maximumHealth);
        UpdateHealthBarRepresentation();
    }

    public void SetMaxHealth(int maxHealth)
    {
        maximumHealth = maxHealth;
        currentHealth = Mathf.Min(maxHealth, currentHealth);
        UpdateHealthBarRepresentation();
    }

    /// <summary>
    /// Updates the health bar
    /// </summary>
    private void UpdateHealthBarRepresentation()
    {
        percentage = (float)currentHealth / (float)maximumHealth; // floatcasting to avoid integer rounding.
        
        if (percentage >= 0f)
        {
            CorrectBarSize();

            //Assures correct alignment
            if (EnableAlignmentCorrection) CorrectAlignment();
        }
    }

    private void CorrectBarSize()
    {
        img.rectTransform.sizeDelta = new Vector2(originalImageSizeDeltaX * percentage, img.rectTransform.sizeDelta.y);
    }

    private void CorrectAlignment()
    {
        img.rectTransform.anchoredPosition = new Vector3((originalAnchoredPositionX + (maximumHealth - currentHealth) * (img.rectTransform.localScale.x / 2f)), 0f);
    }
}

