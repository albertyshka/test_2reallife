using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // проигрывать анимацию
    // функции, которые получают события анимаций

    [SerializeField] private Animation mainMenuAnimator;
    [SerializeField] private AnimationClip fadeOutAnimation;
    [SerializeField] private AnimationClip fadeInAnimation;

    // эти функции вызываются с помощью AnimationEvent в анимациях fadeIn/fadeOut
    public void OnFadeOutComplete()
    {
        Debug.LogWarning("FadeOut Complete");
    }

    public void OnFadeInComplete()
    {
        Debug.LogWarning("FadeIn Complete");

        BootUIManager.Instance.SetDummyCameraActive(false);
    }

    public void FadeIn()
    {
        mainMenuAnimator.Stop();
        mainMenuAnimator.clip = fadeInAnimation;
        mainMenuAnimator.Play();
    }

    public void FadeOut()
    {
        BootUIManager.Instance.SetDummyCameraActive(false);

        mainMenuAnimator.Stop();
        mainMenuAnimator.clip = fadeOutAnimation;
        mainMenuAnimator.Play();
    }
}
