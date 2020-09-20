using UnityEngine;
using UnityEngine.UI;

public class CatController : MonoBehaviour
{
    public TextDisplay textDisplay;
    public EmmitParticles emmitParticles;
    public IndicateMood indicateMood;
    [HideInInspector] public FadeInOut fadeInOut;

    private CatBaseState currentState;
    public CatBaseState CurrentState
    {
        get { return currentState; }
    }
    
    public readonly CatBaseState BadState = new CatBadState();
    public readonly CatGoodState GoodState = new CatGoodState();
    public readonly CatExcellentState ExcellentState = new CatExcellentState();
    
    private void Start()
    {
        fadeInOut = GetComponent<FadeInOut>();
        TransitionToState(GoodState);
    }
    
    private void Update()
    {
        currentState.Update(this);
    }
    
    public void TransitionToState(CatBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
    
    public void Play()
    {
        currentState.Play(this);
    }
    
    public void Feed()
    {
        currentState.Feed(this);
    }
    
    public void Stroke()
    {
        currentState.Stroke(this);
    }
    
    public void Kick()
    {
        currentState.Kick(this);
    }
}
