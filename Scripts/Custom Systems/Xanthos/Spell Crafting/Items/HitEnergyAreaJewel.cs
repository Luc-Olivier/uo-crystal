#region AuthorHeader
//
//	SpellCrafting version 3.0, by Xanthos and TheOutkastDev
//
//  Based on original ideas and code by TheOutkastDev
//
#endregion AuthorHeader
using System;
using Server;

namespace Server.SpellCrafting.Items
{
	public class HitEnergyAreaJewel : BaseSpellCraft
	{
		[Constructable]
		public HitEnergyAreaJewel() : this( 1 )
		{
		}

		[Constructable]
		public HitEnergyAreaJewel( int amount ) : base( amount, 23 )
		{
		}

		public HitEnergyAreaJewel( Serial serial ) : base( serial )
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
			int version = reader.ReadInt(); // version
		}
	}
}
