using System.Collections.Generic;

namespace VirtualDoormanAspNet.Models
{
    public class CommunArea
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ResidentialData ResidentialDatas { get; set; }

        public CommunArea()
        {
        }

        public CommunArea(int id, string name, ResidentialData residentialDatas)
        {
            Id = id;
            Name = name;
            ResidentialDatas = residentialDatas;
        }
    }
}
