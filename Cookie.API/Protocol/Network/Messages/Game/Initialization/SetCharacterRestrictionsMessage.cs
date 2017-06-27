//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Initialization
{
    using Cookie.API.Protocol.Network.Types.Game.Character.Restriction;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class SetCharacterRestrictionsMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 170;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ActorRestrictionsInformations m_restrictions;
        
        public virtual ActorRestrictionsInformations Restrictions
        {
            get
            {
                return m_restrictions;
            }
            set
            {
                m_restrictions = value;
            }
        }
        
        private double m_actorId;
        
        public virtual double ActorId
        {
            get
            {
                return m_actorId;
            }
            set
            {
                m_actorId = value;
            }
        }
        
        public SetCharacterRestrictionsMessage(ActorRestrictionsInformations restrictions, double actorId)
        {
            m_restrictions = restrictions;
            m_actorId = actorId;
        }
        
        public SetCharacterRestrictionsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_restrictions.Serialize(writer);
            writer.WriteDouble(m_actorId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_restrictions = new ActorRestrictionsInformations();
            m_restrictions.Deserialize(reader);
            m_actorId = reader.ReadDouble();
        }
    }
}
