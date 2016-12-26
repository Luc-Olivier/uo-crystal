using System;
using Xanthos.Evo;
using Xanthos.ShrinkSystem;

namespace Server.Items 
{ 
    public class MiscItemsBag : Bag 
    { 

        [Constructable] 
        public MiscItemsBag() 
        { 
			this.Name = "Miscellaneous Items Starter Bag";
			this.Hue = 150;
			this.DropItem(new HousePlacementTool());
			this.DropItem(new BankCheck(100000));
			this.DropItem(new MercenaryDeed());
			this.DropItem(new PetLeash());
			//this.DropItem(new PetSlotDeed());
			//this.DropItem(new StarterSash());
			//this.DropItem(new SkillBall5x100());
			//this.DropItem(new StatBall());
	
        }

        public MiscItemsBag(Serial serial)
            : base(serial)
        { 
        }

        public override void Serialize(GenericWriter writer) 
        { 
            base.Serialize(writer); 

            writer.Write((int)0); // version 
        }

        public override void Deserialize(GenericReader reader) 
        { 
            base.Deserialize(reader); 

            int version = reader.ReadInt(); 
        }
    }
}