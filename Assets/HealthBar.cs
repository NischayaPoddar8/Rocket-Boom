using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void setHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
}
