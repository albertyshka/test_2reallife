using UnityEngine;

public class CatBadState : CatBaseState
{
    public override void EnterState(CatController cat)
    {
        Debug.Log("Перешел в плохое настроение.");
        
    }
    
    public override void Update(CatController cat)
    {
        
    }
    
    public override void Play(CatController cat)
    {
        //реакция: сидит на месте
        //настроение: не меняется
        cat.textDisplay.startShowingText("Ваш кот сидит на месте...");
    }
    
    public override void Feed(CatController cat)
    {
        //реакция: все съедает, но если в это время подойти - поцарапает
        //настроение: хорошее
        cat.textDisplay.startShowingText("Ваш кот ест, лучше пока к нему не подходить...");
        cat.fadeInOut.StartFadeInOut(cat.fadeInOut.badSprite, cat.fadeInOut.goodSprite);
        cat.emmitParticles.StartEmmitParticles(Mood.EXCELLENT);
        cat.indicateMood.ChangeMood(Mood.GOOD);
        cat.TransitionToState(cat.GoodState);
    }
    
    public override void Stroke(CatController cat)
    {
        //реакция: царапает
        //настроение: не меняется
        cat.textDisplay.startShowingText("Ваш кот царапает вас!");
    }
    
    public override void Kick(CatController cat)
    {
        //реакция: прыгает и кусает за правое ухо
        //настроение: не меняется
        cat.textDisplay.startShowingText("Ваш кот прыгает с невероятной силой и кусает вас за правое ухо!");
    }
}