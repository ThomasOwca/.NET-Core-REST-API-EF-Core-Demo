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

        public async void CreateRecord(Record record)
        {
            try
            {
                await _context.AddAsync(record);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) {}    
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

        public async Task<IEnumerable<Record>> GetRecordsByOwner(string owner)
        {
            return await _context.Records
                .Include(record => record.Comment)
                .Where(record => record.Owner == owner).ToListAsync();
        }
    }
}
