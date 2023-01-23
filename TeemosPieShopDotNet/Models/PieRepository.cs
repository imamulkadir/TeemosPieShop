using Microsoft.EntityFrameworkCore;

namespace TeemosPieShopDotNet.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly TeemosPieShopDbContext _teemosPieShopDbcontext;
        public PieRepository(TeemosPieShopDbContext teemosPieShopDbcontext)
        {
            _teemosPieShopDbcontext = teemosPieShopDbcontext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _teemosPieShopDbcontext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _teemosPieShopDbcontext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _teemosPieShopDbcontext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
