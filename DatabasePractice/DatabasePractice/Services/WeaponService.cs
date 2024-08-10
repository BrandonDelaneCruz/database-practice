using DatabasePractice.Data;
using DatabasePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePractice.Services
{
    public class WeaponService
    {
        private DataContext _context;

        public WeaponService(DataContext context)
        {
            _context = context;
        }

        public Weapon GetWeaponById(int id)
        {
            Weapon weaponToReturn = 
                _context.Weapons.First(x => x.Id == id);
            return weaponToReturn;
        }

        public List<Weapon> GetAllWeapons()
        {
            List<Weapon> weapons =
                _context.Weapons.ToList();
            return weapons;
        }
        public Weapon AddWeapon(Weapon weapon)
        {
            _context.Weapons.Add(weapon);
            _context.SaveChanges();
            return weapon;
        }

        public Weapon UpdateWeapon(int id, Weapon weapon)
        {
            Weapon weaponToUpdate =
                _context.Weapons.First(x => x.Id == id);

            weaponToUpdate.Name = weapon.Name;
            weaponToUpdate.Damage =
                weapon.Damage;

            _context.SaveChanges();

            return weaponToUpdate;
        }
        public void DeleteWeapon(int id)
        {
            Weapon weaponToDelete =
                _context.Weapons.First(x =>x.Id == id);
            _context.Weapons.Remove(weaponToDelete);
            
            _context.SaveChanges();
        }
    }
}
