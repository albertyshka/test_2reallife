using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootUIManager : Singleton<BootUIManager>
{
    [SerializeField] private MainMenu mainMenu;
    [SerializeField] private Camera dummyCamera;
    private bool firstTimeFlag = false;

    private void Update()
    {
        if (!firstTimeFlag && Input.GetMouseButtonDown(0))
        {
            mainMenu.FadeOut();
            firstTimeFlag = true;
        }
    }

    public void FadeOut()
    {
        mainMenu.FadeOut();
    }

    public void SetDummyCameraActive(bool active)
    {
        dummyCamera.gameObject.SetActive(active);
    }
}
