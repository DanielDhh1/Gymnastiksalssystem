using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gymnastiksalssystem
{
    public class Gruppe
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Participants { get; set; }
        public int Id { get => Id; set => Id = value; }

        public Gruppe(string name, int age, int participants, int id)
        {
            Name = name;
            Age = age;
            Participants = participants;
            Id = id;
        }


        public override string ToString()
        {
            return $"Gruppenavn:{Name}\nAldersgruppe:{Age}\nAntal deltagere:{Participants}\nGruppe ID:{Id}";
        }

            public List<Gruppe> Groups = new List<Gruppe>();

            public void AddGroup(Gruppe group)
            {
                group.AddGroup(group);
            }

            public void RemoveGroup(Gruppe group)
            {
                group.RemoveGroup(group);
            }
            public void UpdateGroup(Gruppe updatedGroup)
            {
                Gruppe groupToUpdate = Groups.Find(g => g.Id == updatedGroup.Id);
                if (groupToUpdate != null)
                {
                    groupToUpdate.Name = updatedGroup.Name;
                    groupToUpdate.Age = updatedGroup.Age;
                    groupToUpdate.Participants = updatedGroup.Participants;
                }
            }
            public  void PrintAllGroups()
            {
                foreach (Gruppe gruppe in Groups)
                {
                    Console.WriteLine($"Gruppe ID: {gruppe.Id}, Gruppenavn: {gruppe.Name}, Aldersgruppe: {gruppe.Age}, Antal deltagere: {gruppe.Participants}");
                }
            }
        }
    }
}

    
    


