// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class PicnicElven2Addon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new PicnicElven2AddonDeed();}}
		[ Constructable ]
		public PicnicElven2Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 3204 );
			AddComponent( ac, 2, 3, 1 );

			ac = new AddonComponent( 3340 );
			AddComponent( ac, 2, 2, 1 );

			ac = new AddonComponent( 5640 );
			AddComponent( ac, 2, 1, 1 );

			ac = new AddonComponent( 6421 );
			AddComponent( ac, 2, 1, 1 );

			ac = new AddonComponent( 3316 );
			AddComponent( ac, 2, 0, 1 );

			ac = new AddonComponent( 3315 );
			AddComponent( ac, 2, -1, 1 );

			ac = new AddonComponent( 3343 );
			AddComponent( ac, 2, -2, 1 );

			ac = new AddonComponent( 3319 );
			AddComponent( ac, 1, 2, 1 );

			ac = new AddonComponent( 6969 );
			AddComponent( ac, 1, 1, 1 );

			ac = new AddonComponent( 3553 );
			AddComponent( ac, 1, 1, 7 );

			ac = new AddonComponent( 7831 );
			AddComponent( ac, 1, 1, 9 );

			ac = new AddonComponent( 3555 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 1, 1, 8 );

			ac = new AddonComponent( 6968 );
			AddComponent( ac, 1, 0, 1 );

			ac = new AddonComponent( 3319 );
			AddComponent( ac, 1, -1, 1 );

			ac = new AddonComponent( 3318 );
			AddComponent( ac, 0, 2, 1 );

			ac = new AddonComponent( 6970 );
			AddComponent( ac, 0, 1, 1 );

			ac = new AddonComponent( 6967 );
			AddComponent( ac, 0, 0, 1 );

			ac = new AddonComponent( 3318 );
			AddComponent( ac, 0, -1, 1 );

			ac = new AddonComponent( 3149 );
			AddComponent( ac, 0, -1, 2 );

			ac = new AddonComponent( 3553 );
			AddComponent( ac, -1, 2, 1 );

			ac = new AddonComponent( 3341 );
			AddComponent( ac, -1, 2, 1 );

			ac = new AddonComponent( 3316 );
			AddComponent( ac, -1, 1, 1 );

			ac = new AddonComponent( 3315 );
			AddComponent( ac, -1, 0, 1 );

			ac = new AddonComponent( 3149 );
			AddComponent( ac, -1, 0, 1 );

			ac = new AddonComponent( 8753 );
			AddComponent( ac, -1, -1, 0 );

			ac = new AddonComponent( 7711 );
			AddComponent( ac, -1, -1, 8 );

			ac = new AddonComponent( 2547 );
			AddComponent( ac, -1, -1, 6 );

			ac = new AddonComponent( 3342 );
			AddComponent( ac, -2, 1, 1 );


		}
		public PicnicElven2Addon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class PicnicElven2AddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new PicnicElven2Addon();}}
		[Constructable]
		public PicnicElven2AddonDeed(){Name = "PicnicElven2";}
		public PicnicElven2AddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}