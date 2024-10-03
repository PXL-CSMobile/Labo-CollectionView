using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniFigs.Models;

namespace MiniFigs.Data
{
    public static class DataRepository
    {
        public static List<MiniFig> GetAllCharacters()
        {
            return new List<MiniFig>
            {
                new MiniFig { Name = "Bard", ImageUrl = "bard.jpg", Race="Elf" },
                new MiniFig { Name = "Bilbo", ImageUrl = "bilbo.jpg", Race="Hobbit" },
                new MiniFig { Name = "Elrond", ImageUrl = "elrond.jpg", Race="Elf" },
                new MiniFig { Name = "Galadriel", ImageUrl = "galadriel.jpg", Race="Elf" },
                new MiniFig { Name = "Gandalf", ImageUrl = "gandalf.jpg", Race="Wizard" },
                new MiniFig { Name = "Gollum", ImageUrl = "gollum.jpg", Race="Hobbit" },
                new MiniFig { Name = "Legolas", ImageUrl = "legolas.jpg", Race="Elf" },
                new MiniFig { Name = "Sam", ImageUrl = "sam.jpg", Race="Hobbit" },
            };
        }
    }
}
