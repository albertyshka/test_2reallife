using UnityEngine;
using UnityEngine.UI;

public class IndicateMood : MonoBehaviour
{
    [SerializeField] private Image currentMoodImage;
    [SerializeField] private Image newMoodImage;
    [SerializeField] private Sprite goodMoodSprite;
    [SerializeField] private Sprite badMoodSprite;
    [SerializeField] private Sprite excellentMoodSprite;

    private Animation currentMoodAnimation;
    private Animation newMoodAnimation;

    private void Start()
    {
        currentMoodAnimation = currentMoodImage.gameObject.GetComponent<Animation>();
        newMoodAnimation = newMoodImage.gameObject.GetComponent<Animation>();
    }

    private void Update()
    {
        if (!currentMoodAnimation.isPlaying)
        {
            currentMoodImage.sprite = newMoodImage.sprite;
        }
    }

    public void ChangeMood(Mood newMood)
    {
        switch (newMood)
        {
            case Mood.EXCELLENT:
                newMoodImage.sprite = excellentMoodSprite;
                break;

            case Mood.GOOD:
                newMoodImage.sprite = goodMoodSprite;
                break;

            case Mood.ANGRY:
                newMoodImage.sprite = badMoodSprite;
                break;
        }

        currentMoodAnimation.Play();
        newMoodAnimation.Play();
    }

    public void SetCurrentMoodSprite()
    {
        currentMoodImage.sprite = newMoodImage.sprite;
    }
}
