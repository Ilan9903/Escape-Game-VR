using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalMenu : MonoBehaviour
{

    [SerializeField] GameObject modalMenu; // Reference to the modal menu GameObject
    // Start is called before the first frame update



    void OpenModal()
    {
        // Logic to open the modal menu
        Debug.Log("Modal menu opened.");
        PauseGame(); // Pause the game when opening the modal
        modalMenu.SetActive(true); // Activate the modal menu GameObject
    }

    void CloseModal()
    {
        // Logic to close the modal menu
        Debug.Log("Modal menu closed.");
        ResumeGame(); // Resume the game when closing the modal
        modalMenu.SetActive(false); // Deactivate the modal menu GameObject
    }
    
    void PauseGame()
    {
        // Logic to pause the game
        Debug.Log("Game paused.");
        Time.timeScale = 0; // Pauses the game
    }

    void ResumeGame()
    {
        // Logic to resume the game
        Debug.Log("Game resumed.");
        Time.timeScale = 1; // Resumes the game
    }
}
