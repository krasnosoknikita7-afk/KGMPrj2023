using UnityEngine;
using UnityEngine.SceneManagement;

public class DesktopBootstrap : MonoBehaviour
{
    void Start()
    {
        Debug.Log("DesktopBase started. Loading Edit Mode GUI and clearing loading screens...");

        // Load the Edit Mode GUI scene additively
        SceneManager.LoadScene("DesktopEditModeGUI", LoadSceneMode.Additive);

        // Find and disable loading screens in the base scene
        GameObject[] rootObjects = gameObject.scene.GetRootGameObjects();
        foreach (var obj in rootObjects)
        {
            if (obj.name.ToLower().Contains("load") || obj.name.ToLower().Contains("splash"))
            {
                Debug.Log($"Disabling loading screen object: {obj.name}");
                obj.SetActive(false);
            }
        }

        // Listen for when the additive scene finishes loading
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "DesktopEditModeGUI")
        {
            Debug.Log("DesktopEditModeGUI loaded. Setting as active scene and activating objects...");
            SceneManager.SetActiveScene(scene);

            foreach (var obj in scene.GetRootGameObjects())
            {
                obj.SetActive(true);
            }
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}