using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_Creation_System
{
    public class Character
    {
        // String Fields
        public string UserName;
        public string Name;
        public string Race;
        public string CharacterClass;
        public string Role;
        public string Alignment;
        public string WeaponChoice;

        // Numberic fields
        public int Level;
        public int Strength;
        public int Intelligence;
        public int Vitality;
        public int Charisma;
        public int Dexterity;
        public int Wisdom;
        public int Luck;
        public int CompletedQuests;

        // Boolean Fields
        public bool IsMagicUser;
        public bool IsRanged;
        public bool IsGuildMember;

        // Selection Based Fields
        public int DifficultyLevel;
        public int ExperienceLevel;

        // My extra choosen Fields 
        public string ClassType;
        public bool HasCompanion;
        public bool IsCombatReady;

        public Character (
            string userName, 
            string name,
            string race,
            string characterClass,
            string role,
            string alignment,
            string weaponChoice,
            int level,
            int strength,
            int intelligence,
            int vitality,
            int charisma,
            int dexterity,
            int wisdom,
            int luck,
            int completedQuests,
            bool isMagicUser,
            bool isRanged,
            bool isGuildMember,
            int difficultyLevel,
            int experienceLevel,
            bool hasCompanion
            )
        {
            UserName = userName;
            Name = name;
            Race = race;
            CharacterClass = characterClass;
            Role = role;
            Alignment = alignment;
            WeaponChoice = weaponChoice;
            Level = level;
            Strength = strength;
            Intelligence = intelligence;
            Vitality = vitality;
            Charisma = charisma;
            Dexterity = dexterity;
            Wisdom = wisdom;
            Luck = luck;
            CompletedQuests = completedQuests;
            IsMagicUser = isMagicUser;
            IsRanged = isRanged;
            IsGuildMember = isGuildMember;
            DifficultyLevel = difficultyLevel;
            ExperienceLevel = experienceLevel;
            HasCompanion = hasCompanion;

            ClassType = DeterminingClassType();
            IsCombatReady = DeterminingCombatReadiness();
        }
        public string DeterminingClassType()
        {
            if (Vitality >= 15 && Strength >= 12)
            {
                return "Tank";
            }
            else if (Intelligence >= 15 && IsMagicUser == true)
            {
                return "Wizard";
            }
            else if (Dexterity >= 14 && Charisma >= 12)
            {
                return "Healer";
            }
            return "Balanced";
        }
        public bool DeterminingCombatReadiness()
        {
            if (Level >= 10 && CompletedQuests >= 5)
            {
                if (DifficultyLevel >= 3 && Level < 15)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("These are the Character Details");
            Console.WriteLine($"User's Name: {UserName}");
            Console.WriteLine($"Race: {Race}");
            Console.WriteLine($"Class: {CharacterClass}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Alignment: {Alignment}");
            Console.WriteLine($"Weapon Choice: {WeaponChoice}");
            Console.WriteLine("\nThese are the Character Stats");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Vitality: {Vitality}");
            Console.WriteLine($"Charisma: {Charisma}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine($"Wisdom: {Wisdom}");
            Console.WriteLine($"Luck: {Luck}");
            Console.WriteLine($"Completed Quests: {CompletedQuests}");
            Console.WriteLine($"Magic User: {IsMagicUser}");
            Console.WriteLine($"Ranged Fighter: {IsRanged}");
            Console.WriteLine($"Guild Member: {IsGuildMember}");
            Console.WriteLine($"Has Companion: {HasCompanion}");
            Console.WriteLine($"Difficulty Level: {DifficultyLevel}");
            Console.WriteLine($"Experience Level: {ExperienceLevel}");
            Console.WriteLine($"Class Type: {ClassType}");
            Console.WriteLine($"Combat Ready: {IsCombatReady}");
            
        }
    }
}
