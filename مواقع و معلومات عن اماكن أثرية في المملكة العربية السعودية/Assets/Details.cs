using UnityEngine;

public class ToggleDetails : MonoBehaviour
{
    public GameObject details;

    public void Toggle()
    {
        details.SetActive(!details.activeSelf);
    }
}