using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AZapp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AZapp.Models
{
    public class PCsService
    {
        private readonly PCbibDbContext context;
        public PCsService(PCbibDbContext _context)
        {
            context = _context;
        }
        public List<PCs> GetAllPCs()
        {
            return context.PCs.ToList();
        }
        public List<PCs> GetAllPCs(string member)
        {
            var items = context.PCs.ToList();
            foreach (var item in items)
            {
                item.Name += member;
            }
            var absent = items.FindAll(item => item.absentmember.Split(";").Contains(member));
            
            foreach (var item in absent)
                items.Remove(item);

            return items;
        }
        public List<PCs> GetPCsByCategory()
        {
            return context.PCs.OrderBy(c => c.category).ToList();
        }
        public List<PCs> GetPCsBy1Category(string cat)
        {
            return context.PCs.Where(c => c.category == cat).ToList();
        }
        public List<PCs> GetPCsByAlbum()
        {
            return context.PCs.OrderBy(c => c.album).ToList();
        }
        public List<PCs> GetPCsBy1Album(string album)
        {
            return context.PCs.Where(c => c.album == album).ToList();
        }
    }
}