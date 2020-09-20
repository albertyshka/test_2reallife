using UnityEngine;

public class CatGoodState : CatBaseState
{
    public override void EnterState(CatController cat)
    {
        Debug.Log("Перешел в хорошее настроение.");
    }
    
    public override void Update(CatController cat)
    {
        
    }
    
    public override void Play(CatController cat)
    {
        //реакция: медленно бегает за мячиком
        //настроение: отличное
        cat.textDisplay.startShowingText("Ваш кот медленно бегает за мячиком...");
        cat.fadeInOut.StartFadeInOut(cat.fadeInOut.goodSprite, cat.fadeInOut.excellentSprite);
        cat.emmitParticles.StartEmmitParticles(Mood.EXCELLENT);
        cat.indicateMood.ChangeMood(Mood.EXCELLENT);
        cat.TransitionToState(cat.ExcellentState);
    }
    
    public override void Feed(CatController cat)
    {
        //реакция: быстро все съедает
        //настроение: отличное
        cat.textDisplay.startShowingText("Ваш кот быстро всё съедает...");
        cat.fadeInOut.StartFadeInOut(cat.fadeInOut.goodSprite, cat.fadeInOut.excellentSprite);
        cat.emmitParticles.StartEmmitParticles(Mood.EXCELLENT);
        cat.indicateMood.ChangeMood(Mood.EXCELLENT);
        cat.TransitionToState(cat.ExcellentState);
    }
    
    public override void Stroke(CatController cat)
    {
        //реакция: мурлычет
        //настроение: отличное
        cat.textDisplay.startShowingText("Ваш кот мурлычет...");
        cat.fadeInOut.StartFadeInOut(cat.fadeInOut.goodSprite, cat.fadeInOut.excellentSprite);
        cat.emmitParticles.StartEmmitParticles(Mood.EXCELLENT);
        cat.indicateMood.ChangeMood(Mood.EXCELLENT);
        cat.TransitionToState(cat.ExcellentState);
    }
    
    public override void Kick(CatController cat)
    {
        //реакция: убегает на ковер и писает
        //настроение: плохое
        cat.textDisplay.startShowingText("Ваш кот убегает на ковер и писает...");
        cat.fadeInOut.StartFadeInOut(cat.fadeInOut.goodSprite, cat.fadeInOut.badSprite);
        cat.emmitParticles.StartEmmitParticles(Mood.ANGRY);
        cat.indicateMood.ChangeMood(Mood.ANGRY);
        cat.TransitionToState(cat.BadState);
    }
}