using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Mood
{
    EXCELLENT, ANGRY, GOOD
}

public class EmmitParticles : MonoBehaviour
{
    public ParticleSystem happyParticles;
    public ParticleSystem angryParticles;
    public float stopTime = 5f;

    public void StartEmmitParticles(Mood mood)
    {
        StartCoroutine(ParticleCoroutine(mood));
    }

    private IEnumerator ParticleCoroutine(Mood mood)
    {
        if (mood == Mood.EXCELLENT)
        {
            happyParticles.Play();
            yield return new WaitForSeconds(stopTime);
            happyParticles.Stop();
        }
        else
        {
            angryParticles.Play();
            yield return new WaitForSeconds(stopTime);
            angryParticles.Stop();
        }
    }
}
