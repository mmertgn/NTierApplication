using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.Core.Database
{
    //base soyut ata sınıflarımız var ise core da tutarız. 
    //uygulamanın soyut sınıfları çekirdeği buradan inşaa oluyor.
    //her proje bulunması gereken çekirdek bileşenler burada olabilir.
    //genelde kendi frameworkumuzu yazmak istediğimiz zaman kullanmayı tercih ederiz.

    public interface IRepository<T> where T:class
    {
        void Add(T model);
        void Update(T model);
        void Delete(int id);
        List<T> List();
        T GetById(int id);
    }
}
