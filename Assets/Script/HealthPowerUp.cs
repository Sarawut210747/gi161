using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    int healthcrease;
    private void Start()
    {
        healthcrease = 20;
    }

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(healthcrease);
    }
}
