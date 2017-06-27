//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Data.Items.Effects
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ObjectEffectCreature : ObjectEffect
    {
        
        public new const short ProtocolId = 71;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_monsterFamilyId;
        
        public virtual ushort MonsterFamilyId
        {
            get
            {
                return m_monsterFamilyId;
            }
            set
            {
                m_monsterFamilyId = value;
            }
        }
        
        public ObjectEffectCreature(ushort monsterFamilyId)
        {
            m_monsterFamilyId = monsterFamilyId;
        }
        
        public ObjectEffectCreature()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_monsterFamilyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_monsterFamilyId = reader.ReadVarUhShort();
        }
    }
}
