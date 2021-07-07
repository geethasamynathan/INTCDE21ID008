using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIEFDemo.Models
{
  public  interface ILibraryRepository
    {
        IEnumerable<Author> GetAllAuthor();
    }
}
