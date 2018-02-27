using System;
using System.Collections.Generic;

namespace Cliff{
    
    class GearSlotManager
    {
        internal List<string> SlotList { get; set; }
        public GearSlotManager()
        {
            this.SlotList = new List<string>();
        }

        private void AddSlot(string Slot)
        {
            this.SlotList.Add(Slot);
        }

        public void CreateDefault(){

            this.SlotList.Clear();

            AddSlot("Helmet");
            AddSlot("Chest");
            AddSlot("Gloves");
            AddSlot("Pants");
            AddSlot("Boots");
            
            AddSlot("Belt");
            AddSlot("Primary Ring");
            AddSlot("Secondary Ring");
            AddSlot("Amulet");

            AddSlot("Weapon");
            AddSlot("Offhand");

            AddSlot("Life Flask");
            AddSlot("Mana Flask");
            AddSlot("Movement Flask");
            AddSlot("First Utitlty Flask");
            AddSlot("Second Utitlty Flask");
        }

        public string GetSlot(string s){
        
            foreach (string item in this.SlotList)
            {
                if(item == s)
                    return s;
            }

            return "ERROR: NOT FOUND";

        }

        public void Equipitem(string s, Item i){

            for (int j = 0; j < this.SlotList.Count; j++)
            {
                if(this.SlotList[j] == s){
                    
                }
            }

        }


    }
}