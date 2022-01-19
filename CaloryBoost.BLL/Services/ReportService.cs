using CaloryBoost.DAL.Repositories;
using System;

namespace CaloryBoost.BLL.Services
{
    public class ReportService
    {
        ReportRepository reportRepository;
        public ReportService()
        {
            reportRepository = new ReportRepository();
        }

        public string GetFoodName(int userId, int mealId)
        {
            if (mealId > 0 && userId > 0)
            {
                return reportRepository.GetFoodName(userId,mealId);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
        }

        public double GetWeeklyAverageCalory(int userId)
        {
            if (userId > 0)
            {
                return reportRepository.GetWeeklyAverageCalory(userId);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
        }

        public double GetMonthlyAverageCalory(int userId)
        {
            if (userId > 0)
            {
                return reportRepository.GetMonthlyAverageCalory(userId);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
        }

        public double GetWeeklyAverageCaloryByUser(int userId)
        {
            if (userId > 0)
            {
                return reportRepository.GetWeeklyAverageCaloryByUser(userId);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
        }

        public double GetMonthlyAverageCaloryByUser(int userId)
        {
            if (userId > 0)
            {
                return reportRepository.GetMonthlyAverageCaloryByUser(userId);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
        }
    }
}
