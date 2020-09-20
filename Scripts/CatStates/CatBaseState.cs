using UnityEngine;

public abstract class CatBaseState
{
    public abstract void EnterState(CatController cat);
    
    public abstract void Update(CatController cat);
    
    public abstract void Play(CatController cat);
    public abstract void Feed(CatController cat);
    public abstract void Stroke(CatController cat);
    public abstract void Kick(CatController cat);
    
}