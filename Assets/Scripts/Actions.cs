using TMPro;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public TextMeshProUGUI outputText;

   public void Talk (Animal animal) // ABSTRACTION
    {
        outputText.SetText(animal.Talk());
    }

    public void Eat(Animal animal) // ABSTRACTION
    {
        outputText.SetText(animal.GoEating());
        animal.EatenLevel++;
    }
}
