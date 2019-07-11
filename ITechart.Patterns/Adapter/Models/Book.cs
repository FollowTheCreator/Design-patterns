using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ITechart.Patterns.Adapter.Models
{
    [DataContract]
    class Book
    {
        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public int DateOfCreation { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
