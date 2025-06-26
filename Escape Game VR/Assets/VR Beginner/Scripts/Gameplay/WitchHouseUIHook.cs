using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>  
/// This will be picked up automatically by the wrist watch when it gets spawned in the scene by the Interaction toolkit  
/// and setup the buttons and the linked events on the canvas  
/// </summary>  
public class WitchHouseUIHook : WatchScript.IUIHook
{
    public GameObject LeftUILineRenderer;
    public GameObject RightUILineRenderer;
    public GameObject PauseMenu; // Assign it in the Inspector  

    public override void GetHook(WatchScript watch)
    {
        watch.AddButton("Reset", () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); });
        watch.AddButton("Unlock Teleporters", () => { MasterController.Instance.TeleporterParent.SetActive(true); });
        watch.AddButton("Pause", () => { MasterController.Instance.PauseGame(); }); // Fixed CS0120 by using MasterController.Instance
        watch.AddButton("Play", () => { MasterController.Instance.ResumeGame(); });
        watch.AddToggle("Closed Caption", (state) => { CCManager.Instance.gameObject.SetActive(state); });

        LeftUILineRenderer.SetActive(false);
        RightUILineRenderer.SetActive(false);

        watch.UILineRenderer = LeftUILineRenderer;
    }
}
