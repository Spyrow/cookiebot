//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Alliance
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class AllianceInvitationStateRecrutedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6392;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_invitationState;
        
        public virtual byte InvitationState
        {
            get
            {
                return m_invitationState;
            }
            set
            {
                m_invitationState = value;
            }
        }
        
        public AllianceInvitationStateRecrutedMessage(byte invitationState)
        {
            m_invitationState = invitationState;
        }
        
        public AllianceInvitationStateRecrutedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_invitationState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_invitationState = reader.ReadByte();
        }
    }
}
