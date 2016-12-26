
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CarpetBlue5x5Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2808, 2, 1, 0}, {2807, 0, -2, 0}, {2750, -1, -1, 0}// 1	2	3	
			, {2808, 2, 0, 0}, {2806, -2, 1, 0}, {2750, 0, 0, 0}// 4	5	6	
			, {2750, -1, 0, 0}, {2808, 2, -1, 0}, {2809, -1, 2, 0}// 7	8	9	
			, {2806, -2, -1, 0}, {2750, 1, 0, 0}, {2806, -2, 0, 0}// 10	11	12	
			, {2750, 0, 1, 0}, {2807, 1, -2, 0}, {2807, -1, -2, 0}// 13	14	15	
			, {2755, -2, -2, 0}, {2756, -2, 2, 0}, {2754, 2, 2, 0}// 16	17	18	
			, {2750, 0, -1, 0}, {2809, 0, 2, 0}, {2750, 1, -1, 0}// 19	20	21	
			, {2750, 1, 1, 0}, {2757, 2, -2, 0}, {2750, -1, 1, 0}// 22	23	24	
			, {2809, 1, 2, 0}// 25	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CarpetBlue5x5AddonDeed();
			}
		}

		[ Constructable ]
		public CarpetBlue5x5Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CarpetBlue5x5Addon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CarpetBlue5x5AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CarpetBlue5x5Addon();
			}
		}

		[Constructable]
		public CarpetBlue5x5AddonDeed()
		{
			Name = "CarpetBlue5x5";
		}

		public CarpetBlue5x5AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}