//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class PartyRefuseInvitationNotificationMessage : AbstractPartyEventMessage
    {
        
        public new const uint ProtocolId = 5596;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_guestId;
        
        public virtual ulong GuestId
        {
            get
            {
                return m_guestId;
            }
            set
            {
                m_guestId = value;
            }
        }
        
        public PartyRefuseInvitationNotificationMessage(ulong guestId)
        {
            m_guestId = guestId;
        }
        
        public PartyRefuseInvitationNotificationMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhLong(m_guestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_guestId = reader.ReadVarUhLong();
        }
    }
}
