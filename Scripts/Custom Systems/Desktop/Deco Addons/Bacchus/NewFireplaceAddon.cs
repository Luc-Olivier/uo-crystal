
////////////////////////////////////////
//                                    //
//      Generated by CEO's YAAAG      //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class NewFireplaceAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {36, -1, 1, 12}, {36, 0, 0, 12}, {36, 1, -1, 12}// 10	11	12	
			, {27, 1, -1, 1}, {28, -1, 1, 1}, {39, 0, 0, 4}// 13	14	15	
			, {2264, -1, 0, 22}, {2269, 0, -1, 22}// 19	20	
		};

 
        private static int[,] m_AddOnComplexComponents = new int[,] {
			  {1170, -1, 2, 0, 961, -1 }, {1170, 0, 1, 0, 961, -1 }, {1170, 1, 0, 0, 961, -1 }// 1	2	3	
			, {1170, 2, -1, 0, 961, -1 }, {1171, -1, 2, 0, 961, -1 }, {1171, 0, 1, 0, 961, -1 }// 4	5	6	
			, {1171, 1, 0, 0, 961, -1 }, {1171, 2, -1, 0, 961, -1 }, {14732, -1, 1, 0, 0, 1 }// 7	8	9	
			, {1305, -1, 1, 22, 961, -1 }, {1305, 0, 0, 22, 961, -1 }, {1305, 1, -1, 22, 961, -1 }// 16	17	18	
			, {1305, -1, 0, 0, 961, -1 }, {1305, 0, -1, 0, 961, -1 }, {1305, -1, 1, 0, 961, -1 }// 21	22	23	
			, {1305, 0, 0, 0, 961, -1 }, {1305, 1, -1, 0, 961, -1 }, {1305, -1, -1, 0, 961, -1 }// 24	25	26	
			, {14742, 1, -1, 0, 0, 1 }, {14732, 0, 0, 0, 0, 1 }, {14742, 0, 0, 0, 0, 1 }// 27	28	29	
					};

    
		public override BaseAddonDeed Deed
		{
			get
			{
				return new NewFireplaceAddonDeed();
			}
		}

		[ Constructable ]
		public NewFireplaceAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );

            for (int i = 0; i < m_AddOnComplexComponents.Length / 6; i++)
                AddComplexComponent( (BaseAddon)this, m_AddOnComplexComponents[i,0], m_AddOnComplexComponents[i,1], m_AddOnComplexComponents[i,2], m_AddOnComplexComponents[i,3], m_AddOnComplexComponents[i,4], m_AddOnComplexComponents[i,5] );

		}

		public NewFireplaceAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class NewFireplaceAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new NewFireplaceAddon();
			}
		}

		[Constructable]
		public NewFireplaceAddonDeed()
		{
			Name = "NewFireplace";
		}

		public NewFireplaceAddonDeed( Serial serial ) : base( serial )
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