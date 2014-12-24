using UnityEngine;

namespace PatchLib
{

    public class CrewGenerator_v2 : CrewGenerator
    {

        public static ProtoCrewMember RandomCrewMemberPrototype(ProtoCrewMember.KerbalType type = ProtoCrewMember.KerbalType.Crew)
        {
            Random.seed = Random.Range(-2147483648, 2147483647);
            string randomName = CrewGenerator.GetRandomName();
            Random.seed = randomName.GetHashCode();
            ProtoCrewMember protoCrewMember = new ProtoCrewMember(type);
            protoCrewMember.rosterStatus = ProtoCrewMember.RosterStatus.Available;
            protoCrewMember.name = randomName;
            protoCrewMember.courage = 1.0f;
            protoCrewMember.stupidity = 1.0f;
            protoCrewMember.isBadass = true;
            KerbalRoster.SetExperienceTrait(protoCrewMember, null);
            return protoCrewMember;
        }

        public static string GetRandomName()
        {
            return "JebJebJeb";
        }

    }

}
