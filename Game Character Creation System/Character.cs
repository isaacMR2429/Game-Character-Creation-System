using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character_Creation_System
{
    internal class Character
    {
        // String Fields
        public string UserName;
        public string Name;
        public string Race;
        public string Class;
        public string Role;
        public string Alignment;
        public string WeaponPreference;

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
    }
}
