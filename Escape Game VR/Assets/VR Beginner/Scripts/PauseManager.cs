using UnityEngine;
using UnityEngine.InputSystem;

public class VRPauseManager : MonoBehaviour
{
    public InputActionReference pauseAction; // Référence à l'action "Pause"
    public GameObject pauseMenuUI;

    private bool isPaused = false;

    void OnEnable()
    {
        pauseAction.action.performed += OnPausePressed;
        pauseAction.action.Enable();
    }

    void OnDisable()
    {
        pauseAction.action.performed -= OnPausePressed;
        pauseAction.action.Disable();
    }

    void OnPausePressed(InputAction.CallbackContext context)
    {
        TogglePause();
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(true);
    }

    void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);
    }
}
