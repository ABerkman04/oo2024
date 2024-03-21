using UnityEngine;

//Interface
public interface IDefeatedBehavior
{
    void OnDefeated();
}

public class Enemy : MonoBehaviour
{
    protected IDefeatedBehavior defeatedBehavior;

    // Constructor
    public Enemy(IDefeatedBehavior behavior)
    {
        defeatedBehavior = behavior;
    }

    public void Defeat()
    {
        if (defeatedBehavior != null)
        {
            defeatedBehavior.OnDefeated();
        }
        Debug.Log("Vastane sai lüüa!");
    }
}

public class Goblin : Enemy
{
    public Goblin() : base(new GoblinDefeatedBehavior()) { }
}

public class Dragon : Enemy
{
    public Dragon() : base(new DragonDefeatedBehavior()) { }
}

public class Villager : Enemy
{
    public Villager() : base(new VillagerDefeatedBehavior()) { }
}


public class GoblinDefeatedBehavior : IDefeatedBehavior
{
    public void OnDefeated()
    {
        Debug.Log("Goblin jooksis ära!");
    }
}

public class DragonDefeatedBehavior : IDefeatedBehavior
{
    public void OnDefeated()
    {
        Debug.Log("Draakon jättis maha aarde!");
    }
}

public class VillagerDefeatedBehavior : IDefeatedBehavior
{
    public void OnDefeated()
    {
        Debug.Log("Külamees sai viga, kaotada 30 kulda!");
    }
}

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Enemy goblin = new Goblin();
            goblin.Defeat();

            Enemy dragon = new Dragon();
            dragon.Defeat();

            Enemy villager = new Villager();
            villager.Defeat();
        }
    }
}