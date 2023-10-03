using _004._01_AccsessControlLog.Common;
using _004._01_AccsessControlLog.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004._01_AccsessControlLog.Entities
{
    public class AccessControlLog:EntitiyBase<Guid>
    {
        
        public long UserId { get; set; }
        public AccsessType AccsessType { get; set; }
        public string DeviceSerialNo { get; set; }
        public DateTime LogTime { get; set; }
        public static AccsessType ConvertStringToAccessType(string accessType)
        {
            switch (accessType)
            {
                case "FP":
                    return AccsessType.FingerPrint;
                case "FACE":
                    return AccsessType.Face;
                case "CARD":
                    return AccsessType.Card;

                default:
                    throw new Exception("Adios Amigos");
            }
        }
         
        

    }
}
