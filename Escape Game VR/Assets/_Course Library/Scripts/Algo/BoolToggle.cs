using UnityEngine;

public class BoolToggle : MonoBehaviour
{
    public bool state = false;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        UpdateColor();
    }

    void OnMouseDown()
    {
        state = !state; // Toggle
        UpdateColor();
        XORManager.Instance.UpdateXOR(); // Recalcul du XOR général
    }

    void UpdateColor()
    {
        if (rend != null)
        {
            rend.material.color = state ? Color.green : Color.red;
        }
    }

    public bool GetState()
    {
        return state;
    }
}
