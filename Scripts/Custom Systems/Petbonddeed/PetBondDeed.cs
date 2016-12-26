using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using System.Collections;
using Server.Gumps;
using Server.Targeting;
using Server.Misc;
using Server.Accounting;
using System.Xml;
using Server.Mobiles; 

namespace Server.Items
{
	public class PetBondDeed : Item
	{
		[Constructable]
		public PetBondDeed() : base( 0x14F0 )
		{
			base.Weight = 0;
			base.LootType = LootType.Blessed;
			base.Name = "A Pet Bond Deed";
		}		

		public override void OnDoubleClick( Mobile from )
		{
			if ( IsChildOf( from.Backpack ) )
			{
				from.Target = new InternalTarget(from, this);
			}
			else
			{
				from.SendMessage("This must be in your backpack to use.");
			}
		}
		
		public PetBondDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
		
	}
	
		public class InternalTarget : Target
		{
			private Mobile m_From;
			private PetBondDeed m_Deed;
			
			public InternalTarget( Mobile from, PetBondDeed deed ) :  base ( 3, false, TargetFlags.None )
			{
				m_Deed = deed;
				m_From = from;
				from.SendMessage("Select the animal you wish to bond.");
		
				
			}
			
			protected override void OnTarget( Mobile from, object targeted )
			{
				
				if (m_Deed.IsChildOf( m_From.Backpack ) )
				{					
					if ( targeted is Mobile )
					{
						if ( targeted is BaseCreature )
						{
							BaseCreature creature = (BaseCreature)targeted;
							if( !creature.Tamable ){
								from.SendMessage("This animal is not tamed.");
							}
							else if(  !creature.Controlled || creature.ControlMaster != from ){
								from.SendMessage("You do not own this animal.");
							}
							else if( creature.IsDeadPet ){
								from.SendMessage("This animal is dead.");
							}
							else if ( creature.Summoned ){
								from.SendMessage("This creature is summoned.");
							}
							else if ( creature.Body.IsHuman ){
								from.SendMessage("You cannot bond a person!");
							}
							else{	
								
								if( creature.IsBonded == true ){
									from.SendMessage("The animal is bonded.");
								}
								else{
									
									if( from.Skills[SkillName.AnimalTaming].Base  < creature.MinTameSkill ){
										from.SendMessage("You do not have enough taming to bond this creature.");
									}
									else if( from.Skills[SkillName.AnimalLore].Base  < creature.MinTameSkill ){
											from.SendMessage("You do not have enough animal lore bond this creature.");
										}
									else{
										try{
											creature.IsBonded = true;
											from.SendMessage("{0} bonded successfully ",creature.Name);
											m_Deed.Delete();
										}
										catch{
											from.SendMessage("There was a problem bonding you pet. Please contact staff.");
										}
											
									}
								}
							}							
						}
						else{
							from.SendMessage("Você pode bondar somente animais");
						}
					}
					else{
							from.SendMessage("Você pode bondar somente animais");
						}
				}
				else{
					from.SendMessage("É necessário estar em sua mochila.");
				}			
		}
	}
}
