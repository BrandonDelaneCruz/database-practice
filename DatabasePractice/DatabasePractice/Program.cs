// See https://aka.ms/new-console-template for more information
using DatabasePractice.Data.Entities;
using DatabasePractice.Data;
using DatabasePractice.Services;

using DataContext context = new DataContext();
WeaponService weaponService = new WeaponService(context);   

Weapon weaponToAdd = new Weapon();

Console.Write("Name: ");
string userResponse = Console.ReadLine();
weaponToAdd.Name = userResponse;

Console.Write("Damage: ");
userResponse = Console.ReadLine();
weaponToAdd.Damage = int.Parse(userResponse);

weaponService.AddWeapon(weaponToAdd);

List<Weapon> weaponFromDatabase =
    weaponService.GetAllWeapons();

foreach (Weapon weapon in weaponFromDatabase)
{
    Console.WriteLine($"{weapon.Id} {weapon.Name} {weapon.Damage}");
}


