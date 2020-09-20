using UnityEngine;

public class CatExcellentState : CatBaseState
{
    public override void EnterState(CatController cat)
    {
        Debug.Log("Перешел в отличное настроение.");
    }
    
    public override void Update(CatController cat)
    {
        
    }
    
    public override void Play(CatController cat)
    {
        //реакция: носится, как угорелая
        //настроение: не меняется
        cat.textDisplay.startShowingText("Ваш кот носится за мячом как угорелый...");
    }
    
    public override void Feed(CatController cat)
    {
        //реакция: быстро все съедает
        //настроение: не меняется
        cat.textDisplay.startShowingText("Ваш кот быстро все съедает...");
    }
    
    public override void Stroke(CatController cat)
    {
        //реакция: мурлычет и виляет хвостом
        //настроение: не меняется
        cat.textDisplay.startShowingText("Ваш кот мурлычет и виляет хвостом...");
    }
    
    public override void Kick(CatController cat)
    {
        //реакция: убегает в другую комнату
        //настроение: плохое
        cat.textDisplay.startShowingText("Ваш кот убегает в другую комнату...");
        cat.fadeInOut.StartFadeInOut(cat.fadeInOut.excellentSprite, cat.fadeInOut.badSprite);
        cat.TransitionToState(cat.BadState);
        cat.indicateMood.ChangeMood(Mood.ANGRY);
        cat.emmitParticles.StartEmmitParticles(Mood.ANGRY);
    }
}