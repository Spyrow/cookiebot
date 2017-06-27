//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Friend
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class IgnoredDeleteResultMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5677;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_success;
        
        public virtual bool Success
        {
            get
            {
                return m_success;
            }
            set
            {
                m_success = value;
            }
        }
        
        private bool m_session;
        
        public virtual bool Session
        {
            get
            {
                return m_session;
            }
            set
            {
                m_session = value;
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
        
        public IgnoredDeleteResultMessage(bool success, bool session, string name)
        {
            m_success = success;
            m_session = session;
            m_name = name;
        }
        
        public IgnoredDeleteResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_success);
            BooleanByteWrapper.SetFlag(1, flag, m_session);
            writer.WriteByte(flag);
            writer.WriteUTF(m_name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag = reader.ReadByte();
            m_success = BooleanByteWrapper.GetFlag(flag, 0);
            m_session = BooleanByteWrapper.GetFlag(flag, 1);
            m_name = reader.ReadUTF();
        }
    }
}
