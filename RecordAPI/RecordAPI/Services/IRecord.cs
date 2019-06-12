using RecordAPI.Models.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordAPI.Services
{
    public interface IRecord
    {
        Task<Record> GetRecordById(int id);
        Task<IEnumerable<Record>> GetAllRecordsAscending();
        Task<IEnumerable<Record>> GetAllRecordsDescending();
    }
}
