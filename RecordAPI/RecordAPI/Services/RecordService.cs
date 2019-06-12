using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecordAPI.Data;
using RecordAPI.Models.Domain_Models;

namespace RecordAPI.Services
{
    public class RecordService : IRecord
    {
        private ApplicationDbContext _context;

        public RecordService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Record>> GetAllRecordsAscending()
        {
            return await _context.Records
                .Include(record => record.Comment)
                .OrderBy(record => record.Id).ToListAsync();
        }

        public async Task<IEnumerable<Record>> GetAllRecordsDescending()
        {
            return await _context.Records
                .Include(record => record.Comment)
                .OrderByDescending(record => record.Id).ToListAsync();
        }

        public async Task<Record> GetRecordById(int id)
        {
            return await _context.Records
                .Include(record => record.Comment)
                .FirstOrDefaultAsync(record => record.Comment.ID == id);
        }
    }
}
