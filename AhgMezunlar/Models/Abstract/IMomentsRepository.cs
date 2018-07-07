using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Abstract
{
    public interface IMomentsRepository
    {
        IQueryable<Moments> GetMoments();
        Moments GetMoment(int id);
        void DeleteMoment(int momentId);
        void AddMoment(Moments moment);
        /// <summary>
        /// Anıların sadece yayınlanma durumlarına müdahale edileceği için 
        /// yayın durumları ele alınacak
        /// aynı şekilde contentler data-content olarak gömülecek
        /// </summary>
        /// <param name="show"></param>
        void UpdateMoment(bool show,int momentId);

    }
}
