using UnityEngine;

public class Character
{
    public string Name;
    public int Level;

    public Character(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.Log($"Name: {Name}, Level: {Level}");
    }
}

public struct Weapon
{
    public string WeaponName;
    public int WeaponDamage;

    public Weapon(string weaponName, int weaponDamage)
    {
        WeaponName = weaponName;
        WeaponDamage = weaponDamage;
    }
}

public class Paladin : Character
{
    public Weapon EquippedWeapon;

    public Paladin(string name, int level, Weapon equippedWeapon) : base(name, level)
    {
        EquippedWeapon = equippedWeapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.Log($"Name: {Name}, Level: {Level}, Weapon: {EquippedWeapon.WeaponName} ({EquippedWeapon.WeaponDamage} damage)");
    }
}
