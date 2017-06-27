//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.TreasureHunt
{
    using Cookie.API.Utils.IO;


    public class TreasureHuntStepFollowDirection : TreasureHuntStep
    {
        
        public new const short ProtocolId = 468;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_direction;
        
        public virtual byte Direction
        {
            get
            {
                return m_direction;
            }
            set
            {
                m_direction = value;
            }
        }
        
        private ushort m_mapCount;
        
        public virtual ushort MapCount
        {
            get
            {
                return m_mapCount;
            }
            set
            {
                m_mapCount = value;
            }
        }
        
        public TreasureHuntStepFollowDirection(byte direction, ushort mapCount)
        {
            m_direction = direction;
            m_mapCount = mapCount;
        }
        
        public TreasureHuntStepFollowDirection()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_direction);
            writer.WriteVarUhShort(m_mapCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_direction = reader.ReadByte();
            m_mapCount = reader.ReadVarUhShort();
        }
    }
}
