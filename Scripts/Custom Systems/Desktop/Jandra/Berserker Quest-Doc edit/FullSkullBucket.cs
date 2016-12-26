using System;
using Server;

namespace Server.Items
{
	   
	public class FullSkullBucket : Item
	{
		[Constructable]
		public FullSkullBucket() : this( null )
		{
		}

		[Constructable]
		public FullSkullBucket( string name ) : base( 0x14E0 )
		{
			Name = "a full bucket of beserker skulls";
			Weight = 10.0;
			Hue = 0x485;
		}

		public FullSkullBucket( Serial serial ) : base( serial )
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
}