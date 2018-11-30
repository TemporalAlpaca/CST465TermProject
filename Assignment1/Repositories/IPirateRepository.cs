using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Repositories
{
    interface IPirateRepository
    {
        List<PirateModel> GetPirates();

        void Insert(PirateModel pirate);

        void Delete(PirateModel pirate);
    }
}
