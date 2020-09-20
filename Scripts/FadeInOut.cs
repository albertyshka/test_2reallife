using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInOut : MonoBehaviour
{
    public Sprite goodSprite;
    public Sprite badSprite;
    public Sprite excellentSprite;
    public Image catFadeOut;
    public Image catFadeIn;
    public float fadeDeltaTime = 0.1f;
    public float fadeIncrement = 0.1f;

    private IEnumerator fadeInOutCoroutine;
    private bool isFadeInOutRunning = false;

    public void StartFadeInOut(Sprite fadeOut, Sprite fadeIn)
    {
        catFadeIn.sprite = fadeIn;
        catFadeOut.sprite = fadeOut;

        if (isFadeInOutRunning && fadeInOutCoroutine != null)
        {
            StopCoroutine(fadeInOutCoroutine);

            Color tmpIn = catFadeIn.color;
            Color tmpOut = catFadeOut.color;

            tmpIn.a = 1;
            tmpOut.a = 0;

            catFadeIn.color = tmpIn;
            catFadeOut.color = tmpOut;

            isFadeInOutRunning = false;
        }
        else
        {
            fadeInOutCoroutine = FadeInOutCoroutine();
            StartCoroutine(fadeInOutCoroutine);
        }
    }

    private IEnumerator FadeInOutCoroutine()
    {
        isFadeInOutRunning = true;

        Color tmpIn = catFadeIn.color;
        Color tmpOut = catFadeOut.color;

        tmpIn.a = 0;
        tmpOut.a = 1;

        catFadeIn.color = tmpIn;
        catFadeOut.color = tmpOut;

        while (tmpOut.a > 0 && tmpIn.a < 1)
        {
            tmpIn.a += fadeIncrement;
            tmpOut.a -= fadeIncrement;

            catFadeIn.color = tmpIn;
            catFadeOut.color = tmpOut;

            yield return new WaitForSeconds(fadeDeltaTime);
        }

        tmpIn.a = 1;
        tmpOut.a = 0;

        catFadeIn.color = tmpIn;
        catFadeOut.color = tmpOut;

        isFadeInOutRunning = false;
    }
}
