using GSDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GSDataAccess
{
    public interface IPeopleData
    {
        Task<List<PersonModel>> GetPeople();
        Task InsertPerson(PersonModel person);
    }
}