using System.Runtime.Serialization;

namespace Aladdin.Models {
    
    [DataContract]
    public class Movie{
        [DataMember]
        public int Id {get;set;}
        [DataMember]
        public string Name {get;set;}
        [DataMember]
        public string Rating {get;set;}
    }
}