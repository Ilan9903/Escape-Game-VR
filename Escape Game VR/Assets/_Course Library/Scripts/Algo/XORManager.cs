using UnityEngine;

public class XORManager : MonoBehaviour
{
    public static XORManager Instance;

    public BoolToggle[] boolToggles;

    void Awake()
    {
        Instance = this;
    }

    public void UpdateXOR()
    {
        bool xor = false;
        foreach (var toggle in boolToggles)
        {
            xor ^= toggle.GetState(); // XOR logique
        }

        Debug.Log("Résultat du XOR global : " + xor);
    }
}
