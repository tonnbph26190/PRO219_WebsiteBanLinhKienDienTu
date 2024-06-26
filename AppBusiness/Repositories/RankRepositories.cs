﻿using AppData.FPhoneDbContexts;
using AppData.IRepositories;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class RankRepositories : IRanksRepositories
    {
        public readonly FPhoneDbContext _dbContext;

        public RankRepositories()
        {
        }

        public RankRepositories(FPhoneDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task<List<RankEntity>> GetAll()
        {
            var lst = new List<RankEntity>();
            try
            {
                lst = await _dbContext.Ranks.ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return lst;
        }

        public async Task<RankEntity> GetById(Guid id)
        {
            var ranks = new RankEntity();
            try
            {
                ranks = await _dbContext.Ranks.FirstOrDefaultAsync(p => p.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return ranks;
        }

        public async Task<List<RankEntity>> GetByYear(int days)
        {
            return await _dbContext.Ranks.Where(e => e.Days == days).ToListAsync();
          //  return true;
        }
    }
}
