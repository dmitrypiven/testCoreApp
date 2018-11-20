using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCoreApp.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;
        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePages();
            }
        }

        private void InitializePages()
        {
            _pies = new List<Pie>();
            _pies.Add(new Pie() { Id = 1, Name = "Apple Pie",Price = 12.95M,ShortDescription = "Apple Pie", LongDescription = "Apple Pie", ImageThumbnailUrl = "",ImageUrl = "",IsPieOfTheWeek = false });
            _pies.Add(new Pie() { Id = 2, Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = "Blueberry Cheese Cake", LongDescription = "Blueberry Cheese Cake", ImageThumbnailUrl = "", ImageUrl = "", IsPieOfTheWeek = false });
            _pies.Add(new Pie() { Id = 3, Name = "Cheese Cake", Price = 16.95M, ShortDescription = "Cheese Cake", LongDescription = "Cheese Cake", ImageThumbnailUrl = "", ImageUrl = "", IsPieOfTheWeek = false });
            _pies.Add(new Pie() { Id = 4, Name = "Cherry Pie", Price = 11.95M, ShortDescription = "Cherry Pie", LongDescription = "Cherry Pie", ImageThumbnailUrl = "", ImageUrl = "", IsPieOfTheWeek = false });
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(arg=>arg.Id == pieId);
        }
    }
}
