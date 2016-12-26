using System;
using Server;
using Server.Targeting; 
using Server.Mobiles; 

namespace Server.Items
{
	   
	public class SkullBucket : Item
	{

		[Constructable]
		public SkullBucket() : this( null )
		{
		}

		[Constructable]
		public SkullBucket( string name ) : base(  0x14E0)
		{
			Name = "an empty skull bucket";
			Weight = 1.0;
			Hue = 0;
		}

		public SkullBucket( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.

			else
				from.Target = new ClaimEttinTarget( this );

		}
	
        		public class ClaimEttinTarget : Target
        		{
			private SkullBucket m_BloodyBucket;

            			public ClaimEttinTarget( Mobile from ) : base( 6 /* RANGE */, false /* ALLOWGROUND */, TargetFlags.None /* BENEFICAL / HARMFUL / NONE */ )
            			{
            			}
			public ClaimEttinTarget( SkullBucket jar ) : base( 6, false, TargetFlags.None )
			{
				m_BloodyBucket = jar;
			}

            			protected override void OnTarget( Mobile from /* WHO TARGETED */, object target /* WHAT'S BEEN TARGETED */ )
			{
				if ( target is BloodyBerserkerSkull )
				{
					BloodyBerserkerSkull c = (BloodyBerserkerSkull)target;

					if ( c is BloodyBerserkerSkull )//If you want this script to claim some other creature change "Ettin" in this line.
					{
					c.Delete();
						//if ( c.Channeled == false )
						//{
						//	c.Channeled = true;
							c.Hue = 0x835;
							m_BloodyBucket.Weight +=  1.0; //I guess if you want it to go up in higher increments change the 0.1 just be careful.
							m_BloodyBucket.InvalidateProperties();
							if ( m_BloodyBucket.Weight == 1.0 )
							{
							m_BloodyBucket.Name = "a bucket of beserker skulls";
							m_BloodyBucket.Hue = 1157;
							
							from.SendMessage("As you add another skull, the bucket gets heavier.");
							}
							else if ( m_BloodyBucket.Weight <= 2.9 ){}
							else if ( m_BloodyBucket.Weight <= 3.0 )
							{
							from.SendMessage("The stench of berserkers begins to rise as you add more skulls to the jar.");
							}
							else if ( m_BloodyBucket.Weight <= 4.9 ){}
							else if ( m_BloodyBucket.Weight <= 5.0 )
							{
							from.SendMessage("You notice the bucket is nearly half-way full.");//You can change any of the messages easy, and better to what you like.
							}
							else if ( m_BloodyBucket.Weight <= 6.9 ){}
							else if ( m_BloodyBucket.Weight <= 7.0 )
							{
							from.SendMessage("As add another skull you notice the bucket is almost full.");
							}
							else if ( m_BloodyBucket.Weight <= 9.9 ){}//Always keep this number 0.1 right below the following.
							else if ( m_BloodyBucket.Weight >= 11.0 )//If you want your players to kill more ettins make the 5.0 higher.
							{
							from.SendMessage("You add the last skull and the bucket becomes full.");
							from.AddToBackpack( new FullSkullBucket() );
							m_BloodyBucket.Delete();
							}
						}

						else
						from.SendMessage("This skull has already been added to the bucket.");
					}
				}

				
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
}