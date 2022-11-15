using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager :IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
           _colorDal.Add(color);
             Console.WriteLine("Başarı ile Renk Eklendi");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Başarı ile Renk Silindi");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
            Console.WriteLine("Başarı ile Renkler Listelendi");
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Başarı ile Renk Güncellendi");
        }
    }
}
