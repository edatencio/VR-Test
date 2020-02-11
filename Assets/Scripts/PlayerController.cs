using UnityEngine;
using NaughtyAttributes;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
