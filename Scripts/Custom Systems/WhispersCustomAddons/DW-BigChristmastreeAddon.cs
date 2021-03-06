
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
	public class DWBigChristmastreeAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6089, -1, 3, 0}, {6091, -1, -4, 0}, {6077, -2, -2, 0}// 1	2	4	
			, {6077, -1, -2, 0}, {3287, -1, 2, 11}, {6077, -3, -1, 0}// 7	8	10	
			, {6087, 2, 3, 0}, {3289, -1, 1, 7}, {6077, -3, -1, 0}// 11	12	14	
			, {6077, 0, -3, 0}, {6092, 3, 1, 0}, {11225, -1, 4, 18}// 17	18	19	
			, {6078, -1, 2, 0}, {6086, 3, -3, 0}, {6077, 2, -1, 0}// 22	27	28	
			, {6091, 1, -4, 0}, {3289, -2, -1, 19}, {6077, 2, 0, 0}// 29	31	32	
			, {6092, 3, -2, 0}, {6092, 3, -1, 0}, {6077, -2, 1, 0}// 33	34	35	
			, {3287, -1, 0, 22}, {3289, -1, -1, 10}, {6081, 2, 2, 0}// 36	37	38	
			, {6090, -4, -1, 0}, {6077, 0, 2, 0}, {6078, -1, 1, 0}// 39	40	42	
			, {6077, 1, 1, 0}, {3287, 1, -1, 19}, {6082, -3, 2, 0}// 43	45	47	
			, {6077, -1, -1, 0}, {3287, 0, 0, 29}, {6077, -2, 2, 0}// 49	50	53	
			, {6077, -2, -1, 0}, {6091, -2, -4, 0}, {6077, -2, 0, 0}// 54	57	58	
			, {6077, 2, 1, 0}, {3289, 0, -2, 11}, {3286, -1, -1, 13}// 59	62	64	
			, {6089, -2, 3, 0}, {3289, 1, 0, 24}, {11232, 1, 2, 0}// 66	67	68	
			, {6077, 0, -2, 0}, {6077, 1, 0, 0}, {6077, 1, -3, 0}// 71	73	74	
			, {6084, 2, -3, 0}, {6078, 1, -2, 0}, {3289, 1, -2, 6}// 75	76	77	
			, {6077, -1, -3, 0}, {3287, 0, -1, 25}, {6089, 0, 3, 0}// 78	79	80	
			, {3289, -2, 1, 11}, {3289, 0, -1, 11}, {3288, -1, -1, 13}// 81	82	83	
			, {933, -1, -1, 0}, {6077, 1, 2, 0}, {3289, -2, 0, 0}// 84	85	88	
			, {3289, -2, -2, 26}, {3289, -2, 0, 16}, {933, -1, -1, 5}// 90	91	93	
			, {6085, -3, -4, 0}, {3287, 1, -2, 8}, {6077, -1, 0, 0}// 94	96	101	
			, {3289, -1, -2, 19}, {6077, 0, 1, 0}, {6077, -3, 1, 0}// 102	104	105	
			, {11227, 2, 1, 27}, {6086, 2, -4, 0}, {6092, 3, 0, 0}// 106	114	116	
			, {6077, -2, -3, 0}, {10299, -2, -2, 64}, {6088, -4, 2, 0}// 117	119	120	
			, {3287, 0, -1, 5}, {3287, 1, 1, 26}, {3289, 1, -1, 8}// 122	123	124	
			, {6077, -3, -2, 0}, {6091, 0, -4, 0}, {11231, 2, 1, 0}// 126	128	129	
			, {6077, 0, -1, 0}, {6085, -4, -3, 0}, {6088, -3, 3, 0}// 130	131	132	
			, {6090, -4, 0, 0}, {6077, 2, -2, 0}, {6090, -4, 1, 0}// 133	134	135	
			, {6087, 3, 2, 0}, {6077, 0, 0, 0}, {11230, 2, 1, 0}// 136	137	138	
			, {6078, 1, -1, 0}, {6083, -3, -3, 0}, {6089, 1, 3, 0}// 140	142	143	
			, {11229, 1, 2, 0}, {6090, -4, -2, 0}// 144	146	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DWBigChristmastreeAddonDeed();
			}
		}

		[ Constructable ]
		public DWBigChristmastreeAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9003, 1, -1, 0, 33, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4046, -1, 4, 25, 1360, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 5168, 2, 0, 28, 0, 1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 5168, 0, 0, 59, 45, 1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 4046, 0, 3, 50, 38, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 9003, -1, 2, 0, 2956, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 9003, 2, 0, 0, 1650, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 5168, -1, 1, 61, 90, 1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 11234, 0, 2, 49, 2117, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 4050, 2, 3, 60, 38, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 4050, 3, 1, 77, 38, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 5168, 1, 1, 58, 0, 1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 4046, 2, 1, 28, 1360, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 4050, 3, 1, 61, 1360, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 4050, 2, 0, 35, 1360, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 5168, 0, 1, 72, 40, 1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 4046, 1, 1, 28, 1360, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 5168, -1, 3, 24, 54, 1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 4050, 2, 2, 37, 1360, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 5168, 1, 2, 36, 54, 1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 4050, 3, -1, 44, 38, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 4050, 4, -1, 28, 1360, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 9003, 2, -1, 0, 1284, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 9003, 1, 1, 0, 1172, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 9000, 1, 0, 1, 318, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 5168, 3, -1, 26, 40, 1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 4050, 1, 1, 60, 1360, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 11233, 0, 2, 27, 1366, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 4046, 2, 4, 90, 38, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 5168, 3, 0, 59, 90, 1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 9003, 1, -1, 3, 2123, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 4046, 1, 1, 45, 38, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 9003, -2, 2, 0, 1194, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 9003, 2, -1, 4, 1108, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 5168, 2, 0, 62, 54, 1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 4050, 4, 0, 25, 38, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 9003, 1, -2, 0, 563, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 9003, -2, 1, 0, 1192, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 5168, 0, 1, 56, 310, 1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 5168, 2, 1, 59, 40, 1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 4050, 3, 0, 60, 1360, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 9003, -1, 2, 4, 1173, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 9003, 0, 0, 0, 1196, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 11234, 1, 1, 33, 1276, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 4046, 1, 3, 50, 38, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 4046, 1, 3, 64, 1360, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 5168, 1, 1, 86, 54, 1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 5168, -1, 2, 34, 90, 1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 4050, 1, 2, 25, 1360, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 5168, 2, 1, 79, 310, 1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 4050, 3, 2, 47, 1360, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 11233, 2, -1, 37, 53, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 9001, 0, 1, 1, 402, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 9002, -2, 2, 3, 513, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 9003, 2, -2, 0, 2428, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 5168, -1, 2, 45, 40, 1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 5168, 2, 0, 48, 310, 1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 9003, 0, 2, 0, 1287, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 9003, 2, -3, 0, 563, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 9003, 2, -2, 3, 1108, -1, "", 1);// 152

		}

		public DWBigChristmastreeAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
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

	public class DWBigChristmastreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DWBigChristmastreeAddon();
			}
		}

		[Constructable]
		public DWBigChristmastreeAddonDeed()
		{
			Name = "DWBigChristmastree";
		}

		public DWBigChristmastreeAddonDeed( Serial serial ) : base( serial )
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