using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Repositories;
using MyBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccessLayer.EntityFramework
{
    //efcategorydal sadece generic repositorydeki metotlarla yetinmeyip ileride sadece category ye ilişkin metotlar isteyebilir o yüzden sadece category ye özel metotlar ICategorydal da olduğu için virgül koyup oradan da miras aldık
    //bir sınıf bir interface den miras alırken implement yapmak gerekiyor ama aşağıda implement yapmamızın sebebi genericrepository de olmuş olması 
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
