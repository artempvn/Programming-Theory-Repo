using UnityEngine;

public class Dog : Animal // INHERITANCE
{
    public override string Talk() // POLYMORPHISM
    {
        return "Woow woow";
    }

    public override string GoEating() // POLYMORPHISM
    {
        return "Dog is very hangry. " + base.GoEating();
    }
}
