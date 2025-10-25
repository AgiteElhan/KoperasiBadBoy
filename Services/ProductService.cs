using KoperasiBadBoy.Data;
using KoperasiBadBoy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiBadBoy.Services
{
    public class ProductService
    {
        private AppDbContext _db;
        public ProductService(AppDbContext db)
        {
            _db = db;
        }

        public List<Loanmaster> LoadLoanGrid()
        {
            return _db.Loanmasters.OrderByDescending(x => x.UpdateOn).ToList();
        }

        public List<Savingmaster> LoadSavingGrid()
        {
            return _db.Savingmasters.OrderByDescending(x => x.UpdateOn).ToList();
        }

        public async Task SaveOrUpdateLoan(string id, string adminFee, string name,
            string fine, string interest, string maxAmount, string minAmount, string tenor)
        {
            Loanmaster lm = new Loanmaster();
            bool isNew = true;
            if (id != null && id.Trim() != "" && id.Trim() != "...")
            {
                isNew = false;
                int idLoanMaster = int.Parse(id);
                lm = _db.Loanmasters.FirstOrDefault(lm => lm.Id == idLoanMaster);
            }

            lm.UpdateOn = DateTime.UtcNow;
            lm.Fine = decimal.Parse(fine.Replace(".", ","));
            lm.Interest = decimal.Parse(interest.Replace(".", ","));
            lm.AdminFee = decimal.Parse(adminFee);
            lm.MaxAmount = decimal.Parse(maxAmount);
            lm.MinAmount = decimal.Parse(minAmount);
            lm.Name = name;
            lm.Description = ".";
            lm.Tenor = int.Parse(tenor);

            if (isNew)
                _db.Loanmasters.Add(lm);
            else
                _db.Loanmasters.Update(lm);
            await _db.SaveChangesAsync();
        }

        public async Task SaveOrUpdateSaving(string id, string adminFee, string name,
            string fine, string interest, string maxAmount, string minAmount, string tenor)
        {
            Savingmaster sm = new Savingmaster();
            bool isNew = true;
            if (id != null && id.Trim() != "" && id.Trim() != "...")
            {
                isNew = false;
                int idSavingMaster = int.Parse(id);
                sm = _db.Savingmasters.FirstOrDefault(lm => lm.Id == idSavingMaster);
            }

            sm.UpdateOn = DateTime.UtcNow;
            sm.Fine = decimal.Parse(fine.Replace(".", ","));
            sm.Interest = decimal.Parse(interest.Replace(".", ","));
            sm.AdminFee = decimal.Parse(adminFee);
            sm.MaxAmount = decimal.Parse(maxAmount);
            sm.MinAmount = decimal.Parse(minAmount);
            sm.Name = name;
            sm.Description = ".";
            sm.Tenor = int.Parse(tenor);

            if (isNew)
                _db.Savingmasters.Add(sm);
            else
                _db.Savingmasters.Update(sm);
            await _db.SaveChangesAsync();
        }

        public async Task<Loanmaster?> FindLoanById(int id)
        {
            return await _db.Loanmasters.FirstOrDefaultAsync(lm => lm.Id == id);

        }

        public async Task<Savingmaster?> FindSavingById(int id)
        {
            return await _db.Savingmasters.FirstOrDefaultAsync(lm => lm.Id == id);
        }

        public object SetDropDownLoan()
        {
            var data = _db.Loanmasters.OrderBy(x => x.Name)
                .Select(x => new
                {
                    x.Id,
                    DisplayName = x.Name + ", t:" + x.Tenor + "(" + x.Interest + ")"
                }).ToList();

            var result = new List<object>
            {
                new { Id = 0, DisplayName = "--choose--" }
            };

            // Gabungkan data asli
            result.AddRange(data);

            return result;
        }
    }
}
