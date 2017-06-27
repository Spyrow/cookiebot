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
    
    
    public class PartyInvitationRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5585;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_name;
        
        public virtual string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        
        public PartyInvitationRequestMessage(string name)
        {
            m_name = name;
        }
        
        public PartyInvitationRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_name = reader.ReadUTF();
        }
    }
}
