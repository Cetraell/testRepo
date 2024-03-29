using CallForPappersService.Data;
using CallForPappersService.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CallForPappersService.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly DataContext _context;
        public ActivityRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Activity> Activities()
        {
            return _context.Activities.ToList();
        }

        public Activity GetActivity(int activityId)
        {
            // заглушка, сделать правильно
            //return _context.Activities.Where(x => x.Id == activityId).FirstOrDefault();
            return new Activity();
        }
    }
}
