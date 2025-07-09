using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Repository
    {

        private static readonly List<Computer> _computerRepo = new();
        public static List<Computer> ComputersRepositories
        {
            get
            {
                return _computerRepo;
            }
        }

        static Repository()
        {
            _computerRepo = new List<Computer>(){
                   new Computer { Id = 1, Title = "MSİ",Description="A kalite",Image="msi.jpeg" },
                        new Computer { Id = 2, Title = "Casper",Description="B kalite",Image="casper.jpeg" },
                        new Computer { Id = 3, Title = "Monster",Description="C kalite",Image="monster.png" },
                        new Computer { Id = 4, Title = "HP",Description="B kalite",Image="hp.jpeg" },

            };
        }
        
        public static Computer? getById(int id){
            return _computerRepo.FirstOrDefault(c=> c.Id == id);
        }
    }
}