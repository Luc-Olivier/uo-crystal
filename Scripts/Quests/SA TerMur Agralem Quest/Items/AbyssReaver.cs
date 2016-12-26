namespace Server.Items
{
    public class AbyssReaver : BaseThrown
    {
        [Constructable]
        public AbyssReaver()
            : base(0x901)
        {
            Weight = 6.0;
            Layer = Layer.OneHanded;
            Hue = 1195;

            SkillBonuses.SetValues(0, SkillName.Throwing, 10.0);
            Attributes.AttackChance = 15;
            Attributes.WeaponSpeed = 30;
            Attributes.WeaponDamage = 35;

            Slayer = SlayerName.DaemonDismissal;
        }

        public AbyssReaver(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get { return 1112694; }
        } // Abyss Reaver

        public override int MinThrowRange
        {
            get { return 4; }
        } // MaxRange 8

        public override WeaponAbility PrimaryAbility
        {
            get { return WeaponAbility.InfusedThrow; }
        }

        public override WeaponAbility SecondaryAbility
        {
            get { return WeaponAbility.MovingShot; }
        }

        /*
        Boomerang 0x8FF: MysticArc, ConcussionBlow
        Cyclone 2305/0x901: MovingShot, InfusedThrow
        Soul Glaive 2314/0x090A: ArmorIgnore, MortalStrike
        */

        public override int AosStrengthReq
        {
            get { return 40; }
        }

        public override int AosMinDamage
        {
            get { return 13; }
        }

        public override int AosMaxDamage
        {
            get { return 17; }
        }

        public override int AosSpeed
        {
            get { return 25; }
        }

        public override float MlSpeed
        {
            get { return 3.00f; }
        }

        public override int OldStrengthReq
        {
            get { return 20; }
        }

        public override int OldMinDamage
        {
            get { return 9; }
        }

        public override int OldMaxDamage
        {
            get { return 41; }
        }

        public override int OldSpeed
        {
            get { return 20; }
        }

        public override int InitMinHits
        {
            get { return 255; }
        }

        public override int InitMaxHits
        {
            get { return 255; }
        }

        public override Race RequiredRace
        {
            get { return Race.Gargoyle; }
        }

        public override bool CanBeWornByGargoyles
        {
            get { return true; }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            var version = reader.ReadInt();
        }
    }
}