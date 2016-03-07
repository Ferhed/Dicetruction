using UnityEngine;
using System.Collections;

public abstract class Support : Card
{
    public Support(int energy, string name) : base(energy, name)
    {

    }

    public Support(int energy, string name, Sprite image) : base(energy, name, image)
    {

    }
}
