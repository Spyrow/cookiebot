//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay
{
    using Cookie.API.Protocol.Network.Types.Game.Guild;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildInAllianceInformations : GuildInformations
    {
        
        public new const short ProtocolId = 420;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_nbMembers;
        
        public virtual sbyte NbMembers
        {
            get
            {
                return m_nbMembers;
            }
            set
            {
                m_nbMembers = value;
            }
        }
        
        public GuildInAllianceInformations(sbyte nbMembers)
        {
            m_nbMembers = nbMembers;
        }
        
        public GuildInAllianceInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(m_nbMembers);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_nbMembers = reader.ReadSByte();
        }
    }
}
